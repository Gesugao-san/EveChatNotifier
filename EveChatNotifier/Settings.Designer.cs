namespace EveChatNotifier
{
    partial class Settings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
            this.pHint = new System.Windows.Forms.Panel();
            this.tbHelp = new System.Windows.Forms.TextBox();
            this.btnTest = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.gbPaths = new System.Windows.Forms.GroupBox();
            this.folderMoveLogs = new EveChatNotifier.HelperControls.FolderChooser();
            this.fileLog = new EveChatNotifier.HelperControls.FileChooser();
            this.folderEveChatLogs = new EveChatNotifier.HelperControls.FolderChooser();
            this.cbMoveLog = new System.Windows.Forms.CheckBox();
            this.lblMoveLogs = new System.Windows.Forms.Label();
            this.lblLogPath = new System.Windows.Forms.Label();
            this.lblEveChatLogPath = new System.Windows.Forms.Label();
            this.gbNotification = new System.Windows.Forms.GroupBox();
            this.lblVolume = new System.Windows.Forms.Label();
            this.tbarVolume = new System.Windows.Forms.TrackBar();
            this.tbNotifyKeywords = new System.Windows.Forms.TextBox();
            this.lblSoundFile = new System.Windows.Forms.Label();
            this.lblNotifyKeywords = new System.Windows.Forms.Label();
            this.fileNotifySound = new EveChatNotifier.HelperControls.FileChooser();
            this.lblNotifyOption = new System.Windows.Forms.Label();
            this.cbNotify = new System.Windows.Forms.ComboBox();
            this.gbProgramSettings = new System.Windows.Forms.GroupBox();
            this.cbLang = new System.Windows.Forms.ComboBox();
            this.lblLangSelect = new System.Windows.Forms.Label();
            this.nudAutoStartDelay = new System.Windows.Forms.NumericUpDown();
            this.lblAutostartDelay = new System.Windows.Forms.Label();
            this.nudFontSizeTitle = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.cbAutoStart = new System.Windows.Forms.CheckBox();
            this.nudFontSizeContent = new System.Windows.Forms.NumericUpDown();
            this.lblAutostart = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbUpdates = new System.Windows.Forms.CheckBox();
            this.lblUpdateCheck = new System.Windows.Forms.Label();
            this.tbMotdUsername = new System.Windows.Forms.TextBox();
            this.lblMotdUsername = new System.Windows.Forms.Label();
            this.cbIgnoreOwn = new System.Windows.Forms.CheckBox();
            this.lblIgnoreOwn = new System.Windows.Forms.Label();
            this.cbIgnoreMotd = new System.Windows.Forms.CheckBox();
            this.lblIgnoreMotd = new System.Windows.Forms.Label();
            this.gbIgnorelist = new System.Windows.Forms.GroupBox();
            this.tbIgnoreChannels = new System.Windows.Forms.TextBox();
            this.tbIgnorePilots = new System.Windows.Forms.TextBox();
            this.lblIgnoreChannels = new System.Windows.Forms.Label();
            this.lblIgnorePilots = new System.Windows.Forms.Label();
            this.gbWorkTweaks = new System.Windows.Forms.GroupBox();
            this.pHint.SuspendLayout();
            this.gbPaths.SuspendLayout();
            this.gbNotification.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbarVolume)).BeginInit();
            this.gbProgramSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAutoStartDelay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFontSizeTitle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFontSizeContent)).BeginInit();
            this.gbIgnorelist.SuspendLayout();
            this.gbWorkTweaks.SuspendLayout();
            this.SuspendLayout();
            // 
            // pHint
            // 
            resources.ApplyResources(this.pHint, "pHint");
            this.pHint.BackColor = System.Drawing.SystemColors.Control;
            this.pHint.Controls.Add(this.tbHelp);
            this.pHint.Name = "pHint";
            // 
            // tbHelp
            // 
            resources.ApplyResources(this.tbHelp, "tbHelp");
            this.tbHelp.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbHelp.Name = "tbHelp";
            this.tbHelp.ReadOnly = true;
            // 
            // btnTest
            // 
            resources.ApplyResources(this.btnTest, "btnTest");
            this.btnTest.Name = "btnTest";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.btnTestVolume_Click);
            // 
            // btnCancel
            // 
            resources.ApplyResources(this.btnCancel, "btnCancel");
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            resources.ApplyResources(this.btnSave, "btnSave");
            this.btnSave.Name = "btnSave";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // gbPaths
            // 
            resources.ApplyResources(this.gbPaths, "gbPaths");
            this.gbPaths.Controls.Add(this.folderMoveLogs);
            this.gbPaths.Controls.Add(this.fileLog);
            this.gbPaths.Controls.Add(this.folderEveChatLogs);
            this.gbPaths.Controls.Add(this.cbMoveLog);
            this.gbPaths.Controls.Add(this.lblMoveLogs);
            this.gbPaths.Controls.Add(this.lblLogPath);
            this.gbPaths.Controls.Add(this.lblEveChatLogPath);
            this.gbPaths.Name = "gbPaths";
            this.gbPaths.TabStop = false;
            // 
            // folderMoveLogs
            // 
            resources.ApplyResources(this.folderMoveLogs, "folderMoveLogs");
            this.folderMoveLogs.Name = "folderMoveLogs";
            this.folderMoveLogs.SelectedFolder = "";
            // 
            // fileLog
            // 
            resources.ApplyResources(this.fileLog, "fileLog");
            this.fileLog.BackColor = System.Drawing.SystemColors.Window;
            this.fileLog.Name = "fileLog";
            this.fileLog.SelectedFile = "";
            // 
            // folderEveChatLogs
            // 
            resources.ApplyResources(this.folderEveChatLogs, "folderEveChatLogs");
            this.folderEveChatLogs.Name = "folderEveChatLogs";
            this.folderEveChatLogs.SelectedFolder = "";
            // 
            // cbMoveLog
            // 
            resources.ApplyResources(this.cbMoveLog, "cbMoveLog");
            this.cbMoveLog.Name = "cbMoveLog";
            this.cbMoveLog.UseVisualStyleBackColor = true;
            this.cbMoveLog.CheckedChanged += new System.EventHandler(this.cbMoveLog_CheckedChanged);
            // 
            // lblMoveLogs
            // 
            resources.ApplyResources(this.lblMoveLogs, "lblMoveLogs");
            this.lblMoveLogs.Cursor = System.Windows.Forms.Cursors.Help;
            this.lblMoveLogs.Name = "lblMoveLogs";
            this.lblMoveLogs.MouseEnter += new System.EventHandler(this.lblMoveLogs_MouseEnter);
            // 
            // lblLogPath
            // 
            resources.ApplyResources(this.lblLogPath, "lblLogPath");
            this.lblLogPath.Cursor = System.Windows.Forms.Cursors.Help;
            this.lblLogPath.Name = "lblLogPath";
            this.lblLogPath.MouseEnter += new System.EventHandler(this.lblLogFile_MouseEnter);
            // 
            // lblEveChatLogPath
            // 
            resources.ApplyResources(this.lblEveChatLogPath, "lblEveChatLogPath");
            this.lblEveChatLogPath.Cursor = System.Windows.Forms.Cursors.Help;
            this.lblEveChatLogPath.Name = "lblEveChatLogPath";
            this.lblEveChatLogPath.MouseEnter += new System.EventHandler(this.lblEveChatLogs_MouseEnter);
            // 
            // gbNotification
            // 
            resources.ApplyResources(this.gbNotification, "gbNotification");
            this.gbNotification.Controls.Add(this.lblVolume);
            this.gbNotification.Controls.Add(this.tbarVolume);
            this.gbNotification.Controls.Add(this.tbNotifyKeywords);
            this.gbNotification.Controls.Add(this.lblSoundFile);
            this.gbNotification.Controls.Add(this.lblNotifyKeywords);
            this.gbNotification.Controls.Add(this.fileNotifySound);
            this.gbNotification.Controls.Add(this.lblNotifyOption);
            this.gbNotification.Controls.Add(this.cbNotify);
            this.gbNotification.Name = "gbNotification";
            this.gbNotification.TabStop = false;
            // 
            // lblVolume
            // 
            resources.ApplyResources(this.lblVolume, "lblVolume");
            this.lblVolume.Name = "lblVolume";
            this.lblVolume.MouseEnter += new System.EventHandler(this.lblVolume_MouseEnter);
            // 
            // tbarVolume
            // 
            resources.ApplyResources(this.tbarVolume, "tbarVolume");
            this.tbarVolume.Maximum = 100;
            this.tbarVolume.Name = "tbarVolume";
            this.tbarVolume.TickFrequency = 10;
            this.tbarVolume.Value = 100;
            // 
            // tbNotifyKeywords
            // 
            resources.ApplyResources(this.tbNotifyKeywords, "tbNotifyKeywords");
            this.tbNotifyKeywords.Name = "tbNotifyKeywords";
            // 
            // lblSoundFile
            // 
            resources.ApplyResources(this.lblSoundFile, "lblSoundFile");
            this.lblSoundFile.Cursor = System.Windows.Forms.Cursors.Help;
            this.lblSoundFile.Name = "lblSoundFile";
            this.lblSoundFile.MouseEnter += new System.EventHandler(this.lblSoundFile_MouseEnter);
            // 
            // lblNotifyKeywords
            // 
            resources.ApplyResources(this.lblNotifyKeywords, "lblNotifyKeywords");
            this.lblNotifyKeywords.Cursor = System.Windows.Forms.Cursors.Help;
            this.lblNotifyKeywords.Name = "lblNotifyKeywords";
            this.lblNotifyKeywords.MouseEnter += new System.EventHandler(this.lblNotifyKeywords_MouseEnter);
            // 
            // fileNotifySound
            // 
            resources.ApplyResources(this.fileNotifySound, "fileNotifySound");
            this.fileNotifySound.BackColor = System.Drawing.SystemColors.Window;
            this.fileNotifySound.Name = "fileNotifySound";
            this.fileNotifySound.SelectedFile = "";
            this.fileNotifySound.EnabledChanged += new System.EventHandler(this.fileNotifySound_EnabledChanged);
            // 
            // lblNotifyOption
            // 
            resources.ApplyResources(this.lblNotifyOption, "lblNotifyOption");
            this.lblNotifyOption.Cursor = System.Windows.Forms.Cursors.Help;
            this.lblNotifyOption.Name = "lblNotifyOption";
            this.lblNotifyOption.MouseEnter += new System.EventHandler(this.lblNotifyOption_Enter);
            // 
            // cbNotify
            // 
            resources.ApplyResources(this.cbNotify, "cbNotify");
            this.cbNotify.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbNotify.FormattingEnabled = true;
            this.cbNotify.Name = "cbNotify";
            this.cbNotify.SelectedValueChanged += new System.EventHandler(this.cbNotify_SelectedValueChanged);
            // 
            // gbProgramSettings
            // 
            this.gbProgramSettings.Controls.Add(this.cbLang);
            this.gbProgramSettings.Controls.Add(this.lblLangSelect);
            this.gbProgramSettings.Controls.Add(this.nudAutoStartDelay);
            this.gbProgramSettings.Controls.Add(this.lblAutostartDelay);
            this.gbProgramSettings.Controls.Add(this.nudFontSizeTitle);
            this.gbProgramSettings.Controls.Add(this.label1);
            this.gbProgramSettings.Controls.Add(this.cbAutoStart);
            this.gbProgramSettings.Controls.Add(this.nudFontSizeContent);
            this.gbProgramSettings.Controls.Add(this.lblAutostart);
            this.gbProgramSettings.Controls.Add(this.label2);
            this.gbProgramSettings.Controls.Add(this.cbUpdates);
            this.gbProgramSettings.Controls.Add(this.lblUpdateCheck);
            resources.ApplyResources(this.gbProgramSettings, "gbProgramSettings");
            this.gbProgramSettings.Name = "gbProgramSettings";
            this.gbProgramSettings.TabStop = false;
            // 
            // cbLang
            // 
            resources.ApplyResources(this.cbLang, "cbLang");
            this.cbLang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLang.FormattingEnabled = true;
            this.cbLang.Name = "cbLang";
            // 
            // lblLangSelect
            // 
            resources.ApplyResources(this.lblLangSelect, "lblLangSelect");
            this.lblLangSelect.Name = "lblLangSelect";
            // 
            // nudAutoStartDelay
            // 
            resources.ApplyResources(this.nudAutoStartDelay, "nudAutoStartDelay");
            this.nudAutoStartDelay.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.nudAutoStartDelay.Name = "nudAutoStartDelay";
            // 
            // lblAutostartDelay
            // 
            resources.ApplyResources(this.lblAutostartDelay, "lblAutostartDelay");
            this.lblAutostartDelay.Name = "lblAutostartDelay";
            this.lblAutostartDelay.MouseEnter += new System.EventHandler(this.LblAutostartDelay_MouseEnter);
            // 
            // nudFontSizeTitle
            // 
            resources.ApplyResources(this.nudFontSizeTitle, "nudFontSizeTitle");
            this.nudFontSizeTitle.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.nudFontSizeTitle.Minimum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.nudFontSizeTitle.Name = "nudFontSizeTitle";
            this.nudFontSizeTitle.Value = new decimal(new int[] {
            9,
            0,
            0,
            0});
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            this.label1.MouseEnter += new System.EventHandler(this.fontSize_MouseEnter);
            // 
            // cbAutoStart
            // 
            resources.ApplyResources(this.cbAutoStart, "cbAutoStart");
            this.cbAutoStart.Name = "cbAutoStart";
            this.cbAutoStart.UseVisualStyleBackColor = true;
            // 
            // nudFontSizeContent
            // 
            resources.ApplyResources(this.nudFontSizeContent, "nudFontSizeContent");
            this.nudFontSizeContent.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.nudFontSizeContent.Minimum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.nudFontSizeContent.Name = "nudFontSizeContent";
            this.nudFontSizeContent.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            // 
            // lblAutostart
            // 
            resources.ApplyResources(this.lblAutostart, "lblAutostart");
            this.lblAutostart.Cursor = System.Windows.Forms.Cursors.Help;
            this.lblAutostart.Name = "lblAutostart";
            this.lblAutostart.MouseEnter += new System.EventHandler(this.lblAutostart_MouseEnter);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            this.label2.MouseEnter += new System.EventHandler(this.fontSize_MouseEnter);
            // 
            // cbUpdates
            // 
            resources.ApplyResources(this.cbUpdates, "cbUpdates");
            this.cbUpdates.Name = "cbUpdates";
            this.cbUpdates.UseVisualStyleBackColor = true;
            // 
            // lblUpdateCheck
            // 
            resources.ApplyResources(this.lblUpdateCheck, "lblUpdateCheck");
            this.lblUpdateCheck.Cursor = System.Windows.Forms.Cursors.Help;
            this.lblUpdateCheck.Name = "lblUpdateCheck";
            this.lblUpdateCheck.MouseEnter += new System.EventHandler(this.lblUpdateCheck_MouseEnter);
            // 
            // tbMotdUsername
            // 
            resources.ApplyResources(this.tbMotdUsername, "tbMotdUsername");
            this.tbMotdUsername.Name = "tbMotdUsername";
            // 
            // lblMotdUsername
            // 
            resources.ApplyResources(this.lblMotdUsername, "lblMotdUsername");
            this.lblMotdUsername.Cursor = System.Windows.Forms.Cursors.Help;
            this.lblMotdUsername.Name = "lblMotdUsername";
            this.lblMotdUsername.MouseEnter += new System.EventHandler(this.motdUserName);
            // 
            // cbIgnoreOwn
            // 
            resources.ApplyResources(this.cbIgnoreOwn, "cbIgnoreOwn");
            this.cbIgnoreOwn.Name = "cbIgnoreOwn";
            this.cbIgnoreOwn.UseVisualStyleBackColor = true;
            // 
            // lblIgnoreOwn
            // 
            resources.ApplyResources(this.lblIgnoreOwn, "lblIgnoreOwn");
            this.lblIgnoreOwn.Cursor = System.Windows.Forms.Cursors.Help;
            this.lblIgnoreOwn.Name = "lblIgnoreOwn";
            this.lblIgnoreOwn.MouseEnter += new System.EventHandler(this.ignoreOwnMessages);
            // 
            // cbIgnoreMotd
            // 
            resources.ApplyResources(this.cbIgnoreMotd, "cbIgnoreMotd");
            this.cbIgnoreMotd.Name = "cbIgnoreMotd";
            this.cbIgnoreMotd.UseVisualStyleBackColor = true;
            // 
            // lblIgnoreMotd
            // 
            resources.ApplyResources(this.lblIgnoreMotd, "lblIgnoreMotd");
            this.lblIgnoreMotd.Cursor = System.Windows.Forms.Cursors.Help;
            this.lblIgnoreMotd.Name = "lblIgnoreMotd";
            this.lblIgnoreMotd.MouseEnter += new System.EventHandler(this.ignoreMotd_MouseEnter);
            // 
            // gbIgnorelist
            // 
            resources.ApplyResources(this.gbIgnorelist, "gbIgnorelist");
            this.gbIgnorelist.Controls.Add(this.tbIgnoreChannels);
            this.gbIgnorelist.Controls.Add(this.tbIgnorePilots);
            this.gbIgnorelist.Controls.Add(this.lblIgnoreChannels);
            this.gbIgnorelist.Controls.Add(this.lblIgnorePilots);
            this.gbIgnorelist.Name = "gbIgnorelist";
            this.gbIgnorelist.TabStop = false;
            // 
            // tbIgnoreChannels
            // 
            resources.ApplyResources(this.tbIgnoreChannels, "tbIgnoreChannels");
            this.tbIgnoreChannels.Name = "tbIgnoreChannels";
            // 
            // tbIgnorePilots
            // 
            resources.ApplyResources(this.tbIgnorePilots, "tbIgnorePilots");
            this.tbIgnorePilots.Name = "tbIgnorePilots";
            // 
            // lblIgnoreChannels
            // 
            resources.ApplyResources(this.lblIgnoreChannels, "lblIgnoreChannels");
            this.lblIgnoreChannels.Name = "lblIgnoreChannels";
            this.lblIgnoreChannels.MouseEnter += new System.EventHandler(this.lblIgnoreChannels_MouseEnter);
            // 
            // lblIgnorePilots
            // 
            resources.ApplyResources(this.lblIgnorePilots, "lblIgnorePilots");
            this.lblIgnorePilots.Name = "lblIgnorePilots";
            this.lblIgnorePilots.MouseEnter += new System.EventHandler(this.lblIgnorePilots_MouseEnter);
            // 
            // gbWorkTweaks
            // 
            resources.ApplyResources(this.gbWorkTweaks, "gbWorkTweaks");
            this.gbWorkTweaks.Controls.Add(this.tbMotdUsername);
            this.gbWorkTweaks.Controls.Add(this.cbIgnoreMotd);
            this.gbWorkTweaks.Controls.Add(this.lblIgnoreOwn);
            this.gbWorkTweaks.Controls.Add(this.cbIgnoreOwn);
            this.gbWorkTweaks.Controls.Add(this.lblMotdUsername);
            this.gbWorkTweaks.Controls.Add(this.lblIgnoreMotd);
            this.gbWorkTweaks.Name = "gbWorkTweaks";
            this.gbWorkTweaks.TabStop = false;
            // 
            // Settings
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.CancelButton = this.btnCancel;
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.btnTest);
            this.Controls.Add(this.gbWorkTweaks);
            this.Controls.Add(this.gbIgnorelist);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.gbProgramSettings);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.gbNotification);
            this.Controls.Add(this.gbPaths);
            this.Controls.Add(this.pHint);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Settings";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Settings_FormClosing);
            this.Load += new System.EventHandler(this.Settings_Load);
            this.pHint.ResumeLayout(false);
            this.pHint.PerformLayout();
            this.gbPaths.ResumeLayout(false);
            this.gbPaths.PerformLayout();
            this.gbNotification.ResumeLayout(false);
            this.gbNotification.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbarVolume)).EndInit();
            this.gbProgramSettings.ResumeLayout(false);
            this.gbProgramSettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAutoStartDelay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFontSizeTitle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFontSizeContent)).EndInit();
            this.gbIgnorelist.ResumeLayout(false);
            this.gbIgnorelist.PerformLayout();
            this.gbWorkTweaks.ResumeLayout(false);
            this.gbWorkTweaks.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pHint;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.GroupBox gbPaths;
        private System.Windows.Forms.Label lblEveChatLogPath;
        private System.Windows.Forms.Label lblLogPath;
        private System.Windows.Forms.CheckBox cbMoveLog;
        private System.Windows.Forms.Label lblMoveLogs;
        private HelperControls.FolderChooser folderMoveLogs;
        private HelperControls.FileChooser fileLog;
        private HelperControls.FolderChooser folderEveChatLogs;
        private System.Windows.Forms.TextBox tbHelp;
        private System.Windows.Forms.GroupBox gbNotification;
        private System.Windows.Forms.Label lblNotifyOption;
        private System.Windows.Forms.ComboBox cbNotify;
        private System.Windows.Forms.Label lblSoundFile;
        private HelperControls.FileChooser fileNotifySound;
        private System.Windows.Forms.TextBox tbNotifyKeywords;
        private System.Windows.Forms.Label lblNotifyKeywords;
        private System.Windows.Forms.Label lblVolume;
        private System.Windows.Forms.TrackBar tbarVolume;
        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.GroupBox gbProgramSettings;
        private System.Windows.Forms.CheckBox cbUpdates;
        private System.Windows.Forms.Label lblUpdateCheck;
        private System.Windows.Forms.CheckBox cbAutoStart;
        private System.Windows.Forms.Label lblAutostart;
        private System.Windows.Forms.NumericUpDown nudFontSizeTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudFontSizeContent;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox cbIgnoreMotd;
        private System.Windows.Forms.Label lblIgnoreMotd;
        private System.Windows.Forms.CheckBox cbIgnoreOwn;
        private System.Windows.Forms.Label lblIgnoreOwn;
		private System.Windows.Forms.TextBox tbMotdUsername;
		private System.Windows.Forms.Label lblMotdUsername;
		private System.Windows.Forms.GroupBox gbIgnorelist;
		private System.Windows.Forms.TextBox tbIgnoreChannels;
		private System.Windows.Forms.TextBox tbIgnorePilots;
		private System.Windows.Forms.Label lblIgnoreChannels;
		private System.Windows.Forms.Label lblIgnorePilots;
        private System.Windows.Forms.NumericUpDown nudAutoStartDelay;
        private System.Windows.Forms.Label lblAutostartDelay;
        private System.Windows.Forms.Label lblLangSelect;
        private System.Windows.Forms.ComboBox cbLang;
        private System.Windows.Forms.GroupBox gbWorkTweaks;
    }
}