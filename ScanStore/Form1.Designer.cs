namespace ScanStore
{
    partial class ScanStore
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ScanStore));
            this.StatusBar = new System.Windows.Forms.StatusStrip();
            this.ScannedLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.itemCount = new System.Windows.Forms.ToolStripStatusLabel();
            this.DupeLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.dupeCount = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ExportButton = new System.Windows.Forms.Button();
            this.ClearListButton = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.listScanned = new System.Windows.Forms.ListBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.listDuplicates = new System.Windows.Forms.ListBox();
            this.saveFile = new System.Windows.Forms.SaveFileDialog();
            this.contextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.Export = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.Quit = new System.Windows.Forms.ToolStripMenuItem();
            this.adminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectComPortToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripComboBox1 = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ComPort = new System.IO.Ports.SerialPort(this.components);
            this.Notification = new System.Windows.Forms.NotifyIcon(this.components);
            this.StatusBar.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.contextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // StatusBar
            // 
            this.StatusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ScannedLabel,
            this.itemCount,
            this.DupeLabel,
            this.dupeCount,
            this.toolStripStatusLabel2});
            this.StatusBar.Location = new System.Drawing.Point(0, 382);
            this.StatusBar.Name = "StatusBar";
            this.StatusBar.Size = new System.Drawing.Size(275, 22);
            this.StatusBar.TabIndex = 0;
            this.StatusBar.Text = "StatusBar";
            // 
            // ScannedLabel
            // 
            this.ScannedLabel.Name = "ScannedLabel";
            this.ScannedLabel.Size = new System.Drawing.Size(58, 17);
            this.ScannedLabel.Text = "Scanned: ";
            // 
            // itemCount
            // 
            this.itemCount.Name = "itemCount";
            this.itemCount.Size = new System.Drawing.Size(14, 17);
            this.itemCount.Text = "n";
            // 
            // DupeLabel
            // 
            this.DupeLabel.Name = "DupeLabel";
            this.DupeLabel.Size = new System.Drawing.Size(68, 17);
            this.DupeLabel.Text = "Duplicates: ";
            // 
            // dupeCount
            // 
            this.dupeCount.Name = "dupeCount";
            this.dupeCount.Size = new System.Drawing.Size(14, 17);
            this.dupeCount.Text = "n";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(118, 15);
            this.toolStripStatusLabel2.Text = "toolStripStatusLabel2";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ExportButton);
            this.panel1.Controls.Add(this.ClearListButton);
            this.panel1.Controls.Add(this.tabControl1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(275, 382);
            this.panel1.TabIndex = 1;
            // 
            // ExportButton
            // 
            this.ExportButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ExportButton.Location = new System.Drawing.Point(158, 3);
            this.ExportButton.Name = "ExportButton";
            this.ExportButton.Size = new System.Drawing.Size(110, 25);
            this.ExportButton.TabIndex = 2;
            this.ExportButton.Text = "Export";
            this.ExportButton.UseVisualStyleBackColor = true;
            this.ExportButton.Click += new System.EventHandler(this.Export_Click);
            // 
            // ClearListButton
            // 
            this.ClearListButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ClearListButton.Location = new System.Drawing.Point(7, 3);
            this.ClearListButton.Name = "ClearListButton";
            this.ClearListButton.Size = new System.Drawing.Size(110, 25);
            this.ClearListButton.TabIndex = 1;
            this.ClearListButton.Text = "Clear List\'s";
            this.ClearListButton.UseVisualStyleBackColor = true;
            this.ClearListButton.Click += new System.EventHandler(this.Clear_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 34);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(275, 345);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.listScanned);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(267, 319);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Scanned";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // listScanned
            // 
            this.listScanned.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listScanned.FormattingEnabled = true;
            this.listScanned.Location = new System.Drawing.Point(3, 3);
            this.listScanned.Name = "listScanned";
            this.listScanned.Size = new System.Drawing.Size(261, 313);
            this.listScanned.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.listDuplicates);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(267, 319);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Duplicates";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // listDuplicates
            // 
            this.listDuplicates.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listDuplicates.FormattingEnabled = true;
            this.listDuplicates.Location = new System.Drawing.Point(3, 3);
            this.listDuplicates.Name = "listDuplicates";
            this.listDuplicates.Size = new System.Drawing.Size(261, 313);
            this.listDuplicates.TabIndex = 0;
            // 
            // saveFile
            // 
            this.saveFile.DefaultExt = "xlsx";
            this.saveFile.Filter = "Excel 2007/2010 files|*.xlsx";
            // 
            // contextMenu
            // 
            this.contextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.adminToolStripMenuItem});
            this.contextMenu.Name = "contextMenuStrip1";
            this.contextMenu.Size = new System.Drawing.Size(111, 48);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Export,
            this.toolStripMenuItem2,
            this.Quit});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(110, 22);
            this.toolStripMenuItem1.Text = "&File";
            // 
            // Export
            // 
            this.Export.Name = "Export";
            this.Export.Size = new System.Drawing.Size(130, 22);
            this.Export.Text = "Export";
            this.Export.Click += new System.EventHandler(this.Export_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(130, 22);
            this.toolStripMenuItem2.Text = "Clear List\'s";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.Clear_Click);
            // 
            // Quit
            // 
            this.Quit.Name = "Quit";
            this.Quit.Size = new System.Drawing.Size(130, 22);
            this.Quit.Text = "Quit";
            // 
            // adminToolStripMenuItem
            // 
            this.adminToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selectComPortToolStripMenuItem,
            this.toolStripTextBox1});
            this.adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            this.adminToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.adminToolStripMenuItem.Text = "&Admin";
            // 
            // selectComPortToolStripMenuItem
            // 
            this.selectComPortToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripComboBox1});
            this.selectComPortToolStripMenuItem.Name = "selectComPortToolStripMenuItem";
            this.selectComPortToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.selectComPortToolStripMenuItem.Text = "Select Com Port...";
            // 
            // toolStripComboBox1
            // 
            this.toolStripComboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.toolStripComboBox1.DropDownHeight = 100;
            this.toolStripComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.toolStripComboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.toolStripComboBox1.IntegralHeight = false;
            this.toolStripComboBox1.Items.AddRange(new object[] {
            "Com1",
            "Com2",
            "Com3",
            "Com4",
            "Com5",
            "Com6",
            "Com7",
            "Com8",
            "Com9"});
            this.toolStripComboBox1.MergeAction = System.Windows.Forms.MergeAction.MatchOnly;
            this.toolStripComboBox1.Name = "toolStripComboBox1";
            this.toolStripComboBox1.Size = new System.Drawing.Size(121, 23);
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(178, 22);
            this.toolStripTextBox1.Text = "Autoclear on Export";
            this.toolStripTextBox1.Click += new System.EventHandler(this.AutoClearOnExport_Check);
            // 
            // ComPort
            // 
            this.ComPort.BaudRate = 19200;
            this.ComPort.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.sp_DataReceived);
            // 
            // Notification
            // 
            this.Notification.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Warning;
            this.Notification.BalloonTipTitle = "Scans";
            this.Notification.Icon = ((System.Drawing.Icon)(resources.GetObject("Notification.Icon")));
            this.Notification.Text = "ScanStore";
            this.Notification.Visible = true;
            this.Notification.BalloonTipClosed += new System.EventHandler(this.notify_BalloonTipClosed);
            this.Notification.MouseMove += new System.Windows.Forms.MouseEventHandler(this.notify_MouseOver);
            // 
            // ScanStore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(275, 404);
            this.ContextMenuStrip = this.contextMenu;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.StatusBar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ScanStore";
            this.Text = "ScanStore";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Window_Closing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ScanStore_FormClosed);
            this.StatusBar.ResumeLayout(false);
            this.StatusBar.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.contextMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip StatusBar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button ClearListButton;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ListBox listScanned;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ListBox listDuplicates;
        private System.Windows.Forms.ToolStripStatusLabel ScannedLabel;
        private System.Windows.Forms.ToolStripStatusLabel itemCount;
        private System.Windows.Forms.ToolStripStatusLabel DupeLabel;
        private System.Windows.Forms.ToolStripStatusLabel dupeCount;
        private System.Windows.Forms.Button ExportButton;
        private System.Windows.Forms.SaveFileDialog saveFile;
        private System.Windows.Forms.ContextMenuStrip contextMenu;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem Export;
        private System.Windows.Forms.ToolStripMenuItem Quit;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem adminToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectComPortToolStripMenuItem;
        private System.IO.Ports.SerialPort ComPort;
        private System.Windows.Forms.ToolStripMenuItem toolStripTextBox1;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.NotifyIcon Notification;
    }
}

