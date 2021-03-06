﻿namespace TEAM
{
    partial class FormMain
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
        /// 
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.labelEnvironmentMode = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelWorkingEnvironment = new System.Windows.Forms.Label();
            this.labelMetadataSave = new System.Windows.Forms.Label();
            this.labelWorkingEnvironmentType = new System.Windows.Forms.Label();
            this.labelMetadataRepository = new System.Windows.Forms.Label();
            this.groupBoxVersionSelection = new System.Windows.Forms.GroupBox();
            this.labelActiveVersionDateTime = new System.Windows.Forms.Label();
            this.labelActivatedMetadataVersionDateTime = new System.Windows.Forms.Label();
            this.labelActiveVersion = new System.Windows.Forms.Label();
            this.labelActivatedMetadataVersin = new System.Windows.Forms.Label();
            this.labelDocumentationVersion = new System.Windows.Forms.Label();
            this.labelVersion = new System.Windows.Forms.Label();
            this.richTextBoxInformation = new System.Windows.Forms.RichTextBox();
            this.menuStripMainMenu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openOutputDirectoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.metadataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openMetadataFormToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configurationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generalSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.patternDefinitionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.deployMetadataExamplesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.displayEventLogToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backgroundWorkerEventLog = new System.ComponentModel.BackgroundWorker();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox2.SuspendLayout();
            this.groupBoxVersionSelection.SuspendLayout();
            this.menuStripMainMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox2.Controls.Add(this.labelEnvironmentMode);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.labelWorkingEnvironment);
            this.groupBox2.Controls.Add(this.labelMetadataSave);
            this.groupBox2.Controls.Add(this.labelWorkingEnvironmentType);
            this.groupBox2.Controls.Add(this.labelMetadataRepository);
            this.groupBox2.Location = new System.Drawing.Point(12, 577);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(342, 102);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Environment";
            // 
            // labelEnvironmentMode
            // 
            this.labelEnvironmentMode.AutoSize = true;
            this.labelEnvironmentMode.Location = new System.Drawing.Point(193, 57);
            this.labelEnvironmentMode.Name = "labelEnvironmentMode";
            this.labelEnvironmentMode.Size = new System.Drawing.Size(27, 13);
            this.labelEnvironmentMode.TabIndex = 69;
            this.labelEnvironmentMode.Text = "N/A";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 13);
            this.label2.TabIndex = 68;
            this.label2.Text = "The environment is configured for:";
            // 
            // labelWorkingEnvironment
            // 
            this.labelWorkingEnvironment.AutoSize = true;
            this.labelWorkingEnvironment.Location = new System.Drawing.Point(193, 40);
            this.labelWorkingEnvironment.Name = "labelWorkingEnvironment";
            this.labelWorkingEnvironment.Size = new System.Drawing.Size(27, 13);
            this.labelWorkingEnvironment.TabIndex = 67;
            this.labelWorkingEnvironment.Text = "N/A";
            // 
            // labelMetadataSave
            // 
            this.labelMetadataSave.AutoSize = true;
            this.labelMetadataSave.Location = new System.Drawing.Point(193, 23);
            this.labelMetadataSave.Name = "labelMetadataSave";
            this.labelMetadataSave.Size = new System.Drawing.Size(27, 13);
            this.labelMetadataSave.TabIndex = 66;
            this.labelMetadataSave.Text = "N/A";
            // 
            // labelWorkingEnvironmentType
            // 
            this.labelWorkingEnvironmentType.AutoSize = true;
            this.labelWorkingEnvironmentType.Location = new System.Drawing.Point(6, 40);
            this.labelWorkingEnvironmentType.Name = "labelWorkingEnvironmentType";
            this.labelWorkingEnvironmentType.Size = new System.Drawing.Size(140, 13);
            this.labelWorkingEnvironmentType.TabIndex = 65;
            this.labelWorkingEnvironmentType.Text = "The working environment is:";
            // 
            // labelMetadataRepository
            // 
            this.labelMetadataRepository.AutoSize = true;
            this.labelMetadataRepository.Location = new System.Drawing.Point(6, 23);
            this.labelMetadataRepository.Name = "labelMetadataRepository";
            this.labelMetadataRepository.Size = new System.Drawing.Size(114, 13);
            this.labelMetadataRepository.TabIndex = 64;
            this.labelMetadataRepository.Text = "Metadata is saved as :";
            // 
            // groupBoxVersionSelection
            // 
            this.groupBoxVersionSelection.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBoxVersionSelection.Controls.Add(this.labelActiveVersionDateTime);
            this.groupBoxVersionSelection.Controls.Add(this.labelActivatedMetadataVersionDateTime);
            this.groupBoxVersionSelection.Controls.Add(this.labelActiveVersion);
            this.groupBoxVersionSelection.Controls.Add(this.labelActivatedMetadataVersin);
            this.groupBoxVersionSelection.Controls.Add(this.labelDocumentationVersion);
            this.groupBoxVersionSelection.Controls.Add(this.labelVersion);
            this.groupBoxVersionSelection.Location = new System.Drawing.Point(12, 685);
            this.groupBoxVersionSelection.Name = "groupBoxVersionSelection";
            this.groupBoxVersionSelection.Size = new System.Drawing.Size(342, 99);
            this.groupBoxVersionSelection.TabIndex = 20;
            this.groupBoxVersionSelection.TabStop = false;
            this.groupBoxVersionSelection.Text = "Version";
            // 
            // labelActiveVersionDateTime
            // 
            this.labelActiveVersionDateTime.AutoSize = true;
            this.labelActiveVersionDateTime.Location = new System.Drawing.Point(192, 59);
            this.labelActiveVersionDateTime.Name = "labelActiveVersionDateTime";
            this.labelActiveVersionDateTime.Size = new System.Drawing.Size(27, 13);
            this.labelActiveVersionDateTime.TabIndex = 23;
            this.labelActiveVersionDateTime.Text = "N/A";
            // 
            // labelActivatedMetadataVersionDateTime
            // 
            this.labelActivatedMetadataVersionDateTime.AutoSize = true;
            this.labelActivatedMetadataVersionDateTime.Location = new System.Drawing.Point(6, 59);
            this.labelActivatedMetadataVersionDateTime.Name = "labelActivatedMetadataVersionDateTime";
            this.labelActivatedMetadataVersionDateTime.Size = new System.Drawing.Size(105, 13);
            this.labelActivatedMetadataVersionDateTime.TabIndex = 22;
            this.labelActivatedMetadataVersionDateTime.Text = "Activation date/time:";
            // 
            // labelActiveVersion
            // 
            this.labelActiveVersion.AutoSize = true;
            this.labelActiveVersion.Location = new System.Drawing.Point(192, 42);
            this.labelActiveVersion.Name = "labelActiveVersion";
            this.labelActiveVersion.Size = new System.Drawing.Size(27, 13);
            this.labelActiveVersion.TabIndex = 21;
            this.labelActiveVersion.Text = "N/A";
            // 
            // labelActivatedMetadataVersin
            // 
            this.labelActivatedMetadataVersin.AutoSize = true;
            this.labelActivatedMetadataVersin.Location = new System.Drawing.Point(6, 42);
            this.labelActivatedMetadataVersin.Name = "labelActivatedMetadataVersin";
            this.labelActivatedMetadataVersin.Size = new System.Drawing.Size(139, 13);
            this.labelActivatedMetadataVersin.TabIndex = 20;
            this.labelActivatedMetadataVersin.Text = "Activated metadata version:";
            // 
            // labelDocumentationVersion
            // 
            this.labelDocumentationVersion.AutoSize = true;
            this.labelDocumentationVersion.Location = new System.Drawing.Point(6, 25);
            this.labelDocumentationVersion.Name = "labelDocumentationVersion";
            this.labelDocumentationVersion.Size = new System.Drawing.Size(150, 13);
            this.labelDocumentationVersion.TabIndex = 19;
            this.labelDocumentationVersion.Text = "Most recent metadata version:";
            // 
            // labelVersion
            // 
            this.labelVersion.AutoSize = true;
            this.labelVersion.Location = new System.Drawing.Point(192, 25);
            this.labelVersion.Name = "labelVersion";
            this.labelVersion.Size = new System.Drawing.Size(27, 13);
            this.labelVersion.TabIndex = 18;
            this.labelVersion.Text = "N/A";
            // 
            // richTextBoxInformation
            // 
            this.richTextBoxInformation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBoxInformation.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBoxInformation.Location = new System.Drawing.Point(14, 59);
            this.richTextBoxInformation.Name = "richTextBoxInformation";
            this.richTextBoxInformation.ReadOnly = true;
            this.richTextBoxInformation.Size = new System.Drawing.Size(1122, 512);
            this.richTextBoxInformation.TabIndex = 2;
            this.richTextBoxInformation.Text = "";
            this.richTextBoxInformation.TextChanged += new System.EventHandler(this.richTextBoxInformation_TextChanged);
            this.richTextBoxInformation.Enter += new System.EventHandler(this.richTextBoxInformation_Enter);
            // 
            // menuStripMainMenu
            // 
            this.menuStripMainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.metadataToolStripMenuItem,
            this.configurationToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStripMainMenu.Location = new System.Drawing.Point(0, 0);
            this.menuStripMainMenu.Name = "menuStripMainMenu";
            this.menuStripMainMenu.Size = new System.Drawing.Size(1148, 24);
            this.menuStripMainMenu.TabIndex = 4;
            this.menuStripMainMenu.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openOutputDirectoryToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // openOutputDirectoryToolStripMenuItem
            // 
            this.openOutputDirectoryToolStripMenuItem.Image = global::TEAM.Properties.Resources.OpenDirectoryIcon;
            this.openOutputDirectoryToolStripMenuItem.Name = "openOutputDirectoryToolStripMenuItem";
            this.openOutputDirectoryToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openOutputDirectoryToolStripMenuItem.Size = new System.Drawing.Size(238, 22);
            this.openOutputDirectoryToolStripMenuItem.Text = "Open Output Directory";
            this.openOutputDirectoryToolStripMenuItem.Click += new System.EventHandler(this.openOutputDirectoryToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Image = global::TEAM.Properties.Resources.ExitApplication;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(238, 22);
            this.exitToolStripMenuItem.Text = "Exit Application";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // metadataToolStripMenuItem
            // 
            this.metadataToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openMetadataFormToolStripMenuItem});
            this.metadataToolStripMenuItem.Name = "metadataToolStripMenuItem";
            this.metadataToolStripMenuItem.Size = new System.Drawing.Size(120, 20);
            this.metadataToolStripMenuItem.Text = "&Metadata Mapping";
            // 
            // openMetadataFormToolStripMenuItem
            // 
            this.openMetadataFormToolStripMenuItem.Image = global::TEAM.Properties.Resources.CubeIcon;
            this.openMetadataFormToolStripMenuItem.Name = "openMetadataFormToolStripMenuItem";
            this.openMetadataFormToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.M)));
            this.openMetadataFormToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.openMetadataFormToolStripMenuItem.Text = "Manage &Metadata";
            this.openMetadataFormToolStripMenuItem.Click += new System.EventHandler(this.openMetadataFormToolStripMenuItem_Click);
            // 
            // configurationToolStripMenuItem
            // 
            this.configurationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.generalSettingsToolStripMenuItem,
            this.patternDefinitionsToolStripMenuItem,
            this.toolStripSeparator2,
            this.deployMetadataExamplesToolStripMenuItem});
            this.configurationToolStripMenuItem.Name = "configurationToolStripMenuItem";
            this.configurationToolStripMenuItem.Size = new System.Drawing.Size(93, 20);
            this.configurationToolStripMenuItem.Text = "&Configuration";
            // 
            // generalSettingsToolStripMenuItem
            // 
            this.generalSettingsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("generalSettingsToolStripMenuItem.Image")));
            this.generalSettingsToolStripMenuItem.Name = "generalSettingsToolStripMenuItem";
            this.generalSettingsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.generalSettingsToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.generalSettingsToolStripMenuItem.Text = "General &Settings";
            this.generalSettingsToolStripMenuItem.Click += new System.EventHandler(this.generalSettingsToolStripMenuItem_Click);
            // 
            // patternDefinitionsToolStripMenuItem
            // 
            this.patternDefinitionsToolStripMenuItem.Image = global::TEAM.Properties.Resources.ETLIcon;
            this.patternDefinitionsToolStripMenuItem.Name = "patternDefinitionsToolStripMenuItem";
            this.patternDefinitionsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.patternDefinitionsToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.patternDefinitionsToolStripMenuItem.Text = "Pattern Definitions";
            this.patternDefinitionsToolStripMenuItem.Click += new System.EventHandler(this.patternDefinitionsToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(210, 6);
            // 
            // deployMetadataExamplesToolStripMenuItem
            // 
            this.deployMetadataExamplesToolStripMenuItem.Image = global::TEAM.Properties.Resources.database_icon;
            this.deployMetadataExamplesToolStripMenuItem.Name = "deployMetadataExamplesToolStripMenuItem";
            this.deployMetadataExamplesToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.deployMetadataExamplesToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.deployMetadataExamplesToolStripMenuItem.Text = "Deploy Examples";
            this.deployMetadataExamplesToolStripMenuItem.Click += new System.EventHandler(this.deployMetadataExamplesToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem1,
            this.displayEventLogToolStripMenuItem,
            this.toolStripSeparator1,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // helpToolStripMenuItem1
            // 
            this.helpToolStripMenuItem1.Image = global::TEAM.Properties.Resources.HelpIconSmall;
            this.helpToolStripMenuItem1.Name = "helpToolStripMenuItem1";
            this.helpToolStripMenuItem1.Size = new System.Drawing.Size(167, 22);
            this.helpToolStripMenuItem1.Text = "Help";
            this.helpToolStripMenuItem1.Click += new System.EventHandler(this.helpToolStripMenuItem1_Click);
            // 
            // displayEventLogToolStripMenuItem
            // 
            this.displayEventLogToolStripMenuItem.Image = global::TEAM.Properties.Resources.log_file;
            this.displayEventLogToolStripMenuItem.Name = "displayEventLogToolStripMenuItem";
            this.displayEventLogToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.displayEventLogToolStripMenuItem.Text = "Display Event Log";
            this.displayEventLogToolStripMenuItem.Click += new System.EventHandler(this.displayEventLogToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(164, 6);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Image = global::TEAM.Properties.Resources.RavosLogo;
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.ToolTipText = "Information about Virtual Enterprise Data Warehouse";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // backgroundWorkerEventLog
            // 
            this.backgroundWorkerEventLog.WorkerReportsProgress = true;
            this.backgroundWorkerEventLog.WorkerSupportsCancellation = true;
            this.backgroundWorkerEventLog.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorkerEventLog_DoWork);
            this.backgroundWorkerEventLog.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorkerEventLog_ProgressChanged);
            this.backgroundWorkerEventLog.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorkerEventLog_RunWorkerCompleted);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::TEAM.Properties.Resources.RavosLogo;
            this.pictureBox1.Location = new System.Drawing.Point(1027, 684);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(109, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1148, 797);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBoxVersionSelection);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.richTextBoxInformation);
            this.Controls.Add(this.menuStripMainMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStripMainMenu;
            this.MinimumSize = new System.Drawing.Size(1164, 835);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TEAM - Taxonomy for ETL Automation Metadata ";
            this.Activated += new System.EventHandler(this.FormMain_Activated);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormMain_FormClosed);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBoxVersionSelection.ResumeLayout(false);
            this.groupBoxVersionSelection.PerformLayout();
            this.menuStripMainMenu.ResumeLayout(false);
            this.menuStripMainMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStripMainMenu;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openOutputDirectoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem metadataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openMetadataFormToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem configurationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generalSettingsToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBoxVersionSelection;
        private System.Windows.Forms.Label labelDocumentationVersion;
        private System.Windows.Forms.Label labelVersion;
        internal System.Windows.Forms.RichTextBox richTextBoxInformation;
        private System.Windows.Forms.Label labelActiveVersion;
        private System.Windows.Forms.Label labelActivatedMetadataVersin;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label labelMetadataRepository;
        private System.Windows.Forms.Label labelWorkingEnvironmentType;
        private System.Windows.Forms.ToolStripMenuItem patternDefinitionsToolStripMenuItem;
        private System.ComponentModel.BackgroundWorker backgroundWorkerEventLog;
        private System.Windows.Forms.Label labelActiveVersionDateTime;
        private System.Windows.Forms.Label labelActivatedMetadataVersionDateTime;
        private System.Windows.Forms.Label labelWorkingEnvironment;
        private System.Windows.Forms.Label labelMetadataSave;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem displayEventLogToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem deployMetadataExamplesToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.Label labelEnvironmentMode;
        private System.Windows.Forms.Label label2;
    }
}

