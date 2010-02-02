namespace Spritimator_Tao
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.spritesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alphaBlendingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.exportDialog = new System.Windows.Forms.SaveFileDialog();
            this.importDialog = new System.Windows.Forms.OpenFileDialog();
            this.fileAddFrames = new System.Windows.Forms.OpenFileDialog();
            this.vSheetScroll = new System.Windows.Forms.VScrollBar();
            this.hSheetScroll = new System.Windows.Forms.HScrollBar();
            this.tZoom = new System.Windows.Forms.TrackBar();
            this.lDebug = new System.Windows.Forms.Label();
            this.cTextures = new System.Windows.Forms.ComboBox();
            this.lDebug2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bEditAnimSeq = new System.Windows.Forms.Button();
            this.cDeleteAnimSeq = new System.Windows.Forms.Button();
            this.bNewAnimSeq = new System.Windows.Forms.Button();
            this.cAnimSequence = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tFrameXSpacing = new System.Windows.Forms.TextBox();
            this.lFrameXSpacing = new System.Windows.Forms.Label();
            this.tFrameNumber = new System.Windows.Forms.TextBox();
            this.lFrameNumber = new System.Windows.Forms.Label();
            this.cFrameMulti = new System.Windows.Forms.CheckBox();
            this.cFrameEditMode = new System.Windows.Forms.CheckBox();
            this.cFrameLockWidth = new System.Windows.Forms.CheckBox();
            this.cFrameLockX = new System.Windows.Forms.CheckBox();
            this.bFrameAddFromFile = new System.Windows.Forms.Button();
            this.cFrameLockHeight = new System.Windows.Forms.CheckBox();
            this.cFrameLockY = new System.Windows.Forms.CheckBox();
            this.bFrameDelete = new System.Windows.Forms.Button();
            this.bApplyFrame = new System.Windows.Forms.Button();
            this.bPreviewFrame = new System.Windows.Forms.Button();
            this.bCreateFrame = new System.Windows.Forms.Button();
            this.cFrameAnchorMid = new System.Windows.Forms.CheckBox();
            this.cVFlip = new System.Windows.Forms.CheckBox();
            this.cHFlip = new System.Windows.Forms.CheckBox();
            this.tFrameRotation = new System.Windows.Forms.TextBox();
            this.tFrameTime = new System.Windows.Forms.TextBox();
            this.tFrameYScale = new System.Windows.Forms.TextBox();
            this.tFrameXScale = new System.Windows.Forms.TextBox();
            this.tFrameYAnchor = new System.Windows.Forms.TextBox();
            this.tFrameXAnchor = new System.Windows.Forms.TextBox();
            this.tFrameHeight = new System.Windows.Forms.TextBox();
            this.tFrameWidth = new System.Windows.Forms.TextBox();
            this.tFrameYSource = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tFrameXSource = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lZoom = new System.Windows.Forms.Label();
            this.bPlay = new System.Windows.Forms.Button();
            this.vLineScroll = new System.Windows.Forms.VScrollBar();
            this.bFrameNext = new System.Windows.Forms.Button();
            this.bFramePrevious = new System.Windows.Forms.Button();
            this.sheetGLControl = new Tao.Platform.Windows.SimpleOpenGlControl();
            this.hLineScroll = new System.Windows.Forms.HScrollBar();
            this.propertyGrid1 = new System.Windows.Forms.PropertyGrid();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tZoom)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.spritesToolStripMenuItem,
            this.editToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1008, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "Menu";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.importToolStripMenuItem,
            this.exportToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.newToolStripMenuItem.Text = "&New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.openToolStripMenuItem.Text = "&Open Texture";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // importToolStripMenuItem
            // 
            this.importToolStripMenuItem.Name = "importToolStripMenuItem";
            this.importToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.importToolStripMenuItem.Text = "&Import";
            this.importToolStripMenuItem.Click += new System.EventHandler(this.importToolStripMenuItem_Click);
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.Enabled = false;
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            this.exportToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.exportToolStripMenuItem.Text = "Ex&port";
            this.exportToolStripMenuItem.Click += new System.EventHandler(this.exportToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // spritesToolStripMenuItem
            // 
            this.spritesToolStripMenuItem.Name = "spritesToolStripMenuItem";
            this.spritesToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.spritesToolStripMenuItem.Text = "Sprites";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "&Edit";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.alphaBlendingToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "&View";
            // 
            // alphaBlendingToolStripMenuItem
            // 
            this.alphaBlendingToolStripMenuItem.Checked = true;
            this.alphaBlendingToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.alphaBlendingToolStripMenuItem.Name = "alphaBlendingToolStripMenuItem";
            this.alphaBlendingToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.alphaBlendingToolStripMenuItem.Text = "Alpha Blending";
            this.alphaBlendingToolStripMenuItem.CheckedChanged += new System.EventHandler(this.chkAlpha_CheckedChanged);
            this.alphaBlendingToolStripMenuItem.Click += new System.EventHandler(this.alphaBlendingToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem1});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.aboutToolStripMenuItem.Text = "&Help";
            // 
            // aboutToolStripMenuItem1
            // 
            this.aboutToolStripMenuItem1.Name = "aboutToolStripMenuItem1";
            this.aboutToolStripMenuItem1.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem1.Text = "&About";
            this.aboutToolStripMenuItem1.Click += new System.EventHandler(this.aboutToolStripMenuItem1_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 15;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // exportDialog
            // 
            this.exportDialog.DefaultExt = "xml";
            this.exportDialog.FileName = "Animation.txt";
            this.exportDialog.Filter = "Text Files (*.txt)|*.txt|XML Files (*.xml)|*.xml|All Files (*.*)|*.*";
            // 
            // importDialog
            // 
            this.importDialog.DefaultExt = "xml";
            this.importDialog.FileName = "Animation.txt";
            this.importDialog.Filter = "Text Files (*.txt)|*.txt|XML Files (*.xml)|*.xml|All Files (*.*)|*.*";
            // 
            // fileAddFrames
            // 
            this.fileAddFrames.Multiselect = true;
            // 
            // vSheetScroll
            // 
            this.vSheetScroll.Enabled = false;
            this.vSheetScroll.Location = new System.Drawing.Point(620, 30);
            this.vSheetScroll.Name = "vSheetScroll";
            this.vSheetScroll.Size = new System.Drawing.Size(20, 415);
            this.vSheetScroll.TabIndex = 3;
            this.vSheetScroll.Scroll += new System.Windows.Forms.ScrollEventHandler(this.vSheetScroll_Scroll);
            // 
            // hSheetScroll
            // 
            this.hSheetScroll.Enabled = false;
            this.hSheetScroll.Location = new System.Drawing.Point(2, 428);
            this.hSheetScroll.Name = "hSheetScroll";
            this.hSheetScroll.Size = new System.Drawing.Size(613, 19);
            this.hSheetScroll.TabIndex = 4;
            this.hSheetScroll.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hSheetScroll_Scroll);
            // 
            // tZoom
            // 
            this.tZoom.Location = new System.Drawing.Point(531, 450);
            this.tZoom.Maximum = 8;
            this.tZoom.Minimum = 1;
            this.tZoom.Name = "tZoom";
            this.tZoom.Size = new System.Drawing.Size(82, 45);
            this.tZoom.TabIndex = 5;
            this.tZoom.Value = 1;
            this.tZoom.Scroll += new System.EventHandler(this.tZoom_Scroll);
            // 
            // lDebug
            // 
            this.lDebug.AutoSize = true;
            this.lDebug.Location = new System.Drawing.Point(387, 450);
            this.lDebug.Name = "lDebug";
            this.lDebug.Size = new System.Drawing.Size(77, 13);
            this.lDebug.TabIndex = 8;
            this.lDebug.Text = "Cursor Position";
            // 
            // cTextures
            // 
            this.cTextures.FormattingEnabled = true;
            this.cTextures.Location = new System.Drawing.Point(5, 450);
            this.cTextures.Name = "cTextures";
            this.cTextures.Size = new System.Drawing.Size(378, 21);
            this.cTextures.TabIndex = 7;
            this.cTextures.Text = "Current Texture";
            this.cTextures.SelectedIndexChanged += new System.EventHandler(this.cTextures_SelectedIndexChanged);
            // 
            // lDebug2
            // 
            this.lDebug2.AutoSize = true;
            this.lDebug2.Location = new System.Drawing.Point(387, 473);
            this.lDebug2.Name = "lDebug2";
            this.lDebug2.Size = new System.Drawing.Size(37, 13);
            this.lDebug2.TabIndex = 9;
            this.lDebug2.Text = "Status";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bEditAnimSeq);
            this.groupBox1.Controls.Add(this.cDeleteAnimSeq);
            this.groupBox1.Controls.Add(this.bNewAnimSeq);
            this.groupBox1.Controls.Add(this.cAnimSequence);
            this.groupBox1.Location = new System.Drawing.Point(693, 391);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(253, 104);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Animation Sequences";
            // 
            // bEditAnimSeq
            // 
            this.bEditAnimSeq.Location = new System.Drawing.Point(88, 58);
            this.bEditAnimSeq.Name = "bEditAnimSeq";
            this.bEditAnimSeq.Size = new System.Drawing.Size(69, 24);
            this.bEditAnimSeq.TabIndex = 3;
            this.bEditAnimSeq.Text = "Edit";
            this.bEditAnimSeq.UseVisualStyleBackColor = true;
            this.bEditAnimSeq.Click += new System.EventHandler(this.bEditAnimSeq_Click);
            // 
            // cDeleteAnimSeq
            // 
            this.cDeleteAnimSeq.Location = new System.Drawing.Point(167, 58);
            this.cDeleteAnimSeq.Name = "cDeleteAnimSeq";
            this.cDeleteAnimSeq.Size = new System.Drawing.Size(68, 24);
            this.cDeleteAnimSeq.TabIndex = 2;
            this.cDeleteAnimSeq.Text = "Delete";
            this.cDeleteAnimSeq.UseVisualStyleBackColor = true;
            this.cDeleteAnimSeq.Click += new System.EventHandler(this.cDeleteAnimSeq_Click);
            // 
            // bNewAnimSeq
            // 
            this.bNewAnimSeq.Location = new System.Drawing.Point(14, 58);
            this.bNewAnimSeq.Name = "bNewAnimSeq";
            this.bNewAnimSeq.Size = new System.Drawing.Size(65, 23);
            this.bNewAnimSeq.TabIndex = 1;
            this.bNewAnimSeq.Text = "New";
            this.bNewAnimSeq.UseVisualStyleBackColor = true;
            this.bNewAnimSeq.Click += new System.EventHandler(this.bNewAnimSeq_Click);
            // 
            // cAnimSequence
            // 
            this.cAnimSequence.FormattingEnabled = true;
            this.cAnimSequence.Location = new System.Drawing.Point(14, 31);
            this.cAnimSequence.Name = "cAnimSequence";
            this.cAnimSequence.Size = new System.Drawing.Size(221, 21);
            this.cAnimSequence.TabIndex = 0;
            this.cAnimSequence.SelectedIndexChanged += new System.EventHandler(this.cAnimSequence_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tFrameXSpacing);
            this.groupBox2.Controls.Add(this.lFrameXSpacing);
            this.groupBox2.Controls.Add(this.tFrameNumber);
            this.groupBox2.Controls.Add(this.lFrameNumber);
            this.groupBox2.Controls.Add(this.cFrameMulti);
            this.groupBox2.Controls.Add(this.cFrameEditMode);
            this.groupBox2.Controls.Add(this.cFrameLockWidth);
            this.groupBox2.Controls.Add(this.cFrameLockX);
            this.groupBox2.Controls.Add(this.bFrameAddFromFile);
            this.groupBox2.Controls.Add(this.cFrameLockHeight);
            this.groupBox2.Controls.Add(this.cFrameLockY);
            this.groupBox2.Controls.Add(this.bFrameDelete);
            this.groupBox2.Controls.Add(this.bApplyFrame);
            this.groupBox2.Controls.Add(this.bPreviewFrame);
            this.groupBox2.Controls.Add(this.bCreateFrame);
            this.groupBox2.Controls.Add(this.cFrameAnchorMid);
            this.groupBox2.Controls.Add(this.cVFlip);
            this.groupBox2.Controls.Add(this.cHFlip);
            this.groupBox2.Controls.Add(this.tFrameRotation);
            this.groupBox2.Controls.Add(this.tFrameTime);
            this.groupBox2.Controls.Add(this.tFrameYScale);
            this.groupBox2.Controls.Add(this.tFrameXScale);
            this.groupBox2.Controls.Add(this.tFrameYAnchor);
            this.groupBox2.Controls.Add(this.tFrameXAnchor);
            this.groupBox2.Controls.Add(this.tFrameHeight);
            this.groupBox2.Controls.Add(this.tFrameWidth);
            this.groupBox2.Controls.Add(this.tFrameYSource);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.tFrameXSource);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(12, 501);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(578, 189);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Current Frame";
            // 
            // tFrameXSpacing
            // 
            this.tFrameXSpacing.Enabled = false;
            this.tFrameXSpacing.Location = new System.Drawing.Point(370, 165);
            this.tFrameXSpacing.Name = "tFrameXSpacing";
            this.tFrameXSpacing.Size = new System.Drawing.Size(42, 20);
            this.tFrameXSpacing.TabIndex = 40;
            this.tFrameXSpacing.Text = "0";
            this.tFrameXSpacing.TextChanged += new System.EventHandler(this.tFrameXSpacing_TextChanged);
            // 
            // lFrameXSpacing
            // 
            this.lFrameXSpacing.AutoSize = true;
            this.lFrameXSpacing.Enabled = false;
            this.lFrameXSpacing.Location = new System.Drawing.Point(295, 168);
            this.lFrameXSpacing.Name = "lFrameXSpacing";
            this.lFrameXSpacing.Size = new System.Drawing.Size(56, 13);
            this.lFrameXSpacing.TabIndex = 39;
            this.lFrameXSpacing.Text = "X Spacing";
            // 
            // tFrameNumber
            // 
            this.tFrameNumber.Enabled = false;
            this.tFrameNumber.Location = new System.Drawing.Point(233, 164);
            this.tFrameNumber.Name = "tFrameNumber";
            this.tFrameNumber.Size = new System.Drawing.Size(50, 20);
            this.tFrameNumber.TabIndex = 38;
            this.tFrameNumber.Text = "1";
            this.tFrameNumber.TextChanged += new System.EventHandler(this.tFrameNumber_TextChanged);
            // 
            // lFrameNumber
            // 
            this.lFrameNumber.AutoSize = true;
            this.lFrameNumber.Enabled = false;
            this.lFrameNumber.Location = new System.Drawing.Point(188, 168);
            this.lFrameNumber.Name = "lFrameNumber";
            this.lFrameNumber.Size = new System.Drawing.Size(39, 13);
            this.lFrameNumber.TabIndex = 37;
            this.lFrameNumber.Text = "# Tiles";
            // 
            // cFrameMulti
            // 
            this.cFrameMulti.AutoSize = true;
            this.cFrameMulti.Location = new System.Drawing.Point(111, 166);
            this.cFrameMulti.Name = "cFrameMulti";
            this.cFrameMulti.Size = new System.Drawing.Size(68, 17);
            this.cFrameMulti.TabIndex = 36;
            this.cFrameMulti.Text = "Multi-Tile";
            this.cFrameMulti.UseVisualStyleBackColor = true;
            this.cFrameMulti.CheckedChanged += new System.EventHandler(this.cFrameMulti_CheckedChanged);
            // 
            // cFrameEditMode
            // 
            this.cFrameEditMode.AutoSize = true;
            this.cFrameEditMode.Location = new System.Drawing.Point(15, 167);
            this.cFrameEditMode.Name = "cFrameEditMode";
            this.cFrameEditMode.Size = new System.Drawing.Size(74, 17);
            this.cFrameEditMode.TabIndex = 35;
            this.cFrameEditMode.Text = "Edit Mode";
            this.cFrameEditMode.UseVisualStyleBackColor = true;
            this.cFrameEditMode.CheckedChanged += new System.EventHandler(this.cFrameEditMode_CheckedChanged);
            // 
            // cFrameLockWidth
            // 
            this.cFrameLockWidth.AutoSize = true;
            this.cFrameLockWidth.Location = new System.Drawing.Point(220, 25);
            this.cFrameLockWidth.Name = "cFrameLockWidth";
            this.cFrameLockWidth.Size = new System.Drawing.Size(15, 14);
            this.cFrameLockWidth.TabIndex = 34;
            this.cFrameLockWidth.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.cFrameLockWidth.UseVisualStyleBackColor = true;
            // 
            // cFrameLockX
            // 
            this.cFrameLockX.AutoSize = true;
            this.cFrameLockX.Location = new System.Drawing.Point(106, 25);
            this.cFrameLockX.Name = "cFrameLockX";
            this.cFrameLockX.Size = new System.Drawing.Size(15, 14);
            this.cFrameLockX.TabIndex = 33;
            this.cFrameLockX.UseVisualStyleBackColor = true;
            // 
            // bFrameAddFromFile
            // 
            this.bFrameAddFromFile.Location = new System.Drawing.Point(287, 121);
            this.bFrameAddFromFile.Name = "bFrameAddFromFile";
            this.bFrameAddFromFile.Size = new System.Drawing.Size(63, 36);
            this.bFrameAddFromFile.TabIndex = 32;
            this.bFrameAddFromFile.Text = "Add From File(s)";
            this.bFrameAddFromFile.UseVisualStyleBackColor = true;
            this.bFrameAddFromFile.Click += new System.EventHandler(this.bFrameAddFromFile_Click);
            // 
            // cFrameLockHeight
            // 
            this.cFrameLockHeight.AutoSize = true;
            this.cFrameLockHeight.Location = new System.Drawing.Point(220, 55);
            this.cFrameLockHeight.Name = "cFrameLockHeight";
            this.cFrameLockHeight.Size = new System.Drawing.Size(15, 14);
            this.cFrameLockHeight.TabIndex = 31;
            this.cFrameLockHeight.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.cFrameLockHeight.UseVisualStyleBackColor = true;
            // 
            // cFrameLockY
            // 
            this.cFrameLockY.AutoSize = true;
            this.cFrameLockY.Location = new System.Drawing.Point(106, 55);
            this.cFrameLockY.Name = "cFrameLockY";
            this.cFrameLockY.Size = new System.Drawing.Size(15, 14);
            this.cFrameLockY.TabIndex = 30;
            this.cFrameLockY.UseVisualStyleBackColor = true;
            // 
            // bFrameDelete
            // 
            this.bFrameDelete.Enabled = false;
            this.bFrameDelete.Location = new System.Drawing.Point(146, 119);
            this.bFrameDelete.Name = "bFrameDelete";
            this.bFrameDelete.Size = new System.Drawing.Size(59, 37);
            this.bFrameDelete.TabIndex = 29;
            this.bFrameDelete.Text = "Delete";
            this.bFrameDelete.UseVisualStyleBackColor = true;
            this.bFrameDelete.Click += new System.EventHandler(this.bFrameDelete_Click);
            // 
            // bApplyFrame
            // 
            this.bApplyFrame.Enabled = false;
            this.bApplyFrame.Location = new System.Drawing.Point(211, 120);
            this.bApplyFrame.Name = "bApplyFrame";
            this.bApplyFrame.Size = new System.Drawing.Size(65, 37);
            this.bApplyFrame.TabIndex = 28;
            this.bApplyFrame.Text = "Apply to Selected";
            this.bApplyFrame.UseVisualStyleBackColor = true;
            this.bApplyFrame.Click += new System.EventHandler(this.bApplyFrame_Click);
            // 
            // bPreviewFrame
            // 
            this.bPreviewFrame.Enabled = false;
            this.bPreviewFrame.Location = new System.Drawing.Point(81, 120);
            this.bPreviewFrame.Name = "bPreviewFrame";
            this.bPreviewFrame.Size = new System.Drawing.Size(59, 37);
            this.bPreviewFrame.TabIndex = 27;
            this.bPreviewFrame.Text = "Preview";
            this.bPreviewFrame.UseVisualStyleBackColor = true;
            this.bPreviewFrame.Click += new System.EventHandler(this.bPreviewFrame_Click);
            // 
            // bCreateFrame
            // 
            this.bCreateFrame.Location = new System.Drawing.Point(9, 120);
            this.bCreateFrame.Name = "bCreateFrame";
            this.bCreateFrame.Size = new System.Drawing.Size(66, 37);
            this.bCreateFrame.TabIndex = 26;
            this.bCreateFrame.Text = "Create";
            this.bCreateFrame.UseVisualStyleBackColor = true;
            this.bCreateFrame.Click += new System.EventHandler(this.bCreateFrame_Click);
            // 
            // cFrameAnchorMid
            // 
            this.cFrameAnchorMid.AutoSize = true;
            this.cFrameAnchorMid.Checked = true;
            this.cFrameAnchorMid.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cFrameAnchorMid.Location = new System.Drawing.Point(258, 87);
            this.cFrameAnchorMid.Name = "cFrameAnchorMid";
            this.cFrameAnchorMid.Size = new System.Drawing.Size(92, 17);
            this.cFrameAnchorMid.TabIndex = 25;
            this.cFrameAnchorMid.Text = "Anchor to Mid";
            this.cFrameAnchorMid.UseVisualStyleBackColor = true;
            this.cFrameAnchorMid.CheckedChanged += new System.EventHandler(this.cFrameAnchorMid_CheckedChanged);
            // 
            // cVFlip
            // 
            this.cVFlip.AutoSize = true;
            this.cVFlip.Location = new System.Drawing.Point(448, 53);
            this.cVFlip.Name = "cVFlip";
            this.cVFlip.Size = new System.Drawing.Size(80, 17);
            this.cVFlip.TabIndex = 24;
            this.cVFlip.Text = "Vertical Flip";
            this.cVFlip.UseVisualStyleBackColor = true;
            // 
            // cHFlip
            // 
            this.cHFlip.AutoSize = true;
            this.cHFlip.Location = new System.Drawing.Point(448, 24);
            this.cHFlip.Name = "cHFlip";
            this.cHFlip.Size = new System.Drawing.Size(92, 17);
            this.cHFlip.TabIndex = 23;
            this.cHFlip.Text = "Horizontal Flip";
            this.cHFlip.UseVisualStyleBackColor = true;
            // 
            // tFrameRotation
            // 
            this.tFrameRotation.Enabled = false;
            this.tFrameRotation.Location = new System.Drawing.Point(178, 82);
            this.tFrameRotation.MaxLength = 20;
            this.tFrameRotation.Name = "tFrameRotation";
            this.tFrameRotation.Size = new System.Drawing.Size(36, 20);
            this.tFrameRotation.TabIndex = 22;
            this.tFrameRotation.Text = "0";
            // 
            // tFrameTime
            // 
            this.tFrameTime.Location = new System.Drawing.Point(74, 85);
            this.tFrameTime.MaxLength = 20;
            this.tFrameTime.Name = "tFrameTime";
            this.tFrameTime.Size = new System.Drawing.Size(36, 20);
            this.tFrameTime.TabIndex = 21;
            this.tFrameTime.Text = ".2";
            // 
            // tFrameYScale
            // 
            this.tFrameYScale.Location = new System.Drawing.Point(397, 52);
            this.tFrameYScale.MaxLength = 20;
            this.tFrameYScale.Name = "tFrameYScale";
            this.tFrameYScale.Size = new System.Drawing.Size(36, 20);
            this.tFrameYScale.TabIndex = 20;
            this.tFrameYScale.Text = "1.0";
            // 
            // tFrameXScale
            // 
            this.tFrameXScale.Location = new System.Drawing.Point(397, 20);
            this.tFrameXScale.MaxLength = 20;
            this.tFrameXScale.Name = "tFrameXScale";
            this.tFrameXScale.Size = new System.Drawing.Size(36, 20);
            this.tFrameXScale.TabIndex = 19;
            this.tFrameXScale.Text = "1.0";
            // 
            // tFrameYAnchor
            // 
            this.tFrameYAnchor.Location = new System.Drawing.Point(305, 52);
            this.tFrameYAnchor.MaxLength = 20;
            this.tFrameYAnchor.Name = "tFrameYAnchor";
            this.tFrameYAnchor.Size = new System.Drawing.Size(36, 20);
            this.tFrameYAnchor.TabIndex = 18;
            // 
            // tFrameXAnchor
            // 
            this.tFrameXAnchor.Location = new System.Drawing.Point(305, 19);
            this.tFrameXAnchor.MaxLength = 20;
            this.tFrameXAnchor.Name = "tFrameXAnchor";
            this.tFrameXAnchor.Size = new System.Drawing.Size(36, 20);
            this.tFrameXAnchor.TabIndex = 17;
            // 
            // tFrameHeight
            // 
            this.tFrameHeight.Location = new System.Drawing.Point(178, 52);
            this.tFrameHeight.MaxLength = 10;
            this.tFrameHeight.Name = "tFrameHeight";
            this.tFrameHeight.Size = new System.Drawing.Size(36, 20);
            this.tFrameHeight.TabIndex = 16;
            this.tFrameHeight.Text = "0";
            this.tFrameHeight.TextChanged += new System.EventHandler(this.tFrame_TextChanged);
            this.tFrameHeight.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numberFilter_KeyPress);
            // 
            // tFrameWidth
            // 
            this.tFrameWidth.Location = new System.Drawing.Point(178, 19);
            this.tFrameWidth.MaxLength = 10;
            this.tFrameWidth.Name = "tFrameWidth";
            this.tFrameWidth.Size = new System.Drawing.Size(36, 20);
            this.tFrameWidth.TabIndex = 15;
            this.tFrameWidth.Text = "0";
            this.tFrameWidth.TextChanged += new System.EventHandler(this.tFrame_TextChanged);
            this.tFrameWidth.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numberFilter_KeyPress);
            // 
            // tFrameYSource
            // 
            this.tFrameYSource.Location = new System.Drawing.Point(63, 52);
            this.tFrameYSource.MaxLength = 10;
            this.tFrameYSource.Name = "tFrameYSource";
            this.tFrameYSource.Size = new System.Drawing.Size(36, 20);
            this.tFrameYSource.TabIndex = 14;
            this.tFrameYSource.Text = "0";
            this.tFrameYSource.TextChanged += new System.EventHandler(this.tFrame_TextChanged);
            this.tFrameYSource.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numberFilter_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 88);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 13);
            this.label10.TabIndex = 10;
            this.label10.Text = "Frame Time";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Enabled = false;
            this.label9.Location = new System.Drawing.Point(127, 88);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "Rotation";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(347, 52);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Y Scale";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(347, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "X Scale";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(248, 52);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Y Anchor";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(248, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "X Anchor";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(127, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Height";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Y Source";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(127, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Width";
            // 
            // tFrameXSource
            // 
            this.tFrameXSource.Location = new System.Drawing.Point(63, 19);
            this.tFrameXSource.MaxLength = 10;
            this.tFrameXSource.Name = "tFrameXSource";
            this.tFrameXSource.Size = new System.Drawing.Size(36, 20);
            this.tFrameXSource.TabIndex = 1;
            this.tFrameXSource.Text = "0";
            this.tFrameXSource.TextChanged += new System.EventHandler(this.tFrame_TextChanged);
            this.tFrameXSource.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numberFilter_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "X Source";
            // 
            // lZoom
            // 
            this.lZoom.AutoSize = true;
            this.lZoom.Location = new System.Drawing.Point(556, 475);
            this.lZoom.Name = "lZoom";
            this.lZoom.Size = new System.Drawing.Size(34, 13);
            this.lZoom.TabIndex = 6;
            this.lZoom.Text = "Zoom";
            // 
            // bPlay
            // 
            this.bPlay.Location = new System.Drawing.Point(797, 348);
            this.bPlay.Name = "bPlay";
            this.bPlay.Size = new System.Drawing.Size(63, 19);
            this.bPlay.TabIndex = 14;
            this.bPlay.Text = "Play";
            this.bPlay.UseVisualStyleBackColor = true;
            this.bPlay.Click += new System.EventHandler(this.bPlay_Click);
            // 
            // vLineScroll
            // 
            this.vLineScroll.Location = new System.Drawing.Point(978, 30);
            this.vLineScroll.Minimum = -100;
            this.vLineScroll.Name = "vLineScroll";
            this.vLineScroll.Size = new System.Drawing.Size(21, 280);
            this.vLineScroll.TabIndex = 4;
            this.vLineScroll.Value = 100;
            this.vLineScroll.Scroll += new System.Windows.Forms.ScrollEventHandler(this.vLineScroll_Scroll);
            // 
            // bFrameNext
            // 
            this.bFrameNext.Location = new System.Drawing.Point(867, 348);
            this.bFrameNext.Name = "bFrameNext";
            this.bFrameNext.Size = new System.Drawing.Size(34, 19);
            this.bFrameNext.TabIndex = 15;
            this.bFrameNext.Text = ">>";
            this.bFrameNext.UseVisualStyleBackColor = true;
            this.bFrameNext.Click += new System.EventHandler(this.bFrameNext_Click);
            // 
            // bFramePrevious
            // 
            this.bFramePrevious.Location = new System.Drawing.Point(757, 348);
            this.bFramePrevious.Name = "bFramePrevious";
            this.bFramePrevious.Size = new System.Drawing.Size(34, 19);
            this.bFramePrevious.TabIndex = 16;
            this.bFramePrevious.Text = "<<";
            this.bFramePrevious.UseVisualStyleBackColor = true;
            this.bFramePrevious.Click += new System.EventHandler(this.bFramePrevious_Click);
            // 
            // sheetGLControl
            // 
            this.sheetGLControl.AccumBits = ((byte)(0));
            this.sheetGLControl.AutoCheckErrors = false;
            this.sheetGLControl.AutoFinish = false;
            this.sheetGLControl.AutoMakeCurrent = true;
            this.sheetGLControl.AutoSwapBuffers = true;
            this.sheetGLControl.BackColor = System.Drawing.Color.Black;
            this.sheetGLControl.ColorBits = ((byte)(32));
            this.sheetGLControl.DepthBits = ((byte)(16));
            this.sheetGLControl.Location = new System.Drawing.Point(2, 27);
            this.sheetGLControl.Name = "sheetGLControl";
            this.sheetGLControl.Size = new System.Drawing.Size(1024, 700);
            this.sheetGLControl.StencilBits = ((byte)(0));
            this.sheetGLControl.TabIndex = 0;
            this.sheetGLControl.Load += new System.EventHandler(this.simpleOpenGlControl1_Load);
            this.sheetGLControl.Paint += new System.Windows.Forms.PaintEventHandler(this.simpleOpenGlControl1_Paint);
            this.sheetGLControl.MouseMove += new System.Windows.Forms.MouseEventHandler(this.sheetGLControl_MouseMove);
            this.sheetGLControl.MouseDown += new System.Windows.Forms.MouseEventHandler(this.sheetGLControl_MouseDown);
            this.sheetGLControl.MouseUp += new System.Windows.Forms.MouseEventHandler(this.sheetGLControl_MouseUp);
            // 
            // hLineScroll
            // 
            this.hLineScroll.Location = new System.Drawing.Point(670, 316);
            this.hLineScroll.Minimum = -100;
            this.hLineScroll.Name = "hLineScroll";
            this.hLineScroll.Size = new System.Drawing.Size(300, 18);
            this.hLineScroll.TabIndex = 17;
            this.hLineScroll.Value = 100;
            this.hLineScroll.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hLineScroll_Scroll);
            // 
            // propertyGrid1
            // 
            this.propertyGrid1.Location = new System.Drawing.Point(641, 519);
            this.propertyGrid1.Name = "propertyGrid1";
            this.propertyGrid1.Size = new System.Drawing.Size(328, 147);
            this.propertyGrid1.TabIndex = 18;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 702);
            this.Controls.Add(this.propertyGrid1);
            this.Controls.Add(this.hLineScroll);
            this.Controls.Add(this.bFramePrevious);
            this.Controls.Add(this.bFrameNext);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.vLineScroll);
            this.Controls.Add(this.bPlay);
            this.Controls.Add(this.lZoom);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lDebug2);
            this.Controls.Add(this.cTextures);
            this.Controls.Add(this.lDebug);
            this.Controls.Add(this.tZoom);
            this.Controls.Add(this.hSheetScroll);
            this.Controls.Add(this.vSheetScroll);
            this.Controls.Add(this.sheetGLControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Spritimator";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResizeEnd += new System.EventHandler(this.Form1_ResizeEnd);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tZoom)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem importToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alphaBlendingToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.SaveFileDialog exportDialog;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog importDialog;
        private System.Windows.Forms.OpenFileDialog fileAddFrames;
        private System.Windows.Forms.ToolStripMenuItem spritesToolStripMenuItem;
        private System.Windows.Forms.VScrollBar vSheetScroll;
        private System.Windows.Forms.HScrollBar hSheetScroll;
        private System.Windows.Forms.TrackBar tZoom;
        private System.Windows.Forms.Label lDebug;
        private System.Windows.Forms.ComboBox cTextures;
        private System.Windows.Forms.Label lDebug2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button bEditAnimSeq;
        private System.Windows.Forms.Button cDeleteAnimSeq;
        private System.Windows.Forms.Button bNewAnimSeq;
        private System.Windows.Forms.ComboBox cAnimSequence;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox cFrameLockWidth;
        private System.Windows.Forms.CheckBox cFrameLockX;
        private System.Windows.Forms.Button bFrameAddFromFile;
        private System.Windows.Forms.CheckBox cFrameLockHeight;
        private System.Windows.Forms.CheckBox cFrameLockY;
        private System.Windows.Forms.Button bFrameDelete;
        private System.Windows.Forms.Button bApplyFrame;
        private System.Windows.Forms.Button bPreviewFrame;
        private System.Windows.Forms.Button bCreateFrame;
        private System.Windows.Forms.CheckBox cFrameAnchorMid;
        private System.Windows.Forms.CheckBox cVFlip;
        private System.Windows.Forms.CheckBox cHFlip;
        private System.Windows.Forms.TextBox tFrameRotation;
        private System.Windows.Forms.TextBox tFrameTime;
        private System.Windows.Forms.TextBox tFrameYScale;
        private System.Windows.Forms.TextBox tFrameXScale;
        private System.Windows.Forms.TextBox tFrameYAnchor;
        private System.Windows.Forms.TextBox tFrameXAnchor;
        private System.Windows.Forms.TextBox tFrameHeight;
        private System.Windows.Forms.TextBox tFrameWidth;
        private System.Windows.Forms.TextBox tFrameYSource;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tFrameXSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lZoom;
        private System.Windows.Forms.Button bPlay;
        private System.Windows.Forms.VScrollBar vLineScroll;
        private System.Windows.Forms.CheckBox cFrameEditMode;
        private System.Windows.Forms.CheckBox cFrameMulti;
        private System.Windows.Forms.TextBox tFrameXSpacing;
        private System.Windows.Forms.Label lFrameXSpacing;
        private System.Windows.Forms.TextBox tFrameNumber;
        private System.Windows.Forms.Label lFrameNumber;
        private System.Windows.Forms.Button bFrameNext;
        private System.Windows.Forms.Button bFramePrevious;
        private Tao.Platform.Windows.SimpleOpenGlControl sheetGLControl;
        private System.Windows.Forms.HScrollBar hLineScroll;
        private System.Windows.Forms.PropertyGrid propertyGrid1;
    }
}

