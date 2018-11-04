namespace GMLpal
{
    partial class GMLpal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GMLpal));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveChangesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reloadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripDropDownButton2 = new System.Windows.Forms.ToolStripDropDownButton();
            this.findToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripDropDownButton3 = new System.Windows.Forms.ToolStripDropDownButton();
            this.statsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.container = new System.Windows.Forms.SplitContainer();
            this.treeProject = new System.Windows.Forms.TreeView();
            this.imageListTree = new System.Windows.Forms.ImageList(this.components);
            this.tabView = new System.Windows.Forms.TabControl();
            this.tabView1 = new System.Windows.Forms.TabPage();
            this.tbxCode = new System.Windows.Forms.RichTextBox();
            this.tabView2 = new System.Windows.Forms.TabPage();
            this.panFind = new System.Windows.Forms.Panel();
            this.tbxReplace = new System.Windows.Forms.TextBox();
            this.cbxReplace = new System.Windows.Forms.CheckBox();
            this.cbxFindWord = new System.Windows.Forms.CheckBox();
            this.lblFindResult = new System.Windows.Forms.Label();
            this.cbxFindCase = new System.Windows.Forms.CheckBox();
            this.clbxFindProject = new System.Windows.Forms.CheckedListBox();
            this.panFindSettings = new System.Windows.Forms.Panel();
            this.rbtnFindSimple = new System.Windows.Forms.RadioButton();
            this.rbtnFindAdvanced = new System.Windows.Forms.RadioButton();
            this.rbtnFindSelected = new System.Windows.Forms.RadioButton();
            this.rbtnFindProject = new System.Windows.Forms.RadioButton();
            this.btnFind = new System.Windows.Forms.Button();
            this.treeFind = new System.Windows.Forms.TreeView();
            this.btnFindClose = new System.Windows.Forms.Button();
            this.lblFindHeader = new System.Windows.Forms.Label();
            this.lblFind = new System.Windows.Forms.Label();
            this.tbxFind = new System.Windows.Forms.TextBox();
            this.tabView3 = new System.Windows.Forms.TabPage();
            this.panStats = new System.Windows.Forms.Panel();
            this.cbxStatsNamesOnly = new System.Windows.Forms.CheckBox();
            this.rbtnStatsItems = new System.Windows.Forms.RadioButton();
            this.rbtnStatsSize = new System.Windows.Forms.RadioButton();
            this.rbtnStatsLines = new System.Windows.Forms.RadioButton();
            this.btnStatsShuffleColors = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbxStatsChart = new System.Windows.Forms.ComboBox();
            this.lblStats = new System.Windows.Forms.Label();
            this.chartStats = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnStatsClose = new System.Windows.Forms.Button();
            this.lblStatsHeader = new System.Windows.Forms.Label();
            this.openFileBrowse = new System.Windows.Forms.OpenFileDialog();
            this.cbxRegexMultiLine = new System.Windows.Forms.CheckBox();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.container)).BeginInit();
            this.container.Panel1.SuspendLayout();
            this.container.Panel2.SuspendLayout();
            this.container.SuspendLayout();
            this.tabView.SuspendLayout();
            this.tabView1.SuspendLayout();
            this.tabView2.SuspendLayout();
            this.panFind.SuspendLayout();
            this.panFindSettings.SuspendLayout();
            this.tabView3.SuspendLayout();
            this.panStats.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartStats)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1,
            this.toolStripDropDownButton2,
            this.toolStripDropDownButton3});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(735, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.AutoToolTip = false;
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveChangesToolStripMenuItem,
            this.reloadToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.ShowDropDownArrow = false;
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(29, 22);
            this.toolStripDropDownButton1.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.openToolStripMenuItem.Text = "Open...";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveChangesToolStripMenuItem
            // 
            this.saveChangesToolStripMenuItem.Name = "saveChangesToolStripMenuItem";
            this.saveChangesToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveChangesToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.saveChangesToolStripMenuItem.Text = "Save changes";
            this.saveChangesToolStripMenuItem.Click += new System.EventHandler(this.saveChangesToolStripMenuItem_Click);
            // 
            // reloadToolStripMenuItem
            // 
            this.reloadToolStripMenuItem.Name = "reloadToolStripMenuItem";
            this.reloadToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.reloadToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.reloadToolStripMenuItem.Text = "Reload";
            this.reloadToolStripMenuItem.Click += new System.EventHandler(this.reloadToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // toolStripDropDownButton2
            // 
            this.toolStripDropDownButton2.AutoToolTip = false;
            this.toolStripDropDownButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.findToolStripMenuItem});
            this.toolStripDropDownButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton2.Image")));
            this.toolStripDropDownButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton2.Name = "toolStripDropDownButton2";
            this.toolStripDropDownButton2.ShowDropDownArrow = false;
            this.toolStripDropDownButton2.Size = new System.Drawing.Size(31, 22);
            this.toolStripDropDownButton2.Text = "Edit";
            // 
            // findToolStripMenuItem
            // 
            this.findToolStripMenuItem.Name = "findToolStripMenuItem";
            this.findToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.findToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.findToolStripMenuItem.Text = "Find and replace...";
            this.findToolStripMenuItem.Click += new System.EventHandler(this.findToolStripMenuItem_Click);
            // 
            // toolStripDropDownButton3
            // 
            this.toolStripDropDownButton3.AutoToolTip = false;
            this.toolStripDropDownButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton3.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statsToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.toolStripDropDownButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton3.Image")));
            this.toolStripDropDownButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton3.Name = "toolStripDropDownButton3";
            this.toolStripDropDownButton3.ShowDropDownArrow = false;
            this.toolStripDropDownButton3.Size = new System.Drawing.Size(36, 22);
            this.toolStripDropDownButton3.Text = "Misc";
            // 
            // statsToolStripMenuItem
            // 
            this.statsToolStripMenuItem.Name = "statsToolStripMenuItem";
            this.statsToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.statsToolStripMenuItem.Text = "Stats...";
            this.statsToolStripMenuItem.Click += new System.EventHandler(this.statsToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.aboutToolStripMenuItem.Text = "About...";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // container
            // 
            this.container.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.container.Location = new System.Drawing.Point(0, 25);
            this.container.Margin = new System.Windows.Forms.Padding(0);
            this.container.Name = "container";
            // 
            // container.Panel1
            // 
            this.container.Panel1.Controls.Add(this.treeProject);
            // 
            // container.Panel2
            // 
            this.container.Panel2.Controls.Add(this.tabView);
            this.container.Size = new System.Drawing.Size(735, 391);
            this.container.SplitterDistance = 182;
            this.container.TabIndex = 1;
            // 
            // treeProject
            // 
            this.treeProject.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.treeProject.ImageIndex = 0;
            this.treeProject.ImageList = this.imageListTree;
            this.treeProject.Indent = 20;
            this.treeProject.ItemHeight = 16;
            this.treeProject.Location = new System.Drawing.Point(3, 3);
            this.treeProject.Name = "treeProject";
            this.treeProject.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.treeProject.SelectedImageIndex = 1;
            this.treeProject.Size = new System.Drawing.Size(176, 385);
            this.treeProject.TabIndex = 0;
            this.treeProject.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeProject_AfterSelect);
            // 
            // imageListTree
            // 
            this.imageListTree.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListTree.ImageStream")));
            this.imageListTree.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListTree.Images.SetKeyName(0, "folderclosed.png");
            this.imageListTree.Images.SetKeyName(1, "folderopen.png");
            this.imageListTree.Images.SetKeyName(2, "code.png");
            // 
            // tabView
            // 
            this.tabView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabView.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.tabView.Controls.Add(this.tabView1);
            this.tabView.Controls.Add(this.tabView2);
            this.tabView.Controls.Add(this.tabView3);
            this.tabView.ItemSize = new System.Drawing.Size(64, 21);
            this.tabView.Location = new System.Drawing.Point(3, 3);
            this.tabView.Multiline = true;
            this.tabView.Name = "tabView";
            this.tabView.SelectedIndex = 0;
            this.tabView.Size = new System.Drawing.Size(546, 385);
            this.tabView.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabView.TabIndex = 2;
            this.tabView.Visible = false;
            // 
            // tabView1
            // 
            this.tabView1.Controls.Add(this.tbxCode);
            this.tabView1.Location = new System.Drawing.Point(4, 25);
            this.tabView1.Name = "tabView1";
            this.tabView1.Padding = new System.Windows.Forms.Padding(3);
            this.tabView1.Size = new System.Drawing.Size(538, 356);
            this.tabView1.TabIndex = 0;
            this.tabView1.Text = "code";
            // 
            // tbxCode
            // 
            this.tbxCode.AcceptsTab = true;
            this.tbxCode.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxCode.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxCode.Location = new System.Drawing.Point(0, 0);
            this.tbxCode.Name = "tbxCode";
            this.tbxCode.ReadOnly = true;
            this.tbxCode.Size = new System.Drawing.Size(538, 356);
            this.tbxCode.TabIndex = 2;
            this.tbxCode.Text = "";
            this.tbxCode.WordWrap = false;
            // 
            // tabView2
            // 
            this.tabView2.Controls.Add(this.panFind);
            this.tabView2.Location = new System.Drawing.Point(4, 25);
            this.tabView2.Name = "tabView2";
            this.tabView2.Size = new System.Drawing.Size(538, 356);
            this.tabView2.TabIndex = 2;
            this.tabView2.Text = "find";
            this.tabView2.UseVisualStyleBackColor = true;
            // 
            // panFind
            // 
            this.panFind.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panFind.BackColor = System.Drawing.SystemColors.Control;
            this.panFind.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panFind.Controls.Add(this.tbxReplace);
            this.panFind.Controls.Add(this.cbxReplace);
            this.panFind.Controls.Add(this.cbxRegexMultiLine);
            this.panFind.Controls.Add(this.cbxFindWord);
            this.panFind.Controls.Add(this.lblFindResult);
            this.panFind.Controls.Add(this.cbxFindCase);
            this.panFind.Controls.Add(this.clbxFindProject);
            this.panFind.Controls.Add(this.panFindSettings);
            this.panFind.Controls.Add(this.rbtnFindSelected);
            this.panFind.Controls.Add(this.rbtnFindProject);
            this.panFind.Controls.Add(this.btnFind);
            this.panFind.Controls.Add(this.treeFind);
            this.panFind.Controls.Add(this.btnFindClose);
            this.panFind.Controls.Add(this.lblFindHeader);
            this.panFind.Controls.Add(this.lblFind);
            this.panFind.Controls.Add(this.tbxFind);
            this.panFind.Location = new System.Drawing.Point(0, 0);
            this.panFind.Name = "panFind";
            this.panFind.Size = new System.Drawing.Size(538, 356);
            this.panFind.TabIndex = 0;
            // 
            // tbxReplace
            // 
            this.tbxReplace.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxReplace.Enabled = false;
            this.tbxReplace.Font = new System.Drawing.Font("Consolas", 8.25F);
            this.tbxReplace.Location = new System.Drawing.Point(93, 78);
            this.tbxReplace.Name = "tbxReplace";
            this.tbxReplace.Size = new System.Drawing.Size(435, 20);
            this.tbxReplace.TabIndex = 22;
            // 
            // cbxReplace
            // 
            this.cbxReplace.AutoSize = true;
            this.cbxReplace.Location = new System.Drawing.Point(9, 81);
            this.cbxReplace.Name = "cbxReplace";
            this.cbxReplace.Size = new System.Drawing.Size(69, 17);
            this.cbxReplace.TabIndex = 21;
            this.cbxReplace.Text = "Replace:";
            this.cbxReplace.UseVisualStyleBackColor = true;
            this.cbxReplace.CheckedChanged += new System.EventHandler(this.cbxReplace_CheckedChanged);
            // 
            // cbxFindWord
            // 
            this.cbxFindWord.AutoSize = true;
            this.cbxFindWord.Location = new System.Drawing.Point(109, 58);
            this.cbxFindWord.Name = "cbxFindWord";
            this.cbxFindWord.Size = new System.Drawing.Size(105, 17);
            this.cbxFindWord.TabIndex = 17;
            this.cbxFindWord.Text = "Whole word only";
            this.cbxFindWord.UseVisualStyleBackColor = true;
            // 
            // lblFindResult
            // 
            this.lblFindResult.AutoSize = true;
            this.lblFindResult.Location = new System.Drawing.Point(3, 248);
            this.lblFindResult.Name = "lblFindResult";
            this.lblFindResult.Size = new System.Drawing.Size(67, 13);
            this.lblFindResult.TabIndex = 15;
            this.lblFindResult.Text = "lblFindResult";
            // 
            // cbxFindCase
            // 
            this.cbxFindCase.AutoSize = true;
            this.cbxFindCase.Location = new System.Drawing.Point(9, 58);
            this.cbxFindCase.Name = "cbxFindCase";
            this.cbxFindCase.Size = new System.Drawing.Size(94, 17);
            this.cbxFindCase.TabIndex = 6;
            this.cbxFindCase.Text = "Case sensitive";
            this.cbxFindCase.UseVisualStyleBackColor = true;
            // 
            // clbxFindProject
            // 
            this.clbxFindProject.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.clbxFindProject.CheckOnClick = true;
            this.clbxFindProject.FormattingEnabled = true;
            this.clbxFindProject.HorizontalScrollbar = true;
            this.clbxFindProject.Items.AddRange(new object[] {
            "Scripts",
            "Shaders",
            "Timelines",
            "Objects",
            "Rooms",
            "Constants"});
            this.clbxFindProject.Location = new System.Drawing.Point(9, 128);
            this.clbxFindProject.Name = "clbxFindProject";
            this.clbxFindProject.Size = new System.Drawing.Size(519, 94);
            this.clbxFindProject.TabIndex = 13;
            // 
            // panFindSettings
            // 
            this.panFindSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panFindSettings.Controls.Add(this.rbtnFindSimple);
            this.panFindSettings.Controls.Add(this.rbtnFindAdvanced);
            this.panFindSettings.Location = new System.Drawing.Point(351, 32);
            this.panFindSettings.Name = "panFindSettings";
            this.panFindSettings.Size = new System.Drawing.Size(177, 20);
            this.panFindSettings.TabIndex = 11;
            // 
            // rbtnFindSimple
            // 
            this.rbtnFindSimple.AutoSize = true;
            this.rbtnFindSimple.Checked = true;
            this.rbtnFindSimple.Location = new System.Drawing.Point(0, 2);
            this.rbtnFindSimple.Name = "rbtnFindSimple";
            this.rbtnFindSimple.Size = new System.Drawing.Size(56, 17);
            this.rbtnFindSimple.TabIndex = 5;
            this.rbtnFindSimple.TabStop = true;
            this.rbtnFindSimple.Text = "Simple";
            this.rbtnFindSimple.UseVisualStyleBackColor = true;
            this.rbtnFindSimple.CheckedChanged += new System.EventHandler(this.rbtnFindSimple_CheckedChanged);
            // 
            // rbtnFindAdvanced
            // 
            this.rbtnFindAdvanced.AutoSize = true;
            this.rbtnFindAdvanced.Location = new System.Drawing.Point(62, 2);
            this.rbtnFindAdvanced.Name = "rbtnFindAdvanced";
            this.rbtnFindAdvanced.Size = new System.Drawing.Size(115, 17);
            this.rbtnFindAdvanced.TabIndex = 5;
            this.rbtnFindAdvanced.Text = "Advanced (RegEx)";
            this.rbtnFindAdvanced.UseVisualStyleBackColor = true;
            this.rbtnFindAdvanced.CheckedChanged += new System.EventHandler(this.rbtnFindAdvanced_CheckedChanged);
            // 
            // rbtnFindSelected
            // 
            this.rbtnFindSelected.AutoSize = true;
            this.rbtnFindSelected.Location = new System.Drawing.Point(138, 102);
            this.rbtnFindSelected.Name = "rbtnFindSelected";
            this.rbtnFindSelected.Size = new System.Drawing.Size(140, 17);
            this.rbtnFindSelected.TabIndex = 9;
            this.rbtnFindSelected.Text = "Find within selected item";
            this.rbtnFindSelected.UseVisualStyleBackColor = true;
            this.rbtnFindSelected.CheckedChanged += new System.EventHandler(this.rbtnFindSelected_CheckedChanged);
            // 
            // rbtnFindProject
            // 
            this.rbtnFindProject.AutoSize = true;
            this.rbtnFindProject.Checked = true;
            this.rbtnFindProject.Location = new System.Drawing.Point(9, 102);
            this.rbtnFindProject.Name = "rbtnFindProject";
            this.rbtnFindProject.Size = new System.Drawing.Size(120, 17);
            this.rbtnFindProject.TabIndex = 9;
            this.rbtnFindProject.TabStop = true;
            this.rbtnFindProject.Text = "Find in entire project";
            this.rbtnFindProject.UseVisualStyleBackColor = true;
            this.rbtnFindProject.CheckedChanged += new System.EventHandler(this.rbtnFindProject_CheckedChanged);
            // 
            // btnFind
            // 
            this.btnFind.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnFind.Enabled = false;
            this.btnFind.Location = new System.Drawing.Point(215, 228);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(110, 33);
            this.btnFind.TabIndex = 8;
            this.btnFind.Text = "Find";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // treeFind
            // 
            this.treeFind.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.treeFind.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treeFind.Indent = 16;
            this.treeFind.ItemHeight = 18;
            this.treeFind.Location = new System.Drawing.Point(9, 267);
            this.treeFind.Name = "treeFind";
            this.treeFind.Size = new System.Drawing.Size(519, 82);
            this.treeFind.TabIndex = 7;
            // 
            // btnFindClose
            // 
            this.btnFindClose.Location = new System.Drawing.Point(4, 4);
            this.btnFindClose.Name = "btnFindClose";
            this.btnFindClose.Size = new System.Drawing.Size(24, 24);
            this.btnFindClose.TabIndex = 4;
            this.btnFindClose.Text = "X";
            this.btnFindClose.UseVisualStyleBackColor = true;
            this.btnFindClose.Click += new System.EventHandler(this.btnFindClose_Click);
            // 
            // lblFindHeader
            // 
            this.lblFindHeader.AutoSize = true;
            this.lblFindHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFindHeader.Location = new System.Drawing.Point(30, 10);
            this.lblFindHeader.Name = "lblFindHeader";
            this.lblFindHeader.Size = new System.Drawing.Size(102, 13);
            this.lblFindHeader.TabIndex = 3;
            this.lblFindHeader.Text = "Find and replace";
            // 
            // lblFind
            // 
            this.lblFind.AutoSize = true;
            this.lblFind.Location = new System.Drawing.Point(6, 35);
            this.lblFind.Name = "lblFind";
            this.lblFind.Size = new System.Drawing.Size(30, 13);
            this.lblFind.TabIndex = 2;
            this.lblFind.Text = "Find:";
            // 
            // tbxFind
            // 
            this.tbxFind.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxFind.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxFind.Location = new System.Drawing.Point(93, 32);
            this.tbxFind.Name = "tbxFind";
            this.tbxFind.Size = new System.Drawing.Size(252, 20);
            this.tbxFind.TabIndex = 1;
            this.tbxFind.TextChanged += new System.EventHandler(this.tbxFind_TextChanged);
            // 
            // tabView3
            // 
            this.tabView3.Controls.Add(this.panStats);
            this.tabView3.Location = new System.Drawing.Point(4, 25);
            this.tabView3.Name = "tabView3";
            this.tabView3.Padding = new System.Windows.Forms.Padding(3);
            this.tabView3.Size = new System.Drawing.Size(538, 356);
            this.tabView3.TabIndex = 3;
            this.tabView3.Text = "stats";
            this.tabView3.UseVisualStyleBackColor = true;
            // 
            // panStats
            // 
            this.panStats.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panStats.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panStats.Controls.Add(this.cbxStatsNamesOnly);
            this.panStats.Controls.Add(this.rbtnStatsItems);
            this.panStats.Controls.Add(this.rbtnStatsSize);
            this.panStats.Controls.Add(this.rbtnStatsLines);
            this.panStats.Controls.Add(this.btnStatsShuffleColors);
            this.panStats.Controls.Add(this.label1);
            this.panStats.Controls.Add(this.cmbxStatsChart);
            this.panStats.Controls.Add(this.lblStats);
            this.panStats.Controls.Add(this.chartStats);
            this.panStats.Controls.Add(this.btnStatsClose);
            this.panStats.Controls.Add(this.lblStatsHeader);
            this.panStats.Location = new System.Drawing.Point(0, 0);
            this.panStats.Name = "panStats";
            this.panStats.Size = new System.Drawing.Size(538, 356);
            this.panStats.TabIndex = 0;
            // 
            // cbxStatsNamesOnly
            // 
            this.cbxStatsNamesOnly.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbxStatsNamesOnly.AutoSize = true;
            this.cbxStatsNamesOnly.Location = new System.Drawing.Point(205, 330);
            this.cbxStatsNamesOnly.Name = "cbxStatsNamesOnly";
            this.cbxStatsNamesOnly.Size = new System.Drawing.Size(81, 17);
            this.cbxStatsNamesOnly.TabIndex = 14;
            this.cbxStatsNamesOnly.Text = "Names only";
            this.cbxStatsNamesOnly.UseVisualStyleBackColor = true;
            this.cbxStatsNamesOnly.CheckedChanged += new System.EventHandler(this.cbxStatsNamesOnly_CheckedChanged);
            // 
            // rbtnStatsItems
            // 
            this.rbtnStatsItems.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.rbtnStatsItems.AutoSize = true;
            this.rbtnStatsItems.Location = new System.Drawing.Point(154, 329);
            this.rbtnStatsItems.Name = "rbtnStatsItems";
            this.rbtnStatsItems.Size = new System.Drawing.Size(50, 17);
            this.rbtnStatsItems.TabIndex = 13;
            this.rbtnStatsItems.Text = "Items";
            this.rbtnStatsItems.UseVisualStyleBackColor = true;
            this.rbtnStatsItems.CheckedChanged += new System.EventHandler(this.rbtnStatsSize_CheckedChanged);
            // 
            // rbtnStatsSize
            // 
            this.rbtnStatsSize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.rbtnStatsSize.AutoSize = true;
            this.rbtnStatsSize.Location = new System.Drawing.Point(104, 329);
            this.rbtnStatsSize.Name = "rbtnStatsSize";
            this.rbtnStatsSize.Size = new System.Drawing.Size(45, 17);
            this.rbtnStatsSize.TabIndex = 13;
            this.rbtnStatsSize.Text = "Size";
            this.rbtnStatsSize.UseVisualStyleBackColor = true;
            this.rbtnStatsSize.CheckedChanged += new System.EventHandler(this.rbtnStatsSize_CheckedChanged);
            // 
            // rbtnStatsLines
            // 
            this.rbtnStatsLines.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.rbtnStatsLines.AutoSize = true;
            this.rbtnStatsLines.Checked = true;
            this.rbtnStatsLines.Location = new System.Drawing.Point(9, 329);
            this.rbtnStatsLines.Name = "rbtnStatsLines";
            this.rbtnStatsLines.Size = new System.Drawing.Size(89, 17);
            this.rbtnStatsLines.TabIndex = 13;
            this.rbtnStatsLines.TabStop = true;
            this.rbtnStatsLines.Text = "Lines of code";
            this.rbtnStatsLines.UseVisualStyleBackColor = true;
            this.rbtnStatsLines.CheckedChanged += new System.EventHandler(this.rbtnStatsLines_CheckedChanged);
            // 
            // btnStatsShuffleColors
            // 
            this.btnStatsShuffleColors.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStatsShuffleColors.Location = new System.Drawing.Point(436, 327);
            this.btnStatsShuffleColors.Name = "btnStatsShuffleColors";
            this.btnStatsShuffleColors.Size = new System.Drawing.Size(82, 22);
            this.btnStatsShuffleColors.TabIndex = 12;
            this.btnStatsShuffleColors.Text = "Shuffle colors";
            this.btnStatsShuffleColors.UseVisualStyleBackColor = true;
            this.btnStatsShuffleColors.Click += new System.EventHandler(this.btnStatsShuffleColors_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(292, 333);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Chart:";
            // 
            // cmbxStatsChart
            // 
            this.cmbxStatsChart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbxStatsChart.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxStatsChart.FormattingEnabled = true;
            this.cmbxStatsChart.Items.AddRange(new object[] {
            "Column",
            "Pie",
            "Doughnut",
            "Pyramid"});
            this.cmbxStatsChart.Location = new System.Drawing.Point(333, 327);
            this.cmbxStatsChart.Name = "cmbxStatsChart";
            this.cmbxStatsChart.Size = new System.Drawing.Size(97, 21);
            this.cmbxStatsChart.TabIndex = 10;
            this.cmbxStatsChart.SelectedIndexChanged += new System.EventHandler(this.cmbxStatsChart_SelectedIndexChanged);
            // 
            // lblStats
            // 
            this.lblStats.AutoSize = true;
            this.lblStats.Location = new System.Drawing.Point(7, 35);
            this.lblStats.Name = "lblStats";
            this.lblStats.Size = new System.Drawing.Size(177, 13);
            this.lblStats.TabIndex = 8;
            this.lblStats.Text = "Select an item from the list to the left";
            // 
            // chartStats
            // 
            this.chartStats.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chartStats.BackColor = System.Drawing.SystemColors.Control;
            chartArea2.Name = "ChartArea1";
            this.chartStats.ChartAreas.Add(chartArea2);
            this.chartStats.Location = new System.Drawing.Point(4, 79);
            this.chartStats.Name = "chartStats";
            this.chartStats.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series2.ChartArea = "ChartArea1";
            series2.Name = "Series1";
            series2.SmartLabelStyle.AllowOutsidePlotArea = System.Windows.Forms.DataVisualization.Charting.LabelOutsidePlotAreaStyle.Yes;
            this.chartStats.Series.Add(series2);
            this.chartStats.Size = new System.Drawing.Size(527, 245);
            this.chartStats.TabIndex = 7;
            this.chartStats.Text = "Stats";
            this.chartStats.Visible = false;
            // 
            // btnStatsClose
            // 
            this.btnStatsClose.Location = new System.Drawing.Point(4, 4);
            this.btnStatsClose.Name = "btnStatsClose";
            this.btnStatsClose.Size = new System.Drawing.Size(24, 24);
            this.btnStatsClose.TabIndex = 6;
            this.btnStatsClose.Text = "X";
            this.btnStatsClose.UseVisualStyleBackColor = true;
            this.btnStatsClose.Click += new System.EventHandler(this.btnStatsClose_Click);
            // 
            // lblStatsHeader
            // 
            this.lblStatsHeader.AutoSize = true;
            this.lblStatsHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatsHeader.Location = new System.Drawing.Point(30, 10);
            this.lblStatsHeader.Name = "lblStatsHeader";
            this.lblStatsHeader.Size = new System.Drawing.Size(36, 13);
            this.lblStatsHeader.TabIndex = 5;
            this.lblStatsHeader.Text = "Stats";
            // 
            // openFileBrowse
            // 
            this.openFileBrowse.Filter = "GameMaker Studio projects|*.project.gmx";
            // 
            // cbxRegexMultiLine
            // 
            this.cbxRegexMultiLine.AutoSize = true;
            this.cbxRegexMultiLine.Location = new System.Drawing.Point(215, 58);
            this.cbxRegexMultiLine.Name = "cbxRegexMultiLine";
            this.cbxRegexMultiLine.Size = new System.Drawing.Size(98, 17);
            this.cbxRegexMultiLine.TabIndex = 17;
            this.cbxRegexMultiLine.Text = "Regex Multiline";
            this.cbxRegexMultiLine.UseVisualStyleBackColor = true;
            this.cbxRegexMultiLine.Visible = false;
            // 
            // GMLpal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(735, 416);
            this.Controls.Add(this.container);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GMLpal";
            this.Text = "GMLpal";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.container.Panel1.ResumeLayout(false);
            this.container.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.container)).EndInit();
            this.container.ResumeLayout(false);
            this.tabView.ResumeLayout(false);
            this.tabView1.ResumeLayout(false);
            this.tabView2.ResumeLayout(false);
            this.panFind.ResumeLayout(false);
            this.panFind.PerformLayout();
            this.panFindSettings.ResumeLayout(false);
            this.panFindSettings.PerformLayout();
            this.tabView3.ResumeLayout(false);
            this.panStats.ResumeLayout(false);
            this.panStats.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartStats)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveChangesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reloadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton2;
        private System.Windows.Forms.ToolStripMenuItem findToolStripMenuItem;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton3;
        private System.Windows.Forms.ToolStripMenuItem statsToolStripMenuItem;
        private System.Windows.Forms.SplitContainer container;
        private System.Windows.Forms.TreeView treeProject;
        private System.Windows.Forms.OpenFileDialog openFileBrowse;
        private System.Windows.Forms.ImageList imageListTree;
        private System.Windows.Forms.TabControl tabView;
        private System.Windows.Forms.TabPage tabView1;
        private System.Windows.Forms.RichTextBox tbxCode;
        private System.Windows.Forms.TabPage tabView2;
        private System.Windows.Forms.Panel panFind;
        private System.Windows.Forms.CheckBox cbxFindCase;
        private System.Windows.Forms.CheckedListBox clbxFindProject;
        private System.Windows.Forms.Panel panFindSettings;
        private System.Windows.Forms.RadioButton rbtnFindSimple;
        private System.Windows.Forms.RadioButton rbtnFindAdvanced;
        private System.Windows.Forms.RadioButton rbtnFindSelected;
        private System.Windows.Forms.RadioButton rbtnFindProject;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.TreeView treeFind;
        private System.Windows.Forms.Button btnFindClose;
        private System.Windows.Forms.Label lblFindHeader;
        private System.Windows.Forms.Label lblFind;
        private System.Windows.Forms.TextBox tbxFind;
        private System.Windows.Forms.Label lblFindResult;
        private System.Windows.Forms.CheckBox cbxFindWord;
        private System.Windows.Forms.TextBox tbxReplace;
        private System.Windows.Forms.CheckBox cbxReplace;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.TabPage tabView3;
        private System.Windows.Forms.Panel panStats;
        private System.Windows.Forms.Button btnStatsClose;
        private System.Windows.Forms.Label lblStatsHeader;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartStats;
        private System.Windows.Forms.Label lblStats;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbxStatsChart;
        private System.Windows.Forms.Button btnStatsShuffleColors;
        private System.Windows.Forms.RadioButton rbtnStatsSize;
        private System.Windows.Forms.RadioButton rbtnStatsLines;
        private System.Windows.Forms.CheckBox cbxStatsNamesOnly;
        private System.Windows.Forms.RadioButton rbtnStatsItems;
        private System.Windows.Forms.CheckBox cbxRegexMultiLine;
    }
}

