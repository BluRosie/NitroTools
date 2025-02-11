﻿namespace NitroStudio
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Sound Sequence");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Sequence Archive", 1, 1);
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Instrument Bank", 2, 2);
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Wave Archive", 3, 3);
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Sequence Player", 4, 4);
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Group", 5, 5);
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Stream Player", 6, 6);
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Stream", 7, 7);
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Sequence", 8, 8);
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Sequence Archive", 8, 8);
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("Bank", 8, 8);
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("Wave Archive", 8, 8);
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("Stream", 8, 8);
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("FILES", 8, 8, new System.Windows.Forms.TreeNode[] {
            treeNode9,
            treeNode10,
            treeNode11,
            treeNode12,
            treeNode13});
            this.bigFolderMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newBetaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bankGeneratorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.convertToSDKProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewHelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutNitroComposerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.progressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.status = new System.Windows.Forms.ToolStripStatusLabel();
            this.byteSelect = new System.Windows.Forms.ToolStripStatusLabel();
            this.nodeSelected = new System.Windows.Forms.ToolStripStatusLabel();
            this.parentNodeSelected = new System.Windows.Forms.ToolStripStatusLabel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.strmGroup = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.playerBoxMagic = new System.Windows.Forms.NumericUpDown();
            this.playerLabelFrog = new System.Windows.Forms.Label();
            this.priorityBoxBlack = new System.Windows.Forms.NumericUpDown();
            this.volumeBoxMushrooms = new System.Windows.Forms.NumericUpDown();
            this.priorityLabelPig = new System.Windows.Forms.Label();
            this.volumeLabelFuckRocks = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.monoToStereoBox = new System.Windows.Forms.CheckBox();
            this.swarPanel = new System.Windows.Forms.Panel();
            this.loadIndividuallyBox = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupSubPanel = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.ssarBoxLoad = new System.Windows.Forms.CheckBox();
            this.sseqBoxLoad = new System.Windows.Forms.CheckBox();
            this.sbnkBoxLoad = new System.Windows.Forms.CheckBox();
            this.swarBoxLoad = new System.Windows.Forms.CheckBox();
            this.loadFlagGroupLabel = new System.Windows.Forms.Label();
            this.nEntryBox = new System.Windows.Forms.ComboBox();
            this.nEntryLabel = new System.Windows.Forms.Label();
            this.typeGroupLabel = new System.Windows.Forms.Label();
            this.typeGroupBox = new System.Windows.Forms.ComboBox();
            this.player2Group = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.channel1 = new System.Windows.Forms.Label();
            this.channel0Box = new System.Windows.Forms.NumericUpDown();
            this.channel1Box = new System.Windows.Forms.NumericUpDown();
            this.channel0 = new System.Windows.Forms.Label();
            this.typeBox = new System.Windows.Forms.ComboBox();
            this.placeHolderLayout = new System.Windows.Forms.TableLayoutPanel();
            this.placeholderBox = new System.Windows.Forms.CheckBox();
            this.togglePlaceholderButton = new System.Windows.Forms.Button();
            this.sseqGroup = new System.Windows.Forms.Panel();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.gericomLabel = new System.Windows.Forms.Label();
            this.gericomPlay = new System.Windows.Forms.Button();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.gericomPause = new System.Windows.Forms.Button();
            this.gericomStop = new System.Windows.Forms.Button();
            this.playerNumberSseqLabel = new System.Windows.Forms.Label();
            this.playerPrioritySseqLabel = new System.Windows.Forms.Label();
            this.channelPrioritySseqLabel = new System.Windows.Forms.Label();
            this.volumeSseqLabel = new System.Windows.Forms.Label();
            this.playerNumberSseqBox = new System.Windows.Forms.NumericUpDown();
            this.playerPrioritySseqBox = new System.Windows.Forms.NumericUpDown();
            this.channelPrioritySseqBox = new System.Windows.Forms.NumericUpDown();
            this.volumeSseqBox = new System.Windows.Forms.NumericUpDown();
            this.bankIDbox = new System.Windows.Forms.ComboBox();
            this.bankIdLabel = new System.Windows.Forms.Label();
            this.fileIdBox = new System.Windows.Forms.ComboBox();
            this.fileIdLabel = new System.Windows.Forms.Label();
            this.bankGroup = new System.Windows.Forms.Panel();
            this.wave3Box = new System.Windows.Forms.ComboBox();
            this.wave2Box = new System.Windows.Forms.ComboBox();
            this.wave1Box = new System.Windows.Forms.ComboBox();
            this.wave0Box = new System.Windows.Forms.ComboBox();
            this.wave3Label = new System.Windows.Forms.Label();
            this.wave2Label = new System.Windows.Forms.Label();
            this.wave1Label = new System.Windows.Forms.Label();
            this.wave0Label = new System.Windows.Forms.Label();
            this.noSelectLabel = new System.Windows.Forms.Label();
            this.playerGroup = new System.Windows.Forms.Panel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.alloc11 = new System.Windows.Forms.CheckBox();
            this.alloc10 = new System.Windows.Forms.CheckBox();
            this.alloc9 = new System.Windows.Forms.CheckBox();
            this.alloc14 = new System.Windows.Forms.CheckBox();
            this.alloc13 = new System.Windows.Forms.CheckBox();
            this.alloc15 = new System.Windows.Forms.CheckBox();
            this.alloc12 = new System.Windows.Forms.CheckBox();
            this.alloc8 = new System.Windows.Forms.CheckBox();
            this.alloc7 = new System.Windows.Forms.CheckBox();
            this.alloc6 = new System.Windows.Forms.CheckBox();
            this.alloc5 = new System.Windows.Forms.CheckBox();
            this.alloc4 = new System.Windows.Forms.CheckBox();
            this.alloc3 = new System.Windows.Forms.CheckBox();
            this.alloc2 = new System.Windows.Forms.CheckBox();
            this.alloc1 = new System.Windows.Forms.CheckBox();
            this.alloc0 = new System.Windows.Forms.CheckBox();
            this.sequenceMaxLabel = new System.Windows.Forms.Label();
            this.heapSizeBox = new System.Windows.Forms.NumericUpDown();
            this.heapSizeLabel = new System.Windows.Forms.Label();
            this.channelFlagLabel = new System.Windows.Forms.Label();
            this.sequenceMaxBox = new System.Windows.Forms.NumericUpDown();
            this.tree = new System.Windows.Forms.TreeView();
            this.nodeImages = new System.Windows.Forms.ImageList(this.components);
            this.filesMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addAbove = new System.Windows.Forms.ToolStripMenuItem();
            this.addBelow = new System.Windows.Forms.ToolStripMenuItem();
            this.Export = new System.Windows.Forms.ToolStripMenuItem();
            this.Replace = new System.Windows.Forms.ToolStripMenuItem();
            this.Delete = new System.Windows.Forms.ToolStripMenuItem();
            this.foldersMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.Add2 = new System.Windows.Forms.ToolStripMenuItem();
            this.openTree2 = new System.Windows.Forms.ToolStripMenuItem();
            this.closeTree2 = new System.Windows.Forms.ToolStripMenuItem();
            this.nodeMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.Add3 = new System.Windows.Forms.ToolStripMenuItem();
            this.Add32 = new System.Windows.Forms.ToolStripMenuItem();
            this.addInside = new System.Windows.Forms.ToolStripMenuItem();
            this.openTree3 = new System.Windows.Forms.ToolStripMenuItem();
            this.closeTree3 = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.replaceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rename3 = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteMeh = new System.Windows.Forms.ToolStripMenuItem();
            this.entryMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.Rename4 = new System.Windows.Forms.ToolStripMenuItem();
            this.Delete4 = new System.Windows.Forms.ToolStripMenuItem();
            this.bigNodeMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem7 = new System.Windows.Forms.ToolStripMenuItem();
            this.subNodeMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem11 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem12 = new System.Windows.Forms.ToolStripMenuItem();
            this.bigFolderMenu.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.strmGroup.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.playerBoxMagic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.priorityBoxBlack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.volumeBoxMushrooms)).BeginInit();
            this.swarPanel.SuspendLayout();
            this.groupSubPanel.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.player2Group.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.channel0Box)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.channel1Box)).BeginInit();
            this.placeHolderLayout.SuspendLayout();
            this.sseqGroup.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.playerNumberSseqBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerPrioritySseqBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.channelPrioritySseqBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.volumeSseqBox)).BeginInit();
            this.bankGroup.SuspendLayout();
            this.playerGroup.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.heapSizeBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sequenceMaxBox)).BeginInit();
            this.filesMenu.SuspendLayout();
            this.foldersMenu.SuspendLayout();
            this.nodeMenu.SuspendLayout();
            this.entryMenu.SuspendLayout();
            this.bigNodeMenu.SuspendLayout();
            this.subNodeMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // bigFolderMenu
            // 
            this.bigFolderMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.toolStripMenuItem3});
            this.bigFolderMenu.Name = "filesMenu";
            this.bigFolderMenu.Size = new System.Drawing.Size(120, 48);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem2.Image")));
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(119, 22);
            this.toolStripMenuItem2.Text = "Expand";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem3.Image")));
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(119, 22);
            this.toolStripMenuItem3.Text = "Collapse";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.MenuBar;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(825, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newBetaToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.closeToolStripMenuItem,
            this.quitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newBetaToolStripMenuItem
            // 
            this.newBetaToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("newBetaToolStripMenuItem.Image")));
            this.newBetaToolStripMenuItem.Name = "newBetaToolStripMenuItem";
            this.newBetaToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newBetaToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.newBetaToolStripMenuItem.Text = "New";
            this.newBetaToolStripMenuItem.Click += new System.EventHandler(this.newBetaToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripMenuItem.Image")));
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripMenuItem.Image")));
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("saveAsToolStripMenuItem.Image")));
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.saveAsToolStripMenuItem.Text = "Save As";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("closeToolStripMenuItem.Image")));
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.C)));
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.closeToolStripMenuItem.Text = "Close File";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("quitToolStripMenuItem.Image")));
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.Q)));
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.quitToolStripMenuItem.Text = "Quit";
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.quitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportToolStripMenuItem,
            this.importToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("exportToolStripMenuItem.Image")));
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            this.exportToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.exportToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.exportToolStripMenuItem.Text = "Export To Folder";
            this.exportToolStripMenuItem.Click += new System.EventHandler(this.exportToolStripMenuItem_Click);
            // 
            // importToolStripMenuItem
            // 
            this.importToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("importToolStripMenuItem.Image")));
            this.importToolStripMenuItem.Name = "importToolStripMenuItem";
            this.importToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.I)));
            this.importToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.importToolStripMenuItem.Text = "Import From Folder";
            this.importToolStripMenuItem.Click += new System.EventHandler(this.importToolStripMenuItem_Click);
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bankGeneratorToolStripMenuItem,
            this.convertToSDKProjectToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.toolsToolStripMenuItem.Text = "Tools";
            // 
            // bankGeneratorToolStripMenuItem
            // 
            this.bankGeneratorToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("bankGeneratorToolStripMenuItem.Image")));
            this.bankGeneratorToolStripMenuItem.Name = "bankGeneratorToolStripMenuItem";
            this.bankGeneratorToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.bankGeneratorToolStripMenuItem.Text = "Bank Generator";
            this.bankGeneratorToolStripMenuItem.Click += new System.EventHandler(this.bankGeneratorToolStripMenuItem_Click);
            // 
            // convertToSDKProjectToolStripMenuItem
            // 
            this.convertToSDKProjectToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("convertToSDKProjectToolStripMenuItem.Image")));
            this.convertToSDKProjectToolStripMenuItem.Name = "convertToSDKProjectToolStripMenuItem";
            this.convertToSDKProjectToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.convertToSDKProjectToolStripMenuItem.Text = "Convert To SDK Project";
            this.convertToSDKProjectToolStripMenuItem.Click += new System.EventHandler(this.convertToSDKProjectToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewHelpToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.H)));
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // viewHelpToolStripMenuItem
            // 
            this.viewHelpToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("viewHelpToolStripMenuItem.Image")));
            this.viewHelpToolStripMenuItem.Name = "viewHelpToolStripMenuItem";
            this.viewHelpToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.viewHelpToolStripMenuItem.Text = "View Help";
            this.viewHelpToolStripMenuItem.Click += new System.EventHandler(this.viewHelpToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutNitroComposerToolStripMenuItem});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // aboutNitroComposerToolStripMenuItem
            // 
            this.aboutNitroComposerToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("aboutNitroComposerToolStripMenuItem.Image")));
            this.aboutNitroComposerToolStripMenuItem.Name = "aboutNitroComposerToolStripMenuItem";
            this.aboutNitroComposerToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.aboutNitroComposerToolStripMenuItem.Text = "About Nitro Studio";
            this.aboutNitroComposerToolStripMenuItem.Click += new System.EventHandler(this.aboutNitroComposerToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.progressBar,
            this.status,
            this.byteSelect,
            this.nodeSelected,
            this.parentNodeSelected});
            this.statusStrip1.Location = new System.Drawing.Point(0, 472);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(825, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "status1";
            // 
            // progressBar
            // 
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(100, 16);
            // 
            // status
            // 
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(41, 17);
            this.status.Text = "status!";
            this.status.Click += new System.EventHandler(this.toolStripStatusLabel1_Click);
            // 
            // byteSelect
            // 
            this.byteSelect.Name = "byteSelect";
            this.byteSelect.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.byteSelect.Size = new System.Drawing.Size(103, 17);
            this.byteSelect.Text = "No bytes selected!";
            this.byteSelect.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // nodeSelected
            // 
            this.nodeSelected.Name = "nodeSelected";
            this.nodeSelected.Size = new System.Drawing.Size(102, 17);
            this.nodeSelected.Text = "No node selected!";
            // 
            // parentNodeSelected
            // 
            this.parentNodeSelected.Name = "parentNodeSelected";
            this.parentNodeSelected.Size = new System.Drawing.Size(118, 17);
            this.parentNodeSelected.Text = "Node\'s parent is null!";
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 24);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.strmGroup);
            this.splitContainer1.Panel1.Controls.Add(this.swarPanel);
            this.splitContainer1.Panel1.Controls.Add(this.groupSubPanel);
            this.splitContainer1.Panel1.Controls.Add(this.player2Group);
            this.splitContainer1.Panel1.Controls.Add(this.placeHolderLayout);
            this.splitContainer1.Panel1.Controls.Add(this.sseqGroup);
            this.splitContainer1.Panel1.Controls.Add(this.fileIdBox);
            this.splitContainer1.Panel1.Controls.Add(this.fileIdLabel);
            this.splitContainer1.Panel1.Controls.Add(this.bankGroup);
            this.splitContainer1.Panel1.Controls.Add(this.noSelectLabel);
            this.splitContainer1.Panel1.Controls.Add(this.playerGroup);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tree);
            this.splitContainer1.Size = new System.Drawing.Size(825, 448);
            this.splitContainer1.SplitterDistance = 236;
            this.splitContainer1.SplitterWidth = 2;
            this.splitContainer1.TabIndex = 2;
            // 
            // strmGroup
            // 
            this.strmGroup.Controls.Add(this.tableLayoutPanel1);
            this.strmGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.strmGroup.Location = new System.Drawing.Point(0, 23);
            this.strmGroup.Name = "strmGroup";
            this.strmGroup.Size = new System.Drawing.Size(234, 396);
            this.strmGroup.TabIndex = 15;
            this.strmGroup.Visible = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.playerBoxMagic, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.playerLabelFrog, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.priorityBoxBlack, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.volumeBoxMushrooms, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.priorityLabelPig, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.volumeLabelFuckRocks, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.monoToStereoBox, 0, 9);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 10;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(234, 396);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // playerBoxMagic
            // 
            this.playerBoxMagic.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.playerBoxMagic.Location = new System.Drawing.Point(3, 168);
            this.playerBoxMagic.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.playerBoxMagic.Name = "playerBoxMagic";
            this.playerBoxMagic.Size = new System.Drawing.Size(228, 20);
            this.playerBoxMagic.TabIndex = 5;
            // 
            // playerLabelFrog
            // 
            this.playerLabelFrog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.playerLabelFrog.Location = new System.Drawing.Point(3, 140);
            this.playerLabelFrog.Name = "playerLabelFrog";
            this.playerLabelFrog.Size = new System.Drawing.Size(228, 25);
            this.playerLabelFrog.TabIndex = 4;
            this.playerLabelFrog.Text = "Player:";
            this.playerLabelFrog.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // priorityBoxBlack
            // 
            this.priorityBoxBlack.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.priorityBoxBlack.Location = new System.Drawing.Point(3, 118);
            this.priorityBoxBlack.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.priorityBoxBlack.Name = "priorityBoxBlack";
            this.priorityBoxBlack.Size = new System.Drawing.Size(228, 20);
            this.priorityBoxBlack.TabIndex = 3;
            // 
            // volumeBoxMushrooms
            // 
            this.volumeBoxMushrooms.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.volumeBoxMushrooms.Location = new System.Drawing.Point(3, 68);
            this.volumeBoxMushrooms.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.volumeBoxMushrooms.Name = "volumeBoxMushrooms";
            this.volumeBoxMushrooms.Size = new System.Drawing.Size(228, 20);
            this.volumeBoxMushrooms.TabIndex = 1;
            // 
            // priorityLabelPig
            // 
            this.priorityLabelPig.AutoSize = true;
            this.priorityLabelPig.Dock = System.Windows.Forms.DockStyle.Fill;
            this.priorityLabelPig.Location = new System.Drawing.Point(3, 90);
            this.priorityLabelPig.Name = "priorityLabelPig";
            this.priorityLabelPig.Size = new System.Drawing.Size(228, 25);
            this.priorityLabelPig.TabIndex = 2;
            this.priorityLabelPig.Text = "Priority:";
            this.priorityLabelPig.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.priorityLabelPig.Click += new System.EventHandler(this.priorityLabelPig_Click);
            // 
            // volumeLabelFuckRocks
            // 
            this.volumeLabelFuckRocks.AutoSize = true;
            this.volumeLabelFuckRocks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.volumeLabelFuckRocks.Location = new System.Drawing.Point(3, 40);
            this.volumeLabelFuckRocks.Name = "volumeLabelFuckRocks";
            this.volumeLabelFuckRocks.Size = new System.Drawing.Size(228, 25);
            this.volumeLabelFuckRocks.TabIndex = 0;
            this.volumeLabelFuckRocks.Text = "Volume:";
            this.volumeLabelFuckRocks.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.Location = new System.Drawing.Point(3, 190);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(228, 23);
            this.label2.TabIndex = 6;
            this.label2.Text = "Mono To Stereo:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // monoToStereoBox
            // 
            this.monoToStereoBox.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.monoToStereoBox.Location = new System.Drawing.Point(3, 218);
            this.monoToStereoBox.Name = "monoToStereoBox";
            this.monoToStereoBox.Size = new System.Drawing.Size(228, 17);
            this.monoToStereoBox.TabIndex = 7;
            this.monoToStereoBox.UseVisualStyleBackColor = true;
            this.monoToStereoBox.CheckedChanged += new System.EventHandler(this.monoToStereoBox_CheckedChanged);
            // 
            // swarPanel
            // 
            this.swarPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.swarPanel.Controls.Add(this.loadIndividuallyBox);
            this.swarPanel.Controls.Add(this.label3);
            this.swarPanel.Location = new System.Drawing.Point(-1, 49);
            this.swarPanel.Name = "swarPanel";
            this.swarPanel.Size = new System.Drawing.Size(236, 357);
            this.swarPanel.TabIndex = 18;
            this.swarPanel.Visible = false;
            // 
            // loadIndividuallyBox
            // 
            this.loadIndividuallyBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.loadIndividuallyBox.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.loadIndividuallyBox.Location = new System.Drawing.Point(1, 20);
            this.loadIndividuallyBox.Name = "loadIndividuallyBox";
            this.loadIndividuallyBox.Size = new System.Drawing.Size(234, 24);
            this.loadIndividuallyBox.TabIndex = 1;
            this.loadIndividuallyBox.UseVisualStyleBackColor = true;
            this.loadIndividuallyBox.CheckedChanged += new System.EventHandler(this.loadIndividuallyBox_CheckedChanged);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.Location = new System.Drawing.Point(1, 1);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(233, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Load Individually:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // groupSubPanel
            // 
            this.groupSubPanel.Controls.Add(this.tableLayoutPanel2);
            this.groupSubPanel.Controls.Add(this.loadFlagGroupLabel);
            this.groupSubPanel.Controls.Add(this.nEntryBox);
            this.groupSubPanel.Controls.Add(this.nEntryLabel);
            this.groupSubPanel.Controls.Add(this.typeGroupLabel);
            this.groupSubPanel.Controls.Add(this.typeGroupBox);
            this.groupSubPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupSubPanel.Location = new System.Drawing.Point(0, 23);
            this.groupSubPanel.Name = "groupSubPanel";
            this.groupSubPanel.Size = new System.Drawing.Size(234, 396);
            this.groupSubPanel.TabIndex = 12;
            this.groupSubPanel.Visible = false;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.ssarBoxLoad, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.sseqBoxLoad, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.sbnkBoxLoad, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.swarBoxLoad, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(4, 121);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(226, 47);
            this.tableLayoutPanel2.TabIndex = 7;
            // 
            // ssarBoxLoad
            // 
            this.ssarBoxLoad.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ssarBoxLoad.Location = new System.Drawing.Point(116, 26);
            this.ssarBoxLoad.Name = "ssarBoxLoad";
            this.ssarBoxLoad.Size = new System.Drawing.Size(107, 18);
            this.ssarBoxLoad.TabIndex = 9;
            this.ssarBoxLoad.Text = "Load SSAR";
            this.ssarBoxLoad.UseVisualStyleBackColor = true;
            this.ssarBoxLoad.CheckedChanged += new System.EventHandler(this.ssarBoxLoad_CheckedChanged);
            // 
            // sseqBoxLoad
            // 
            this.sseqBoxLoad.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.sseqBoxLoad.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sseqBoxLoad.Location = new System.Drawing.Point(3, 26);
            this.sseqBoxLoad.Name = "sseqBoxLoad";
            this.sseqBoxLoad.Size = new System.Drawing.Size(107, 18);
            this.sseqBoxLoad.TabIndex = 8;
            this.sseqBoxLoad.Text = "Load SSEQ";
            this.sseqBoxLoad.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.sseqBoxLoad.UseVisualStyleBackColor = true;
            this.sseqBoxLoad.CheckedChanged += new System.EventHandler(this.sseqBoxLoad_CheckedChanged);
            // 
            // sbnkBoxLoad
            // 
            this.sbnkBoxLoad.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sbnkBoxLoad.Location = new System.Drawing.Point(116, 3);
            this.sbnkBoxLoad.Name = "sbnkBoxLoad";
            this.sbnkBoxLoad.Size = new System.Drawing.Size(107, 17);
            this.sbnkBoxLoad.TabIndex = 7;
            this.sbnkBoxLoad.Text = "Load SBNK";
            this.sbnkBoxLoad.UseVisualStyleBackColor = true;
            this.sbnkBoxLoad.CheckedChanged += new System.EventHandler(this.sbnkBoxLoad_CheckedChanged);
            // 
            // swarBoxLoad
            // 
            this.swarBoxLoad.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.swarBoxLoad.Dock = System.Windows.Forms.DockStyle.Fill;
            this.swarBoxLoad.Location = new System.Drawing.Point(3, 3);
            this.swarBoxLoad.Name = "swarBoxLoad";
            this.swarBoxLoad.Size = new System.Drawing.Size(107, 17);
            this.swarBoxLoad.TabIndex = 6;
            this.swarBoxLoad.Text = "Load SWARs";
            this.swarBoxLoad.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.swarBoxLoad.UseVisualStyleBackColor = true;
            this.swarBoxLoad.CheckedChanged += new System.EventHandler(this.swarBoxLoad_CheckedChanged);
            // 
            // loadFlagGroupLabel
            // 
            this.loadFlagGroupLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.loadFlagGroupLabel.Location = new System.Drawing.Point(1, 100);
            this.loadFlagGroupLabel.Name = "loadFlagGroupLabel";
            this.loadFlagGroupLabel.Size = new System.Drawing.Size(232, 23);
            this.loadFlagGroupLabel.TabIndex = 4;
            this.loadFlagGroupLabel.Text = "Load Flags:";
            this.loadFlagGroupLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nEntryBox
            // 
            this.nEntryBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nEntryBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.nEntryBox.FormattingEnabled = true;
            this.nEntryBox.Items.AddRange(new object[] {
            "0 - SSEQ",
            "1 - SBNK",
            "2 - SWAR",
            "3 - SSAR",
            "WTF - Other"});
            this.nEntryBox.Location = new System.Drawing.Point(5, 76);
            this.nEntryBox.Name = "nEntryBox";
            this.nEntryBox.Size = new System.Drawing.Size(226, 21);
            this.nEntryBox.TabIndex = 3;
            this.nEntryBox.SelectedIndexChanged += new System.EventHandler(this.onNEntryChanged);
            // 
            // nEntryLabel
            // 
            this.nEntryLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nEntryLabel.Location = new System.Drawing.Point(1, 50);
            this.nEntryLabel.Name = "nEntryLabel";
            this.nEntryLabel.Size = new System.Drawing.Size(232, 23);
            this.nEntryLabel.TabIndex = 2;
            this.nEntryLabel.Text = "Entry Number:";
            this.nEntryLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // typeGroupLabel
            // 
            this.typeGroupLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.typeGroupLabel.Location = new System.Drawing.Point(1, 0);
            this.typeGroupLabel.Name = "typeGroupLabel";
            this.typeGroupLabel.Size = new System.Drawing.Size(232, 23);
            this.typeGroupLabel.TabIndex = 1;
            this.typeGroupLabel.Text = "Type:";
            this.typeGroupLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // typeGroupBox
            // 
            this.typeGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.typeGroupBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.typeGroupBox.FormattingEnabled = true;
            this.typeGroupBox.Items.AddRange(new object[] {
            "0 - SSEQ",
            "1 - SBNK",
            "2 - SWAR",
            "3 - SSAR",
            "WTF - Other"});
            this.typeGroupBox.Location = new System.Drawing.Point(4, 26);
            this.typeGroupBox.Name = "typeGroupBox";
            this.typeGroupBox.Size = new System.Drawing.Size(226, 21);
            this.typeGroupBox.TabIndex = 0;
            this.typeGroupBox.SelectedIndexChanged += new System.EventHandler(this.onTypeChanged);
            // 
            // player2Group
            // 
            this.player2Group.Controls.Add(this.label1);
            this.player2Group.Controls.Add(this.tableLayoutPanel3);
            this.player2Group.Controls.Add(this.typeBox);
            this.player2Group.Dock = System.Windows.Forms.DockStyle.Fill;
            this.player2Group.Location = new System.Drawing.Point(0, 23);
            this.player2Group.Name = "player2Group";
            this.player2Group.Size = new System.Drawing.Size(234, 396);
            this.player2Group.TabIndex = 14;
            this.player2Group.Visible = false;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Location = new System.Drawing.Point(0, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(235, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Type:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.channel1, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.channel0Box, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.channel1Box, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.channel0, 0, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(1, 50);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(230, 45);
            this.tableLayoutPanel3.TabIndex = 17;
            // 
            // channel1
            // 
            this.channel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.channel1.Location = new System.Drawing.Point(118, 0);
            this.channel1.Name = "channel1";
            this.channel1.Size = new System.Drawing.Size(109, 19);
            this.channel1.TabIndex = 16;
            this.channel1.Text = "Right:";
            this.channel1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // channel0Box
            // 
            this.channel0Box.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.channel0Box.Location = new System.Drawing.Point(3, 25);
            this.channel0Box.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.channel0Box.Name = "channel0Box";
            this.channel0Box.Size = new System.Drawing.Size(109, 20);
            this.channel0Box.TabIndex = 12;
            this.channel0Box.ValueChanged += new System.EventHandler(this.v15_ValueChanged);
            // 
            // channel1Box
            // 
            this.channel1Box.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.channel1Box.Location = new System.Drawing.Point(118, 25);
            this.channel1Box.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.channel1Box.Name = "channel1Box";
            this.channel1Box.Size = new System.Drawing.Size(109, 20);
            this.channel1Box.TabIndex = 15;
            this.channel1Box.ValueChanged += new System.EventHandler(this.count_ValueChanged);
            // 
            // channel0
            // 
            this.channel0.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.channel0.Location = new System.Drawing.Point(3, 0);
            this.channel0.Name = "channel0";
            this.channel0.Size = new System.Drawing.Size(109, 19);
            this.channel0.TabIndex = 14;
            this.channel0.Text = "Left:";
            this.channel0.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // typeBox
            // 
            this.typeBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.typeBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.typeBox.FormattingEnabled = true;
            this.typeBox.Items.AddRange(new object[] {
            "Mono",
            "Stereo"});
            this.typeBox.Location = new System.Drawing.Point(5, 26);
            this.typeBox.Name = "typeBox";
            this.typeBox.Size = new System.Drawing.Size(224, 21);
            this.typeBox.TabIndex = 16;
            this.typeBox.SelectedIndexChanged += new System.EventHandler(this.typeBox_SelectedIndexChanged);
            // 
            // placeHolderLayout
            // 
            this.placeHolderLayout.ColumnCount = 2;
            this.placeHolderLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.placeHolderLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.placeHolderLayout.Controls.Add(this.placeholderBox, 1, 0);
            this.placeHolderLayout.Controls.Add(this.togglePlaceholderButton, 0, 0);
            this.placeHolderLayout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.placeHolderLayout.Location = new System.Drawing.Point(0, 419);
            this.placeHolderLayout.Name = "placeHolderLayout";
            this.placeHolderLayout.RowCount = 1;
            this.placeHolderLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.placeHolderLayout.Size = new System.Drawing.Size(234, 27);
            this.placeHolderLayout.TabIndex = 17;
            this.placeHolderLayout.Visible = false;
            // 
            // placeholderBox
            // 
            this.placeholderBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.placeholderBox.Enabled = false;
            this.placeholderBox.Location = new System.Drawing.Point(120, 3);
            this.placeholderBox.Name = "placeholderBox";
            this.placeholderBox.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.placeholderBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.placeholderBox.Size = new System.Drawing.Size(108, 18);
            this.placeholderBox.TabIndex = 3;
            this.placeholderBox.Text = "Placeholder:";
            this.placeholderBox.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.placeholderBox.UseVisualStyleBackColor = true;
            // 
            // togglePlaceholderButton
            // 
            this.togglePlaceholderButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.togglePlaceholderButton.Location = new System.Drawing.Point(3, 3);
            this.togglePlaceholderButton.Name = "togglePlaceholderButton";
            this.togglePlaceholderButton.Size = new System.Drawing.Size(111, 21);
            this.togglePlaceholderButton.TabIndex = 4;
            this.togglePlaceholderButton.Text = "Toggle Placeholder";
            this.togglePlaceholderButton.UseVisualStyleBackColor = true;
            this.togglePlaceholderButton.Click += new System.EventHandler(this.togglePlaceholderButton_Click);
            // 
            // sseqGroup
            // 
            this.sseqGroup.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sseqGroup.Controls.Add(this.tableLayoutPanel6);
            this.sseqGroup.Controls.Add(this.tableLayoutPanel5);
            this.sseqGroup.Controls.Add(this.playerNumberSseqLabel);
            this.sseqGroup.Controls.Add(this.playerPrioritySseqLabel);
            this.sseqGroup.Controls.Add(this.channelPrioritySseqLabel);
            this.sseqGroup.Controls.Add(this.volumeSseqLabel);
            this.sseqGroup.Controls.Add(this.playerNumberSseqBox);
            this.sseqGroup.Controls.Add(this.playerPrioritySseqBox);
            this.sseqGroup.Controls.Add(this.channelPrioritySseqBox);
            this.sseqGroup.Controls.Add(this.volumeSseqBox);
            this.sseqGroup.Controls.Add(this.bankIDbox);
            this.sseqGroup.Controls.Add(this.bankIdLabel);
            this.sseqGroup.Location = new System.Drawing.Point(0, 53);
            this.sseqGroup.Name = "sseqGroup";
            this.sseqGroup.Size = new System.Drawing.Size(234, 363);
            this.sseqGroup.TabIndex = 8;
            this.sseqGroup.Visible = false;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 1;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Controls.Add(this.gericomLabel, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.gericomPlay, 0, 1);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(0, 280);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 2;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(234, 54);
            this.tableLayoutPanel6.TabIndex = 15;
            // 
            // gericomLabel
            // 
            this.gericomLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gericomLabel.Location = new System.Drawing.Point(3, 0);
            this.gericomLabel.Name = "gericomLabel";
            this.gericomLabel.Size = new System.Drawing.Size(228, 27);
            this.gericomLabel.TabIndex = 12;
            this.gericomLabel.Text = "Gericom Player:";
            this.gericomLabel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // gericomPlay
            // 
            this.gericomPlay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gericomPlay.Location = new System.Drawing.Point(3, 30);
            this.gericomPlay.Name = "gericomPlay";
            this.gericomPlay.Size = new System.Drawing.Size(228, 21);
            this.gericomPlay.TabIndex = 11;
            this.gericomPlay.Text = "Play";
            this.gericomPlay.UseVisualStyleBackColor = true;
            this.gericomPlay.Click += new System.EventHandler(this.gericomPlay_Click);
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Controls.Add(this.gericomPause, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.gericomStop, 1, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(0, 334);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(234, 29);
            this.tableLayoutPanel5.TabIndex = 14;
            // 
            // gericomPause
            // 
            this.gericomPause.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gericomPause.Location = new System.Drawing.Point(3, 3);
            this.gericomPause.Name = "gericomPause";
            this.gericomPause.Size = new System.Drawing.Size(111, 23);
            this.gericomPause.TabIndex = 13;
            this.gericomPause.Text = "Pause";
            this.gericomPause.UseVisualStyleBackColor = true;
            this.gericomPause.Click += new System.EventHandler(this.gericomPause_Click);
            // 
            // gericomStop
            // 
            this.gericomStop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gericomStop.Location = new System.Drawing.Point(120, 3);
            this.gericomStop.Name = "gericomStop";
            this.gericomStop.Size = new System.Drawing.Size(111, 23);
            this.gericomStop.TabIndex = 10;
            this.gericomStop.Text = "Stop";
            this.gericomStop.UseVisualStyleBackColor = true;
            this.gericomStop.Click += new System.EventHandler(this.gericomStop_Click);
            // 
            // playerNumberSseqLabel
            // 
            this.playerNumberSseqLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.playerNumberSseqLabel.Location = new System.Drawing.Point(4, 196);
            this.playerNumberSseqLabel.Name = "playerNumberSseqLabel";
            this.playerNumberSseqLabel.Size = new System.Drawing.Size(227, 23);
            this.playerNumberSseqLabel.TabIndex = 9;
            this.playerNumberSseqLabel.Text = "Player Number:";
            this.playerNumberSseqLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // playerPrioritySseqLabel
            // 
            this.playerPrioritySseqLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.playerPrioritySseqLabel.Location = new System.Drawing.Point(3, 147);
            this.playerPrioritySseqLabel.Name = "playerPrioritySseqLabel";
            this.playerPrioritySseqLabel.Size = new System.Drawing.Size(228, 23);
            this.playerPrioritySseqLabel.TabIndex = 8;
            this.playerPrioritySseqLabel.Text = "Player Priority:";
            this.playerPrioritySseqLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // channelPrioritySseqLabel
            // 
            this.channelPrioritySseqLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.channelPrioritySseqLabel.Location = new System.Drawing.Point(4, 98);
            this.channelPrioritySseqLabel.Name = "channelPrioritySseqLabel";
            this.channelPrioritySseqLabel.Size = new System.Drawing.Size(227, 23);
            this.channelPrioritySseqLabel.TabIndex = 7;
            this.channelPrioritySseqLabel.Text = "Channel Priority:";
            this.channelPrioritySseqLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // volumeSseqLabel
            // 
            this.volumeSseqLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.volumeSseqLabel.Location = new System.Drawing.Point(3, 49);
            this.volumeSseqLabel.Name = "volumeSseqLabel";
            this.volumeSseqLabel.Size = new System.Drawing.Size(229, 23);
            this.volumeSseqLabel.TabIndex = 6;
            this.volumeSseqLabel.Text = "Volume:";
            this.volumeSseqLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // playerNumberSseqBox
            // 
            this.playerNumberSseqBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.playerNumberSseqBox.Location = new System.Drawing.Point(4, 222);
            this.playerNumberSseqBox.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.playerNumberSseqBox.Name = "playerNumberSseqBox";
            this.playerNumberSseqBox.Size = new System.Drawing.Size(227, 20);
            this.playerNumberSseqBox.TabIndex = 5;
            this.playerNumberSseqBox.ValueChanged += new System.EventHandler(this.onPlayerNumberChanged);
            // 
            // playerPrioritySseqBox
            // 
            this.playerPrioritySseqBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.playerPrioritySseqBox.Location = new System.Drawing.Point(4, 173);
            this.playerPrioritySseqBox.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.playerPrioritySseqBox.Name = "playerPrioritySseqBox";
            this.playerPrioritySseqBox.Size = new System.Drawing.Size(228, 20);
            this.playerPrioritySseqBox.TabIndex = 4;
            this.playerPrioritySseqBox.ValueChanged += new System.EventHandler(this.onPlayerPriorityChanged);
            // 
            // channelPrioritySseqBox
            // 
            this.channelPrioritySseqBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.channelPrioritySseqBox.Location = new System.Drawing.Point(3, 124);
            this.channelPrioritySseqBox.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.channelPrioritySseqBox.Name = "channelPrioritySseqBox";
            this.channelPrioritySseqBox.Size = new System.Drawing.Size(229, 20);
            this.channelPrioritySseqBox.TabIndex = 3;
            this.channelPrioritySseqBox.ValueChanged += new System.EventHandler(this.onChannelPriorityChanged);
            // 
            // volumeSseqBox
            // 
            this.volumeSseqBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.volumeSseqBox.Location = new System.Drawing.Point(4, 75);
            this.volumeSseqBox.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.volumeSseqBox.Name = "volumeSseqBox";
            this.volumeSseqBox.Size = new System.Drawing.Size(228, 20);
            this.volumeSseqBox.TabIndex = 2;
            this.volumeSseqBox.ValueChanged += new System.EventHandler(this.onVolumeChanged);
            // 
            // bankIDbox
            // 
            this.bankIDbox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bankIDbox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.bankIDbox.FormattingEnabled = true;
            this.bankIDbox.Location = new System.Drawing.Point(4, 26);
            this.bankIDbox.Name = "bankIDbox";
            this.bankIDbox.Size = new System.Drawing.Size(228, 21);
            this.bankIDbox.TabIndex = 1;
            this.bankIDbox.SelectedIndexChanged += new System.EventHandler(this.onBankIdChanged);
            // 
            // bankIdLabel
            // 
            this.bankIdLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bankIdLabel.Location = new System.Drawing.Point(48, 0);
            this.bankIdLabel.Name = "bankIdLabel";
            this.bankIdLabel.Size = new System.Drawing.Size(140, 23);
            this.bankIdLabel.TabIndex = 0;
            this.bankIdLabel.Text = "Bank ID:";
            this.bankIdLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // fileIdBox
            // 
            this.fileIdBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fileIdBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.fileIdBox.FormattingEnabled = true;
            this.fileIdBox.Location = new System.Drawing.Point(4, 26);
            this.fileIdBox.Name = "fileIdBox";
            this.fileIdBox.Size = new System.Drawing.Size(227, 21);
            this.fileIdBox.TabIndex = 1;
            this.fileIdBox.Visible = false;
            this.fileIdBox.SelectedIndexChanged += new System.EventHandler(this.onFileIdChange);
            // 
            // fileIdLabel
            // 
            this.fileIdLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.fileIdLabel.Location = new System.Drawing.Point(0, 0);
            this.fileIdLabel.Name = "fileIdLabel";
            this.fileIdLabel.Size = new System.Drawing.Size(234, 23);
            this.fileIdLabel.TabIndex = 2;
            this.fileIdLabel.Text = "File ID:";
            this.fileIdLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.fileIdLabel.Visible = false;
            // 
            // bankGroup
            // 
            this.bankGroup.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bankGroup.Controls.Add(this.wave3Box);
            this.bankGroup.Controls.Add(this.wave2Box);
            this.bankGroup.Controls.Add(this.wave1Box);
            this.bankGroup.Controls.Add(this.wave0Box);
            this.bankGroup.Controls.Add(this.wave3Label);
            this.bankGroup.Controls.Add(this.wave2Label);
            this.bankGroup.Controls.Add(this.wave1Label);
            this.bankGroup.Controls.Add(this.wave0Label);
            this.bankGroup.Location = new System.Drawing.Point(0, 53);
            this.bankGroup.Name = "bankGroup";
            this.bankGroup.Size = new System.Drawing.Size(234, 363);
            this.bankGroup.TabIndex = 4;
            this.bankGroup.Visible = false;
            // 
            // wave3Box
            // 
            this.wave3Box.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.wave3Box.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.wave3Box.FormattingEnabled = true;
            this.wave3Box.Location = new System.Drawing.Point(3, 184);
            this.wave3Box.Name = "wave3Box";
            this.wave3Box.Size = new System.Drawing.Size(228, 21);
            this.wave3Box.TabIndex = 7;
            this.wave3Box.SelectedIndexChanged += new System.EventHandler(this.wave3updated);
            // 
            // wave2Box
            // 
            this.wave2Box.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.wave2Box.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.wave2Box.FormattingEnabled = true;
            this.wave2Box.Location = new System.Drawing.Point(3, 128);
            this.wave2Box.Name = "wave2Box";
            this.wave2Box.Size = new System.Drawing.Size(228, 21);
            this.wave2Box.TabIndex = 6;
            this.wave2Box.SelectedIndexChanged += new System.EventHandler(this.wave2updated);
            // 
            // wave1Box
            // 
            this.wave1Box.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.wave1Box.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.wave1Box.FormattingEnabled = true;
            this.wave1Box.Location = new System.Drawing.Point(3, 75);
            this.wave1Box.Name = "wave1Box";
            this.wave1Box.Size = new System.Drawing.Size(228, 21);
            this.wave1Box.TabIndex = 5;
            this.wave1Box.SelectedIndexChanged += new System.EventHandler(this.wave1updated);
            // 
            // wave0Box
            // 
            this.wave0Box.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.wave0Box.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.wave0Box.FormattingEnabled = true;
            this.wave0Box.Location = new System.Drawing.Point(3, 26);
            this.wave0Box.Name = "wave0Box";
            this.wave0Box.Size = new System.Drawing.Size(228, 21);
            this.wave0Box.TabIndex = 4;
            this.wave0Box.SelectedIndexChanged += new System.EventHandler(this.wave0updated);
            // 
            // wave3Label
            // 
            this.wave3Label.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.wave3Label.Location = new System.Drawing.Point(3, 152);
            this.wave3Label.Name = "wave3Label";
            this.wave3Label.Size = new System.Drawing.Size(228, 29);
            this.wave3Label.TabIndex = 3;
            this.wave3Label.Text = "Wave 3:";
            this.wave3Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // wave2Label
            // 
            this.wave2Label.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.wave2Label.Location = new System.Drawing.Point(3, 99);
            this.wave2Label.Name = "wave2Label";
            this.wave2Label.Size = new System.Drawing.Size(228, 26);
            this.wave2Label.TabIndex = 2;
            this.wave2Label.Text = "Wave 2:";
            this.wave2Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // wave1Label
            // 
            this.wave1Label.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.wave1Label.Location = new System.Drawing.Point(3, 50);
            this.wave1Label.Name = "wave1Label";
            this.wave1Label.Size = new System.Drawing.Size(228, 22);
            this.wave1Label.TabIndex = 1;
            this.wave1Label.Text = "Wave 1:";
            this.wave1Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // wave0Label
            // 
            this.wave0Label.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.wave0Label.Location = new System.Drawing.Point(3, 0);
            this.wave0Label.Name = "wave0Label";
            this.wave0Label.Size = new System.Drawing.Size(228, 23);
            this.wave0Label.TabIndex = 0;
            this.wave0Label.Text = "Wave 0:";
            this.wave0Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // noSelectLabel
            // 
            this.noSelectLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.noSelectLabel.Location = new System.Drawing.Point(0, 0);
            this.noSelectLabel.Name = "noSelectLabel";
            this.noSelectLabel.Size = new System.Drawing.Size(234, 446);
            this.noSelectLabel.TabIndex = 0;
            this.noSelectLabel.Text = "No Valid Info Selected!";
            this.noSelectLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // playerGroup
            // 
            this.playerGroup.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.playerGroup.Controls.Add(this.tableLayoutPanel4);
            this.playerGroup.Controls.Add(this.sequenceMaxLabel);
            this.playerGroup.Controls.Add(this.heapSizeBox);
            this.playerGroup.Controls.Add(this.heapSizeLabel);
            this.playerGroup.Controls.Add(this.channelFlagLabel);
            this.playerGroup.Controls.Add(this.sequenceMaxBox);
            this.playerGroup.Location = new System.Drawing.Point(0, 0);
            this.playerGroup.Name = "playerGroup";
            this.playerGroup.Size = new System.Drawing.Size(235, 419);
            this.playerGroup.TabIndex = 11;
            this.playerGroup.Visible = false;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel4.ColumnCount = 4;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.00062F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.00063F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.00063F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.99813F));
            this.tableLayoutPanel4.Controls.Add(this.alloc11, 3, 2);
            this.tableLayoutPanel4.Controls.Add(this.alloc10, 2, 2);
            this.tableLayoutPanel4.Controls.Add(this.alloc9, 1, 2);
            this.tableLayoutPanel4.Controls.Add(this.alloc14, 0, 3);
            this.tableLayoutPanel4.Controls.Add(this.alloc13, 0, 3);
            this.tableLayoutPanel4.Controls.Add(this.alloc15, 3, 3);
            this.tableLayoutPanel4.Controls.Add(this.alloc12, 0, 3);
            this.tableLayoutPanel4.Controls.Add(this.alloc8, 0, 2);
            this.tableLayoutPanel4.Controls.Add(this.alloc7, 3, 1);
            this.tableLayoutPanel4.Controls.Add(this.alloc6, 2, 1);
            this.tableLayoutPanel4.Controls.Add(this.alloc5, 1, 1);
            this.tableLayoutPanel4.Controls.Add(this.alloc4, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.alloc3, 3, 0);
            this.tableLayoutPanel4.Controls.Add(this.alloc2, 2, 0);
            this.tableLayoutPanel4.Controls.Add(this.alloc1, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.alloc0, 0, 0);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(6, 126);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 4;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.00062F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.00063F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.00062F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24.99813F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(226, 94);
            this.tableLayoutPanel4.TabIndex = 6;
            // 
            // alloc11
            // 
            this.alloc11.AutoSize = true;
            this.alloc11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.alloc11.Location = new System.Drawing.Point(171, 49);
            this.alloc11.Name = "alloc11";
            this.alloc11.Size = new System.Drawing.Size(52, 17);
            this.alloc11.TabIndex = 15;
            this.alloc11.Text = "11";
            this.alloc11.UseVisualStyleBackColor = true;
            this.alloc11.CheckedChanged += new System.EventHandler(this.onAllocChanged);
            // 
            // alloc10
            // 
            this.alloc10.AutoSize = true;
            this.alloc10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.alloc10.Location = new System.Drawing.Point(115, 49);
            this.alloc10.Name = "alloc10";
            this.alloc10.Size = new System.Drawing.Size(50, 17);
            this.alloc10.TabIndex = 14;
            this.alloc10.Text = "10";
            this.alloc10.UseVisualStyleBackColor = true;
            this.alloc10.CheckedChanged += new System.EventHandler(this.onAllocChanged);
            // 
            // alloc9
            // 
            this.alloc9.AutoSize = true;
            this.alloc9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.alloc9.Location = new System.Drawing.Point(59, 49);
            this.alloc9.Name = "alloc9";
            this.alloc9.Size = new System.Drawing.Size(50, 17);
            this.alloc9.TabIndex = 13;
            this.alloc9.Text = "9";
            this.alloc9.UseVisualStyleBackColor = true;
            this.alloc9.CheckedChanged += new System.EventHandler(this.onAllocChanged);
            // 
            // alloc14
            // 
            this.alloc14.AutoSize = true;
            this.alloc14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.alloc14.Location = new System.Drawing.Point(115, 72);
            this.alloc14.Name = "alloc14";
            this.alloc14.Size = new System.Drawing.Size(50, 19);
            this.alloc14.TabIndex = 12;
            this.alloc14.Text = "14";
            this.alloc14.UseVisualStyleBackColor = true;
            this.alloc14.CheckedChanged += new System.EventHandler(this.onAllocChanged);
            // 
            // alloc13
            // 
            this.alloc13.AutoSize = true;
            this.alloc13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.alloc13.Location = new System.Drawing.Point(59, 72);
            this.alloc13.Name = "alloc13";
            this.alloc13.Size = new System.Drawing.Size(50, 19);
            this.alloc13.TabIndex = 11;
            this.alloc13.Text = "13";
            this.alloc13.UseVisualStyleBackColor = true;
            this.alloc13.CheckedChanged += new System.EventHandler(this.onAllocChanged);
            // 
            // alloc15
            // 
            this.alloc15.AutoSize = true;
            this.alloc15.Dock = System.Windows.Forms.DockStyle.Fill;
            this.alloc15.Location = new System.Drawing.Point(171, 72);
            this.alloc15.Name = "alloc15";
            this.alloc15.Size = new System.Drawing.Size(52, 19);
            this.alloc15.TabIndex = 10;
            this.alloc15.Text = "15";
            this.alloc15.UseVisualStyleBackColor = true;
            this.alloc15.CheckedChanged += new System.EventHandler(this.onAllocChanged);
            // 
            // alloc12
            // 
            this.alloc12.AutoSize = true;
            this.alloc12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.alloc12.Location = new System.Drawing.Point(3, 72);
            this.alloc12.Name = "alloc12";
            this.alloc12.Size = new System.Drawing.Size(50, 19);
            this.alloc12.TabIndex = 9;
            this.alloc12.Text = "12";
            this.alloc12.UseVisualStyleBackColor = true;
            this.alloc12.CheckedChanged += new System.EventHandler(this.onAllocChanged);
            // 
            // alloc8
            // 
            this.alloc8.AutoSize = true;
            this.alloc8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.alloc8.Location = new System.Drawing.Point(3, 49);
            this.alloc8.Name = "alloc8";
            this.alloc8.Size = new System.Drawing.Size(50, 17);
            this.alloc8.TabIndex = 8;
            this.alloc8.Text = "8";
            this.alloc8.UseVisualStyleBackColor = true;
            this.alloc8.CheckedChanged += new System.EventHandler(this.onAllocChanged);
            // 
            // alloc7
            // 
            this.alloc7.AutoSize = true;
            this.alloc7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.alloc7.Location = new System.Drawing.Point(171, 26);
            this.alloc7.Name = "alloc7";
            this.alloc7.Size = new System.Drawing.Size(52, 17);
            this.alloc7.TabIndex = 7;
            this.alloc7.Text = "7";
            this.alloc7.UseVisualStyleBackColor = true;
            this.alloc7.CheckedChanged += new System.EventHandler(this.onAllocChanged);
            // 
            // alloc6
            // 
            this.alloc6.AutoSize = true;
            this.alloc6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.alloc6.Location = new System.Drawing.Point(115, 26);
            this.alloc6.Name = "alloc6";
            this.alloc6.Size = new System.Drawing.Size(50, 17);
            this.alloc6.TabIndex = 6;
            this.alloc6.Text = "6";
            this.alloc6.UseVisualStyleBackColor = true;
            this.alloc6.CheckedChanged += new System.EventHandler(this.onAllocChanged);
            // 
            // alloc5
            // 
            this.alloc5.AutoSize = true;
            this.alloc5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.alloc5.Location = new System.Drawing.Point(59, 26);
            this.alloc5.Name = "alloc5";
            this.alloc5.Size = new System.Drawing.Size(50, 17);
            this.alloc5.TabIndex = 5;
            this.alloc5.Text = "5";
            this.alloc5.UseVisualStyleBackColor = true;
            this.alloc5.CheckedChanged += new System.EventHandler(this.onAllocChanged);
            // 
            // alloc4
            // 
            this.alloc4.AutoSize = true;
            this.alloc4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.alloc4.Location = new System.Drawing.Point(3, 26);
            this.alloc4.Name = "alloc4";
            this.alloc4.Size = new System.Drawing.Size(50, 17);
            this.alloc4.TabIndex = 4;
            this.alloc4.Text = "4";
            this.alloc4.UseVisualStyleBackColor = true;
            this.alloc4.CheckedChanged += new System.EventHandler(this.onAllocChanged);
            // 
            // alloc3
            // 
            this.alloc3.AutoSize = true;
            this.alloc3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.alloc3.Location = new System.Drawing.Point(171, 3);
            this.alloc3.Name = "alloc3";
            this.alloc3.Size = new System.Drawing.Size(52, 17);
            this.alloc3.TabIndex = 3;
            this.alloc3.Text = "3";
            this.alloc3.UseVisualStyleBackColor = true;
            this.alloc3.CheckedChanged += new System.EventHandler(this.onAllocChanged);
            // 
            // alloc2
            // 
            this.alloc2.AutoSize = true;
            this.alloc2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.alloc2.Location = new System.Drawing.Point(115, 3);
            this.alloc2.Name = "alloc2";
            this.alloc2.Size = new System.Drawing.Size(50, 17);
            this.alloc2.TabIndex = 2;
            this.alloc2.Text = "2";
            this.alloc2.UseVisualStyleBackColor = true;
            this.alloc2.CheckedChanged += new System.EventHandler(this.onAllocChanged);
            // 
            // alloc1
            // 
            this.alloc1.AutoSize = true;
            this.alloc1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.alloc1.Location = new System.Drawing.Point(59, 3);
            this.alloc1.Name = "alloc1";
            this.alloc1.Size = new System.Drawing.Size(50, 17);
            this.alloc1.TabIndex = 1;
            this.alloc1.Text = "1";
            this.alloc1.UseVisualStyleBackColor = true;
            this.alloc1.CheckedChanged += new System.EventHandler(this.onAllocChanged);
            // 
            // alloc0
            // 
            this.alloc0.AutoSize = true;
            this.alloc0.Dock = System.Windows.Forms.DockStyle.Fill;
            this.alloc0.Location = new System.Drawing.Point(3, 3);
            this.alloc0.Name = "alloc0";
            this.alloc0.Size = new System.Drawing.Size(50, 17);
            this.alloc0.TabIndex = 0;
            this.alloc0.Text = "0";
            this.alloc0.UseVisualStyleBackColor = true;
            this.alloc0.CheckedChanged += new System.EventHandler(this.onAllocChanged);
            // 
            // sequenceMaxLabel
            // 
            this.sequenceMaxLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sequenceMaxLabel.Location = new System.Drawing.Point(0, 1);
            this.sequenceMaxLabel.Name = "sequenceMaxLabel";
            this.sequenceMaxLabel.Size = new System.Drawing.Size(235, 23);
            this.sequenceMaxLabel.TabIndex = 0;
            this.sequenceMaxLabel.Text = "Sequence Max:";
            this.sequenceMaxLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // heapSizeBox
            // 
            this.heapSizeBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.heapSizeBox.Location = new System.Drawing.Point(5, 79);
            this.heapSizeBox.Maximum = new decimal(new int[] {
            -1,
            0,
            0,
            0});
            this.heapSizeBox.Name = "heapSizeBox";
            this.heapSizeBox.Size = new System.Drawing.Size(227, 20);
            this.heapSizeBox.TabIndex = 5;
            this.heapSizeBox.ValueChanged += new System.EventHandler(this.onheapSizeChanged);
            // 
            // heapSizeLabel
            // 
            this.heapSizeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.heapSizeLabel.Location = new System.Drawing.Point(0, 53);
            this.heapSizeLabel.Name = "heapSizeLabel";
            this.heapSizeLabel.Size = new System.Drawing.Size(235, 23);
            this.heapSizeLabel.TabIndex = 4;
            this.heapSizeLabel.Text = "Heap Size (Bytes):";
            this.heapSizeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // channelFlagLabel
            // 
            this.channelFlagLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.channelFlagLabel.Location = new System.Drawing.Point(1, 103);
            this.channelFlagLabel.Name = "channelFlagLabel";
            this.channelFlagLabel.Size = new System.Drawing.Size(235, 23);
            this.channelFlagLabel.TabIndex = 2;
            this.channelFlagLabel.Text = "Allocatable Channel Flags:";
            this.channelFlagLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sequenceMaxBox
            // 
            this.sequenceMaxBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sequenceMaxBox.Location = new System.Drawing.Point(5, 27);
            this.sequenceMaxBox.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.sequenceMaxBox.Name = "sequenceMaxBox";
            this.sequenceMaxBox.Size = new System.Drawing.Size(227, 20);
            this.sequenceMaxBox.TabIndex = 1;
            this.sequenceMaxBox.ValueChanged += new System.EventHandler(this.onSequenceMaxChanged);
            // 
            // tree
            // 
            this.tree.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tree.ImageIndex = 0;
            this.tree.ImageList = this.nodeImages;
            this.tree.Indent = 15;
            this.tree.Location = new System.Drawing.Point(0, 0);
            this.tree.Name = "tree";
            treeNode1.Name = "Sseq";
            treeNode1.Tag = "sseq";
            treeNode1.Text = "Sound Sequence";
            treeNode2.ImageIndex = 1;
            treeNode2.Name = "SeqArc";
            treeNode2.SelectedImageIndex = 1;
            treeNode2.Tag = "seqarc";
            treeNode2.Text = "Sequence Archive";
            treeNode3.ImageIndex = 2;
            treeNode3.Name = "Bank";
            treeNode3.SelectedImageIndex = 2;
            treeNode3.Tag = "bank";
            treeNode3.Text = "Instrument Bank";
            treeNode4.ImageIndex = 3;
            treeNode4.Name = "Wave Archive";
            treeNode4.SelectedImageIndex = 3;
            treeNode4.Tag = "wave";
            treeNode4.Text = "Wave Archive";
            treeNode5.ImageIndex = 4;
            treeNode5.Name = "Sequence Player";
            treeNode5.SelectedImageIndex = 4;
            treeNode5.Tag = "player";
            treeNode5.Text = "Sequence Player";
            treeNode6.ImageIndex = 5;
            treeNode6.Name = "Group";
            treeNode6.SelectedImageIndex = 5;
            treeNode6.Tag = "group";
            treeNode6.Text = "Group";
            treeNode7.ImageIndex = 6;
            treeNode7.Name = "Strm Player";
            treeNode7.SelectedImageIndex = 6;
            treeNode7.Tag = "strmplayer";
            treeNode7.Text = "Stream Player";
            treeNode8.ImageIndex = 7;
            treeNode8.Name = "strm";
            treeNode8.SelectedImageIndex = 7;
            treeNode8.Tag = "strm";
            treeNode8.Text = "Stream";
            treeNode9.ImageIndex = 8;
            treeNode9.Name = "sequenceFiles";
            treeNode9.SelectedImageIndex = 8;
            treeNode9.Text = "Sequence";
            treeNode10.ImageIndex = 8;
            treeNode10.Name = "sequenceArchive";
            treeNode10.SelectedImageIndex = 8;
            treeNode10.Text = "Sequence Archive";
            treeNode11.ImageIndex = 8;
            treeNode11.Name = "bankFiles";
            treeNode11.SelectedImageIndex = 8;
            treeNode11.Text = "Bank";
            treeNode12.ImageIndex = 8;
            treeNode12.Name = "waveFiles";
            treeNode12.SelectedImageIndex = 8;
            treeNode12.Text = "Wave Archive";
            treeNode13.ImageIndex = 8;
            treeNode13.Name = "strmFiles";
            treeNode13.SelectedImageIndex = 8;
            treeNode13.Text = "Stream";
            treeNode14.ContextMenuStrip = this.bigFolderMenu;
            treeNode14.ImageIndex = 8;
            treeNode14.Name = "FILES";
            treeNode14.SelectedImageIndex = 8;
            treeNode14.Tag = "files";
            treeNode14.Text = "FILES";
            this.tree.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4,
            treeNode5,
            treeNode6,
            treeNode7,
            treeNode8,
            treeNode14});
            this.tree.SelectedImageIndex = 0;
            this.tree.ShowLines = false;
            this.tree.Size = new System.Drawing.Size(585, 446);
            this.tree.TabIndex = 0;
            this.tree.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            this.tree.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.tree_NodeMouseClick);
            this.tree.DoubleClick += new System.EventHandler(this.doubleClickNode);
            this.tree.KeyUp += new System.Windows.Forms.KeyEventHandler(this.treeArrowKey);
            // 
            // nodeImages
            // 
            this.nodeImages.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("nodeImages.ImageStream")));
            this.nodeImages.TransparentColor = System.Drawing.Color.Transparent;
            this.nodeImages.Images.SetKeyName(0, "sseq.png");
            this.nodeImages.Images.SetKeyName(1, "seqArc.png");
            this.nodeImages.Images.SetKeyName(2, "bank.png");
            this.nodeImages.Images.SetKeyName(3, "waveArchive.png");
            this.nodeImages.Images.SetKeyName(4, "player.png");
            this.nodeImages.Images.SetKeyName(5, "group.png");
            this.nodeImages.Images.SetKeyName(6, "player2.png");
            this.nodeImages.Images.SetKeyName(7, "strm.png");
            this.nodeImages.Images.SetKeyName(8, "FILES.png");
            this.nodeImages.Images.SetKeyName(9, "blank.png");
            // 
            // filesMenu
            // 
            this.filesMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addAbove,
            this.addBelow,
            this.Export,
            this.Replace,
            this.Delete});
            this.filesMenu.Name = "filesMenu";
            this.filesMenu.Size = new System.Drawing.Size(158, 114);
            // 
            // addAbove
            // 
            this.addAbove.Image = ((System.Drawing.Image)(resources.GetObject("addAbove.Image")));
            this.addAbove.Name = "addAbove";
            this.addAbove.Size = new System.Drawing.Size(157, 22);
            this.addAbove.Text = "Add Above This";
            this.addAbove.Click += new System.EventHandler(this.addAbove_Click);
            // 
            // addBelow
            // 
            this.addBelow.Image = ((System.Drawing.Image)(resources.GetObject("addBelow.Image")));
            this.addBelow.Name = "addBelow";
            this.addBelow.Size = new System.Drawing.Size(157, 22);
            this.addBelow.Text = "Add Below This";
            this.addBelow.Click += new System.EventHandler(this.addBelow_Click);
            // 
            // Export
            // 
            this.Export.Image = ((System.Drawing.Image)(resources.GetObject("Export.Image")));
            this.Export.Name = "Export";
            this.Export.Size = new System.Drawing.Size(157, 22);
            this.Export.Text = "Export";
            this.Export.Click += new System.EventHandler(this.Export_Click);
            // 
            // Replace
            // 
            this.Replace.Image = ((System.Drawing.Image)(resources.GetObject("Replace.Image")));
            this.Replace.Name = "Replace";
            this.Replace.Size = new System.Drawing.Size(157, 22);
            this.Replace.Text = "Replace";
            this.Replace.Click += new System.EventHandler(this.Replace_Click);
            // 
            // Delete
            // 
            this.Delete.Image = ((System.Drawing.Image)(resources.GetObject("Delete.Image")));
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(157, 22);
            this.Delete.Text = "Delete";
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // foldersMenu
            // 
            this.foldersMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Add2,
            this.openTree2,
            this.closeTree2});
            this.foldersMenu.Name = "filesMenu";
            this.foldersMenu.Size = new System.Drawing.Size(120, 70);
            // 
            // Add2
            // 
            this.Add2.Image = ((System.Drawing.Image)(resources.GetObject("Add2.Image")));
            this.Add2.Name = "Add2";
            this.Add2.Size = new System.Drawing.Size(119, 22);
            this.Add2.Text = "Add";
            this.Add2.Click += new System.EventHandler(this.Add2_Click);
            // 
            // openTree2
            // 
            this.openTree2.Image = ((System.Drawing.Image)(resources.GetObject("openTree2.Image")));
            this.openTree2.Name = "openTree2";
            this.openTree2.Size = new System.Drawing.Size(119, 22);
            this.openTree2.Text = "Expand";
            this.openTree2.Click += new System.EventHandler(this.openTree2_Click);
            // 
            // closeTree2
            // 
            this.closeTree2.Image = ((System.Drawing.Image)(resources.GetObject("closeTree2.Image")));
            this.closeTree2.Name = "closeTree2";
            this.closeTree2.Size = new System.Drawing.Size(119, 22);
            this.closeTree2.Text = "Collapse";
            this.closeTree2.Click += new System.EventHandler(this.closeTree2_Click);
            // 
            // nodeMenu
            // 
            this.nodeMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Add3,
            this.Add32,
            this.addInside,
            this.openTree3,
            this.closeTree3,
            this.exportToolStripMenuItem1,
            this.replaceToolStripMenuItem,
            this.rename3,
            this.deleteMeh});
            this.nodeMenu.Name = "nodeMenu";
            this.nodeMenu.Size = new System.Drawing.Size(137, 202);
            this.nodeMenu.Opening += new System.ComponentModel.CancelEventHandler(this.nodeMenu_Opening);
            // 
            // Add3
            // 
            this.Add3.Image = ((System.Drawing.Image)(resources.GetObject("Add3.Image")));
            this.Add3.Name = "Add3";
            this.Add3.Size = new System.Drawing.Size(136, 22);
            this.Add3.Text = "Add Above";
            this.Add3.Click += new System.EventHandler(this.Add3_Click);
            // 
            // Add32
            // 
            this.Add32.Image = ((System.Drawing.Image)(resources.GetObject("Add32.Image")));
            this.Add32.Name = "Add32";
            this.Add32.Size = new System.Drawing.Size(136, 22);
            this.Add32.Text = "Add Below";
            this.Add32.Click += new System.EventHandler(this.Add32_Click);
            // 
            // addInside
            // 
            this.addInside.Image = ((System.Drawing.Image)(resources.GetObject("addInside.Image")));
            this.addInside.Name = "addInside";
            this.addInside.Size = new System.Drawing.Size(136, 22);
            this.addInside.Text = "Add Inside";
            this.addInside.Click += new System.EventHandler(this.addInside_Click);
            // 
            // openTree3
            // 
            this.openTree3.Image = ((System.Drawing.Image)(resources.GetObject("openTree3.Image")));
            this.openTree3.Name = "openTree3";
            this.openTree3.Size = new System.Drawing.Size(136, 22);
            this.openTree3.Text = "Expand";
            this.openTree3.Click += new System.EventHandler(this.openTree3_Click);
            // 
            // closeTree3
            // 
            this.closeTree3.Image = ((System.Drawing.Image)(resources.GetObject("closeTree3.Image")));
            this.closeTree3.Name = "closeTree3";
            this.closeTree3.Size = new System.Drawing.Size(136, 22);
            this.closeTree3.Text = "Collapse";
            this.closeTree3.Click += new System.EventHandler(this.closeTree3_Click);
            // 
            // exportToolStripMenuItem1
            // 
            this.exportToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("exportToolStripMenuItem1.Image")));
            this.exportToolStripMenuItem1.Name = "exportToolStripMenuItem1";
            this.exportToolStripMenuItem1.Size = new System.Drawing.Size(136, 22);
            this.exportToolStripMenuItem1.Text = "Export File";
            this.exportToolStripMenuItem1.Click += new System.EventHandler(this.exportToolStripMenuItem1_Click);
            // 
            // replaceToolStripMenuItem
            // 
            this.replaceToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("replaceToolStripMenuItem.Image")));
            this.replaceToolStripMenuItem.Name = "replaceToolStripMenuItem";
            this.replaceToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.replaceToolStripMenuItem.Text = "Replace File";
            this.replaceToolStripMenuItem.Click += new System.EventHandler(this.replaceToolStripMenuItem_Click);
            // 
            // rename3
            // 
            this.rename3.Image = ((System.Drawing.Image)(resources.GetObject("rename3.Image")));
            this.rename3.Name = "rename3";
            this.rename3.Size = new System.Drawing.Size(136, 22);
            this.rename3.Text = "Rename";
            this.rename3.Click += new System.EventHandler(this.rename3_Click);
            // 
            // deleteMeh
            // 
            this.deleteMeh.Image = ((System.Drawing.Image)(resources.GetObject("deleteMeh.Image")));
            this.deleteMeh.Name = "deleteMeh";
            this.deleteMeh.Size = new System.Drawing.Size(136, 22);
            this.deleteMeh.Text = "Delete";
            this.deleteMeh.Click += new System.EventHandler(this.deleteMeh_Click);
            // 
            // entryMenu
            // 
            this.entryMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Rename4,
            this.Delete4});
            this.entryMenu.Name = "entryMenu";
            this.entryMenu.Size = new System.Drawing.Size(118, 48);
            // 
            // Rename4
            // 
            this.Rename4.Image = ((System.Drawing.Image)(resources.GetObject("Rename4.Image")));
            this.Rename4.Name = "Rename4";
            this.Rename4.Size = new System.Drawing.Size(117, 22);
            this.Rename4.Text = "Rename";
            this.Rename4.Click += new System.EventHandler(this.Rename4_Click);
            // 
            // Delete4
            // 
            this.Delete4.Image = ((System.Drawing.Image)(resources.GetObject("Delete4.Image")));
            this.Delete4.Name = "Delete4";
            this.Delete4.Size = new System.Drawing.Size(117, 22);
            this.Delete4.Text = "Delete";
            this.Delete4.Click += new System.EventHandler(this.Delete4_Click);
            // 
            // bigNodeMenu
            // 
            this.bigNodeMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem5,
            this.toolStripMenuItem6,
            this.toolStripMenuItem7});
            this.bigNodeMenu.Name = "nodeMenu";
            this.bigNodeMenu.Size = new System.Drawing.Size(120, 70);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem5.Image")));
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(119, 22);
            this.toolStripMenuItem5.Text = "Add";
            this.toolStripMenuItem5.Click += new System.EventHandler(this.toolStripMenuItem5_Click);
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem6.Image")));
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(119, 22);
            this.toolStripMenuItem6.Text = "Expand";
            this.toolStripMenuItem6.Click += new System.EventHandler(this.toolStripMenuItem6_Click);
            // 
            // toolStripMenuItem7
            // 
            this.toolStripMenuItem7.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem7.Image")));
            this.toolStripMenuItem7.Name = "toolStripMenuItem7";
            this.toolStripMenuItem7.Size = new System.Drawing.Size(119, 22);
            this.toolStripMenuItem7.Text = "Collapse";
            this.toolStripMenuItem7.Click += new System.EventHandler(this.toolStripMenuItem7_Click);
            // 
            // subNodeMenu
            // 
            this.subNodeMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem4,
            this.toolStripMenuItem11,
            this.toolStripMenuItem12});
            this.subNodeMenu.Name = "nodeMenu";
            this.subNodeMenu.Size = new System.Drawing.Size(134, 92);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem1.Image")));
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(133, 22);
            this.toolStripMenuItem1.Text = "Add Above";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem4.Image")));
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(133, 22);
            this.toolStripMenuItem4.Text = "Add Below";
            this.toolStripMenuItem4.Click += new System.EventHandler(this.toolStripMenuItem4_Click);
            // 
            // toolStripMenuItem11
            // 
            this.toolStripMenuItem11.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem11.Image")));
            this.toolStripMenuItem11.Name = "toolStripMenuItem11";
            this.toolStripMenuItem11.Size = new System.Drawing.Size(133, 22);
            this.toolStripMenuItem11.Text = "Rename";
            this.toolStripMenuItem11.Click += new System.EventHandler(this.toolStripMenuItem11_Click);
            // 
            // toolStripMenuItem12
            // 
            this.toolStripMenuItem12.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem12.Image")));
            this.toolStripMenuItem12.Name = "toolStripMenuItem12";
            this.toolStripMenuItem12.Size = new System.Drawing.Size(133, 22);
            this.toolStripMenuItem12.Text = "Delete";
            this.toolStripMenuItem12.Click += new System.EventHandler(this.toolStripMenuItem12_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(825, 494);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainWindow";
            this.Text = "Nitro Studio";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.onClosingPlayer);
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.bigFolderMenu.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.strmGroup.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.playerBoxMagic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.priorityBoxBlack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.volumeBoxMushrooms)).EndInit();
            this.swarPanel.ResumeLayout(false);
            this.groupSubPanel.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.player2Group.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.channel0Box)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.channel1Box)).EndInit();
            this.placeHolderLayout.ResumeLayout(false);
            this.sseqGroup.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.playerNumberSseqBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerPrioritySseqBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.channelPrioritySseqBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.volumeSseqBox)).EndInit();
            this.bankGroup.ResumeLayout(false);
            this.playerGroup.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.heapSizeBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sequenceMaxBox)).EndInit();
            this.filesMenu.ResumeLayout(false);
            this.foldersMenu.ResumeLayout(false);
            this.nodeMenu.ResumeLayout(false);
            this.entryMenu.ResumeLayout(false);
            this.bigNodeMenu.ResumeLayout(false);
            this.subNodeMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newBetaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewHelpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutNitroComposerToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripProgressBar progressBar;
        private System.Windows.Forms.ToolStripStatusLabel status;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TreeView tree;
        private System.Windows.Forms.ImageList nodeImages;
        private System.Windows.Forms.ContextMenuStrip filesMenu;
        private System.Windows.Forms.ToolStripMenuItem Replace;
        private System.Windows.Forms.ToolStripMenuItem Delete;
        private System.Windows.Forms.ContextMenuStrip foldersMenu;
        private System.Windows.Forms.ToolStripMenuItem Add2;
        private System.Windows.Forms.ToolStripMenuItem openTree2;
        private System.Windows.Forms.ToolStripMenuItem closeTree2;
        private System.Windows.Forms.ContextMenuStrip nodeMenu;
        private System.Windows.Forms.ToolStripMenuItem Add3;
        private System.Windows.Forms.ToolStripMenuItem openTree3;
        private System.Windows.Forms.ToolStripMenuItem closeTree3;
        private System.Windows.Forms.ContextMenuStrip entryMenu;
        private System.Windows.Forms.ToolStripMenuItem Rename4;
        private System.Windows.Forms.ToolStripMenuItem Delete4;
        private System.Windows.Forms.ToolStripMenuItem Export;
        private System.Windows.Forms.Label noSelectLabel;
        private System.Windows.Forms.ComboBox fileIdBox;
        private System.Windows.Forms.Label fileIdLabel;
        private System.Windows.Forms.Panel bankGroup;
        private System.Windows.Forms.ComboBox wave0Box;
        private System.Windows.Forms.Label wave3Label;
        private System.Windows.Forms.Label wave2Label;
        private System.Windows.Forms.Label wave1Label;
        private System.Windows.Forms.Label wave0Label;
        private System.Windows.Forms.ComboBox wave3Box;
        private System.Windows.Forms.ComboBox wave2Box;
        private System.Windows.Forms.ComboBox wave1Box;
        private System.Windows.Forms.Panel sseqGroup;
        private System.Windows.Forms.Label bankIdLabel;
        private System.Windows.Forms.ComboBox bankIDbox;
        private System.Windows.Forms.NumericUpDown volumeSseqBox;
        private System.Windows.Forms.NumericUpDown playerNumberSseqBox;
        private System.Windows.Forms.NumericUpDown playerPrioritySseqBox;
        private System.Windows.Forms.NumericUpDown channelPrioritySseqBox;
        private System.Windows.Forms.Label playerNumberSseqLabel;
        private System.Windows.Forms.Label playerPrioritySseqLabel;
        private System.Windows.Forms.Label channelPrioritySseqLabel;
        private System.Windows.Forms.Label volumeSseqLabel;
        private System.Windows.Forms.Panel groupSubPanel;
        private System.Windows.Forms.Panel playerGroup;
        private System.Windows.Forms.NumericUpDown heapSizeBox;
        private System.Windows.Forms.Label heapSizeLabel;
        private System.Windows.Forms.Label channelFlagLabel;
        private System.Windows.Forms.NumericUpDown sequenceMaxBox;
        private System.Windows.Forms.Label sequenceMaxLabel;
        private System.Windows.Forms.Label typeGroupLabel;
        private System.Windows.Forms.ComboBox typeGroupBox;
        private System.Windows.Forms.Label nEntryLabel;
        private System.Windows.Forms.ComboBox nEntryBox;
        private System.Windows.Forms.Label loadFlagGroupLabel;
        private System.Windows.Forms.ToolStripStatusLabel byteSelect;
        private System.Windows.Forms.ToolStripMenuItem addAbove;
        private System.Windows.Forms.ToolStripMenuItem addBelow;
        private System.Windows.Forms.ContextMenuStrip bigFolderMenu;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem Add32;
        private System.Windows.Forms.ToolStripMenuItem addInside;
        private System.Windows.Forms.ToolStripMenuItem rename3;
        private System.Windows.Forms.ToolStripMenuItem deleteMeh;
        private System.Windows.Forms.ContextMenuStrip bigNodeMenu;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem7;
        private System.Windows.Forms.ContextMenuStrip subNodeMenu;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem11;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem12;
        private System.Windows.Forms.Panel player2Group;
        private System.Windows.Forms.Panel strmGroup;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown channel0Box;
        private System.Windows.Forms.NumericUpDown channel1Box;
        private System.Windows.Forms.Label gericomLabel;
        private System.Windows.Forms.Button gericomPlay;
        private System.Windows.Forms.Button gericomStop;
        private System.Windows.Forms.Button gericomPause;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.TableLayoutPanel placeHolderLayout;
        private System.Windows.Forms.CheckBox placeholderBox;
        private System.Windows.Forms.Button togglePlaceholderButton;
        private System.Windows.Forms.ComboBox typeBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label channel1;
        private System.Windows.Forms.Label channel0;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.CheckBox ssarBoxLoad;
        private System.Windows.Forms.CheckBox sseqBoxLoad;
        private System.Windows.Forms.CheckBox sbnkBoxLoad;
        private System.Windows.Forms.CheckBox swarBoxLoad;
        private System.Windows.Forms.ToolStripStatusLabel nodeSelected;
        private System.Windows.Forms.ToolStripStatusLabel parentNodeSelected;
        private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem replaceToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.CheckBox alloc11;
        private System.Windows.Forms.CheckBox alloc10;
        private System.Windows.Forms.CheckBox alloc9;
        private System.Windows.Forms.CheckBox alloc14;
        private System.Windows.Forms.CheckBox alloc13;
        private System.Windows.Forms.CheckBox alloc15;
        private System.Windows.Forms.CheckBox alloc12;
        private System.Windows.Forms.CheckBox alloc8;
        private System.Windows.Forms.CheckBox alloc7;
        private System.Windows.Forms.CheckBox alloc6;
        private System.Windows.Forms.CheckBox alloc5;
        private System.Windows.Forms.CheckBox alloc4;
        private System.Windows.Forms.CheckBox alloc3;
        private System.Windows.Forms.CheckBox alloc2;
        private System.Windows.Forms.CheckBox alloc1;
        private System.Windows.Forms.CheckBox alloc0;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.NumericUpDown playerBoxMagic;
        private System.Windows.Forms.Label playerLabelFrog;
        private System.Windows.Forms.NumericUpDown priorityBoxBlack;
        private System.Windows.Forms.NumericUpDown volumeBoxMushrooms;
        private System.Windows.Forms.Label priorityLabelPig;
        private System.Windows.Forms.Label volumeLabelFuckRocks;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox monoToStereoBox;
        private System.Windows.Forms.Panel swarPanel;
        private System.Windows.Forms.CheckBox loadIndividuallyBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bankGeneratorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem convertToSDKProjectToolStripMenuItem;
    }
}

