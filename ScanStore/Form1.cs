using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO.Ports;
using System.Windows.Forms;
using System.Threading;
using Microsoft.Office.Interop.Excel;

namespace ScanStore
{

    public partial class ScanStore : Form
    {
        int items = 0;
        int duplicates = 0;
        Microsoft.Office.Interop.Excel.Application xlApp = new Microsoft.Office.Interop.Excel.Application();
        Workbook wb; Worksheet ws; Thread main; bool appRunning = true;
        private delegate void SetTextDeleg(string a);
        public ScanStore()
        {
            InitializeComponent();
            setupStatusBar();
            SetupNewSpreadSheet();
            FindComPort();
            LoadOldList();
            StartScanner();
            FinishSetup();
        }

        #region setup
        void setupStatusBar()
        {
            itemCount.Text = items.ToString();
            dupeCount.Text = duplicates.ToString();
        }
        void SetupNewSpreadSheet()
        {
            wb = xlApp.Workbooks.Add(XlWBATemplate.xlWBATWorksheet);
            ws = (Worksheet)wb.Worksheets[1];
        }
        void LoadOldList()
        {
            int b = Properties.Settings.Default.Com;
            if (Properties.Settings.Default.List.Length > 0)
            {
                string[] a = Properties.Settings.Default.List.Split(',');
                foreach (string c in a) listScanned.Items.Add(c);
                items = listScanned.Items.Count;
                itemCount.Text = items.ToString();
            }
        }
        void FinishSetup()
        {
            ComPort.DataReceived += new SerialDataReceivedEventHandler(sp_DataReceived);
            if (Properties.Settings.Default.List.Length == 0) listScanned.Items.Clear();
            if (toolStripComboBox1.SelectedIndex == -1) toolStripStatusLabel2.Text = "Select a COM port";
            else toolStripStatusLabel2.Text = ComPort.PortName + " Connected";
            toolStripTextBox1.Checked = Properties.Settings.Default.aoe;
        }
        void FindComPort()
        {
            
            toolStripComboBox1.Items.Clear();
            
            for (int i = 1; i < 15; i++)
            {
                if (ComPort.IsOpen) ComPort.Close();
                ComPort.PortName = "COM" + i;
                int portcount = 0;
                try
                {
                    ComPort.Open();
                    if (ComPort.IsOpen) ComPort.Close();

                    toolStripComboBox1.Items.Add(ComPort.PortName);
                    portcount++;
                }
                catch { }
                if (i == Properties.Settings.Default.Com)
                {
                    if (toolStripComboBox1.Items.Count == portcount) toolStripComboBox1.SelectedIndex = portcount - 1;
                    else toolStripComboBox1.SelectedIndex = portcount;
                }

            }
            this.toolStripComboBox1.SelectedIndexChanged += new System.EventHandler(this.COM_Selected);
            ComPort.PortName = "COM" + Properties.Settings.Default.Com.ToString();
            //serialPort1.PortName = "COM12";
            
        }
        void StartScanner()
        {
            if (!ComPort.IsOpen) ComPort.Open();
        }
        #endregion

        void sp_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                Thread.Sleep(500);
                string data = ComPort.ReadLine();
                // Invokes the delegate on the UI thread, and sends the data that was received to the invoked method.
                // ---- The "si_DataReceived" method will be executed on the UI thread which allows populating of the textbox.
                this.BeginInvoke(new SetTextDeleg(CheckNewItem), new object[] { data });
            }
            catch { }
        }
        
        void runScan()
        {
            while (appRunning)
            {
                string a = ComPort.ReadLine();
            }
            main.Abort();
        }
        
        void CheckNewItem(string a)
        {
            
            if (listScanned.Items.Contains(a.Trim())) duplicateAdded(a.Trim());
            else itemAdded(a.Trim());
        }

        #region handleItemAdditions
        void itemAdded(string a)
        {
            if (a == "") { }
            else
            {
                listScanned.Items.Add(a);
                if (Properties.Settings.Default.List.Length == 0) Properties.Settings.Default.List = a;
                else Properties.Settings.Default.List = Properties.Settings.Default.List + "," + a;
                Properties.Settings.Default.Save();
                items++;
                itemCount.Text = items.ToString();
                
            }
        }
        void duplicateAdded(string a)
        {
            listDuplicates.Items.Add(a);
            duplicates++;
            dupeCount.Text = duplicates.ToString();
        }
        #endregion

        #region handleItemActions
        private void Clear_Click(object sender, EventArgs e)
        {
            if (items > 0)
            {
                ((Microsoft.Office.Interop.Excel.Range)ws.Cells[1, 1]).EntireColumn.Delete(null);

                listScanned.Items.Clear();
                listDuplicates.Items.Clear();
                Properties.Settings.Default.List = "";
                Properties.Settings.Default.Save();
                itemCount.Text = "0";
                dupeCount.Text = "0";
            }
            items = 0;
            duplicates = 0;
        }
        private void Export_Click(object sender, EventArgs e)
        {
            //get list and add to worksheet
            
            if (items >= 1)
            {
                for (int i=1; i<listScanned.Items.Count+1; i++) {
                    ((Range)ws.Cells[i, 1]).Value = listScanned.Items[i - 1].ToString();
                }
            }
            

            if(saveFile.ShowDialog() == DialogResult.OK) wb.SaveAs(saveFile.FileName);
            if (Properties.Settings.Default.aoe) Clear_Click(sender, e);

        }
        #endregion

        private void Window_Closing(object sender, FormClosingEventArgs e)
        {

            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(wb);
                System.Runtime.InteropServices.Marshal.ReleaseComObject(ws);
                wb.Close(false, Type.Missing, Type.Missing);
                xlApp.Quit();
                ComPort.Close();
            }
            catch { }
            appRunning = false;
        }

        private void ScanStore_FormClosed(object sender, FormClosedEventArgs e)
        {
            xlApp.Quit();
            ComPort.Close();
            appRunning = false;
        }
        private void AutoClearOnExport_Check(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.aoe == true) Properties.Settings.Default.aoe = false;
            else Properties.Settings.Default.aoe = true;
            Properties.Settings.Default.Save();
            toolStripTextBox1.Checked = Properties.Settings.Default.aoe;
        }
        void SetupIndex()
        {
            Properties.Settings.Default.Com = Int32.Parse(toolStripComboBox1.SelectedItem.ToString().Substring(3));
            Properties.Settings.Default.Save();
            if(ComPort.IsOpen) ComPort.Close();
            ComPort.PortName = "COM" + Properties.Settings.Default.Com;
            toolStripStatusLabel2.Text = ComPort.PortName + " Connected";
        }
        private void COM_Selected(object sender, EventArgs e)
        {
            SetupIndex();
            StartScanner();
        }

        bool allowTip = true;
        private void notify_MouseOver(object sender, MouseEventArgs e)
        {
            
            if(allowTip == true) Notification.ShowBalloonTip(10000, "Scans", itemCount.Text, ToolTipIcon.Info);
            allowTip = false;
        }     
        private void notify_BalloonTipClosed(object sender, EventArgs e)
        {
            allowTip = true;
        }
    }
}
