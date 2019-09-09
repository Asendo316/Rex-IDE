namespace Rex
{
    partial class RexEditor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RexEditor));
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.Mm_Files = new System.Windows.Forms.ToolStripMenuItem();
            this.file_New = new System.Windows.Forms.ToolStripMenuItem();
            this.file_Open = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.file_Save = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.file_Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.Mm_Edit = new System.Windows.Forms.ToolStripMenuItem();
            this.edit_Undo = new System.Windows.Forms.ToolStripMenuItem();
            this.edit_Redo = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.edit_Cut = new System.Windows.Forms.ToolStripMenuItem();
            this.edit_Copy = new System.Windows.Forms.ToolStripMenuItem();
            this.edit_Paste = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.edit_SelectAll = new System.Windows.Forms.ToolStripMenuItem();
            this.Mm_Tools = new System.Windows.Forms.ToolStripMenuItem();
            this.customizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Tools = new System.Windows.Forms.ToolStrip();
            this.tb_New = new System.Windows.Forms.ToolStripButton();
            this.tb_Open = new System.Windows.Forms.ToolStripButton();
            this.tb_Save = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.tb_Cut = new System.Windows.Forms.ToolStripButton();
            this.tb_Copy = new System.Windows.Forms.ToolStripButton();
            this.tb_Paste = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.tb_Undo = new System.Windows.Forms.ToolStripButton();
            this.tb_Redo = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.build = new System.Windows.Forms.ToolStripButton();
            this.tb_Start = new System.Windows.Forms.ToolStripButton();
            this.stop = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.github = new System.Windows.Forms.Label();
            this.skype = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.illustrator = new System.Windows.Forms.Label();
            this.Document = new System.Windows.Forms.RichTextBox();
            this.rc_Menu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.rc_Undo = new System.Windows.Forms.ToolStripMenuItem();
            this.rc_Redo = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator12 = new System.Windows.Forms.ToolStripSeparator();
            this.rc_Cut = new System.Windows.Forms.ToolStripMenuItem();
            this.rc_Copy = new System.Windows.Forms.ToolStripMenuItem();
            this.rc_Paste = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.rc_Sketch = new System.Windows.Forms.ToolStripMenuItem();
            this.rc_Share = new System.Windows.Forms.ToolStripMenuItem();
            this.rc_About = new System.Windows.Forms.ToolStripMenuItem();
            this.openWork = new System.Windows.Forms.OpenFileDialog();
            this.saveWork = new System.Windows.Forms.SaveFileDialog();
            this.charCount = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.message = new System.Windows.Forms.TextBox();
            this.send = new System.Windows.Forms.Button();
            this.localPort = new System.Windows.Forms.TextBox();
            this.localIp = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.peerIp = new System.Windows.Forms.TextBox();
            this.peerPort = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.connect = new System.Windows.Forms.Button();
            this.chatLog = new System.Windows.Forms.ListBox();
            this.output = new System.Windows.Forms.RichTextBox();
            this.mainMenu.SuspendLayout();
            this.Tools.SuspendLayout();
            this.rc_Menu.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenu
            // 
            this.mainMenu.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Mm_Files,
            this.Mm_Edit,
            this.Mm_Tools,
            this.helpToolStripMenuItem});
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(1023, 24);
            this.mainMenu.TabIndex = 1;
            this.mainMenu.Text = "menuStrip1";
            // 
            // Mm_Files
            // 
            this.Mm_Files.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.file_New,
            this.file_Open,
            this.toolStripSeparator,
            this.file_Save,
            this.toolStripSeparator1,
            this.toolStripSeparator2,
            this.file_Exit});
            this.Mm_Files.Name = "Mm_Files";
            this.Mm_Files.Size = new System.Drawing.Size(37, 20);
            this.Mm_Files.Text = "&File";
            // 
            // file_New
            // 
            this.file_New.Image = ((System.Drawing.Image)(resources.GetObject("file_New.Image")));
            this.file_New.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.file_New.Name = "file_New";
            this.file_New.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.file_New.Size = new System.Drawing.Size(146, 22);
            this.file_New.Text = "&New";
            this.file_New.Click += new System.EventHandler(this.file_New_Click);
            // 
            // file_Open
            // 
            this.file_Open.Image = ((System.Drawing.Image)(resources.GetObject("file_Open.Image")));
            this.file_Open.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.file_Open.Name = "file_Open";
            this.file_Open.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.file_Open.Size = new System.Drawing.Size(146, 22);
            this.file_Open.Text = "&Open";
            this.file_Open.Click += new System.EventHandler(this.file_Open_Click);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(143, 6);
            // 
            // file_Save
            // 
            this.file_Save.Image = ((System.Drawing.Image)(resources.GetObject("file_Save.Image")));
            this.file_Save.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.file_Save.Name = "file_Save";
            this.file_Save.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.file_Save.Size = new System.Drawing.Size(146, 22);
            this.file_Save.Text = "&Save";
            this.file_Save.Click += new System.EventHandler(this.file_Save_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(143, 6);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(143, 6);
            // 
            // file_Exit
            // 
            this.file_Exit.Name = "file_Exit";
            this.file_Exit.Size = new System.Drawing.Size(146, 22);
            this.file_Exit.Text = "E&xit";
            this.file_Exit.Click += new System.EventHandler(this.file_Exit_Click);
            // 
            // Mm_Edit
            // 
            this.Mm_Edit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.edit_Undo,
            this.edit_Redo,
            this.toolStripSeparator3,
            this.edit_Cut,
            this.edit_Copy,
            this.edit_Paste,
            this.toolStripSeparator4,
            this.edit_SelectAll});
            this.Mm_Edit.Name = "Mm_Edit";
            this.Mm_Edit.Size = new System.Drawing.Size(39, 20);
            this.Mm_Edit.Text = "&Edit";
            // 
            // edit_Undo
            // 
            this.edit_Undo.Name = "edit_Undo";
            this.edit_Undo.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.edit_Undo.Size = new System.Drawing.Size(144, 22);
            this.edit_Undo.Text = "&Undo";
            this.edit_Undo.Click += new System.EventHandler(this.edit_Undo_Click);
            // 
            // edit_Redo
            // 
            this.edit_Redo.Name = "edit_Redo";
            this.edit_Redo.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
            this.edit_Redo.Size = new System.Drawing.Size(144, 22);
            this.edit_Redo.Text = "&Redo";
            this.edit_Redo.Click += new System.EventHandler(this.edit_Redo_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(141, 6);
            // 
            // edit_Cut
            // 
            this.edit_Cut.Image = ((System.Drawing.Image)(resources.GetObject("edit_Cut.Image")));
            this.edit_Cut.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.edit_Cut.Name = "edit_Cut";
            this.edit_Cut.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.edit_Cut.Size = new System.Drawing.Size(144, 22);
            this.edit_Cut.Text = "Cu&t";
            this.edit_Cut.Click += new System.EventHandler(this.edit_Cut_Click);
            // 
            // edit_Copy
            // 
            this.edit_Copy.Image = ((System.Drawing.Image)(resources.GetObject("edit_Copy.Image")));
            this.edit_Copy.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.edit_Copy.Name = "edit_Copy";
            this.edit_Copy.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.edit_Copy.Size = new System.Drawing.Size(144, 22);
            this.edit_Copy.Text = "&Copy";
            this.edit_Copy.Click += new System.EventHandler(this.edit_Copy_Click);
            // 
            // edit_Paste
            // 
            this.edit_Paste.Image = ((System.Drawing.Image)(resources.GetObject("edit_Paste.Image")));
            this.edit_Paste.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.edit_Paste.Name = "edit_Paste";
            this.edit_Paste.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.edit_Paste.Size = new System.Drawing.Size(144, 22);
            this.edit_Paste.Text = "&Paste";
            this.edit_Paste.Click += new System.EventHandler(this.edit_Paste_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(141, 6);
            // 
            // edit_SelectAll
            // 
            this.edit_SelectAll.Name = "edit_SelectAll";
            this.edit_SelectAll.Size = new System.Drawing.Size(144, 22);
            this.edit_SelectAll.Text = "Select &All";
            this.edit_SelectAll.Click += new System.EventHandler(this.edit_SelectAll_Click);
            // 
            // Mm_Tools
            // 
            this.Mm_Tools.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.customizeToolStripMenuItem});
            this.Mm_Tools.Name = "Mm_Tools";
            this.Mm_Tools.Size = new System.Drawing.Size(46, 20);
            this.Mm_Tools.Text = "&Tools";
            this.Mm_Tools.Click += new System.EventHandler(this.Mm_Tools_Click);
            // 
            // customizeToolStripMenuItem
            // 
            this.customizeToolStripMenuItem.Name = "customizeToolStripMenuItem";
            this.customizeToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.customizeToolStripMenuItem.Text = "&Customize";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // Tools
            // 
            this.Tools.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.Tools.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tb_New,
            this.tb_Open,
            this.tb_Save,
            this.toolStripSeparator6,
            this.tb_Cut,
            this.tb_Copy,
            this.tb_Paste,
            this.toolStripSeparator7,
            this.tb_Undo,
            this.tb_Redo,
            this.toolStripSeparator5,
            this.build,
            this.tb_Start,
            this.stop,
            this.toolStripLabel1});
            this.Tools.Location = new System.Drawing.Point(0, 24);
            this.Tools.Name = "Tools";
            this.Tools.Size = new System.Drawing.Size(1023, 25);
            this.Tools.TabIndex = 2;
            this.Tools.Text = "toolStrip1";
            // 
            // tb_New
            // 
            this.tb_New.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tb_New.Image = ((System.Drawing.Image)(resources.GetObject("tb_New.Image")));
            this.tb_New.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tb_New.Name = "tb_New";
            this.tb_New.Size = new System.Drawing.Size(23, 22);
            this.tb_New.Text = "&New";
            this.tb_New.Click += new System.EventHandler(this.tb_New_Click);
            // 
            // tb_Open
            // 
            this.tb_Open.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tb_Open.Image = ((System.Drawing.Image)(resources.GetObject("tb_Open.Image")));
            this.tb_Open.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tb_Open.Name = "tb_Open";
            this.tb_Open.Size = new System.Drawing.Size(23, 22);
            this.tb_Open.Text = "&Open";
            this.tb_Open.Click += new System.EventHandler(this.tb_Open_Click);
            // 
            // tb_Save
            // 
            this.tb_Save.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tb_Save.Image = ((System.Drawing.Image)(resources.GetObject("tb_Save.Image")));
            this.tb_Save.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tb_Save.Name = "tb_Save";
            this.tb_Save.Size = new System.Drawing.Size(23, 22);
            this.tb_Save.Text = "&Save";
            this.tb_Save.Click += new System.EventHandler(this.tb_Save_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 25);
            // 
            // tb_Cut
            // 
            this.tb_Cut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tb_Cut.Image = ((System.Drawing.Image)(resources.GetObject("tb_Cut.Image")));
            this.tb_Cut.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tb_Cut.Name = "tb_Cut";
            this.tb_Cut.Size = new System.Drawing.Size(23, 22);
            this.tb_Cut.Text = "C&ut";
            this.tb_Cut.Click += new System.EventHandler(this.tb_Cut_Click);
            // 
            // tb_Copy
            // 
            this.tb_Copy.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tb_Copy.Image = ((System.Drawing.Image)(resources.GetObject("tb_Copy.Image")));
            this.tb_Copy.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tb_Copy.Name = "tb_Copy";
            this.tb_Copy.Size = new System.Drawing.Size(23, 22);
            this.tb_Copy.Text = "&Copy";
            this.tb_Copy.Click += new System.EventHandler(this.tb_Copy_Click);
            // 
            // tb_Paste
            // 
            this.tb_Paste.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tb_Paste.Image = ((System.Drawing.Image)(resources.GetObject("tb_Paste.Image")));
            this.tb_Paste.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tb_Paste.Name = "tb_Paste";
            this.tb_Paste.Size = new System.Drawing.Size(23, 22);
            this.tb_Paste.Text = "&Paste";
            this.tb_Paste.Click += new System.EventHandler(this.tb_Paste_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(6, 25);
            // 
            // tb_Undo
            // 
            this.tb_Undo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tb_Undo.Image = ((System.Drawing.Image)(resources.GetObject("tb_Undo.Image")));
            this.tb_Undo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tb_Undo.Name = "tb_Undo";
            this.tb_Undo.Size = new System.Drawing.Size(23, 22);
            this.tb_Undo.Text = "Undo";
            this.tb_Undo.Click += new System.EventHandler(this.tb_Undo_Click);
            // 
            // tb_Redo
            // 
            this.tb_Redo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tb_Redo.Image = ((System.Drawing.Image)(resources.GetObject("tb_Redo.Image")));
            this.tb_Redo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tb_Redo.Name = "tb_Redo";
            this.tb_Redo.Size = new System.Drawing.Size(23, 22);
            this.tb_Redo.Text = "Redo";
            this.tb_Redo.Click += new System.EventHandler(this.tb_Redo_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 25);
            // 
            // build
            // 
            this.build.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.build.Enabled = false;
            this.build.Image = ((System.Drawing.Image)(resources.GetObject("build.Image")));
            this.build.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.build.Name = "build";
            this.build.Size = new System.Drawing.Size(43, 22);
            this.build.Text = "BUILD";
            this.build.Click += new System.EventHandler(this.build_Click);
            // 
            // tb_Start
            // 
            this.tb_Start.Enabled = false;
            this.tb_Start.Image = ((System.Drawing.Image)(resources.GetObject("tb_Start.Image")));
            this.tb_Start.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tb_Start.Name = "tb_Start";
            this.tb_Start.Size = new System.Drawing.Size(51, 22);
            this.tb_Start.Text = "Start";
            this.tb_Start.Click += new System.EventHandler(this.tb_Start_Click);
            // 
            // stop
            // 
            this.stop.BackColor = System.Drawing.Color.Red;
            this.stop.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.None;
            this.stop.Enabled = false;
            this.stop.Image = ((System.Drawing.Image)(resources.GetObject("stop.Image")));
            this.stop.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.stop.Name = "stop";
            this.stop.Size = new System.Drawing.Size(23, 22);
            this.stop.Click += new System.EventHandler(this.stop_Click);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Enabled = false;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(31, 22);
            this.toolStripLabel1.Text = "Stop";
            // 
            // github
            // 
            this.github.BackColor = System.Drawing.Color.Transparent;
            this.github.Cursor = System.Windows.Forms.Cursors.Hand;
            this.github.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.github.Location = new System.Drawing.Point(0, 436);
            this.github.Name = "github";
            this.github.Size = new System.Drawing.Size(35, 34);
            this.github.TabIndex = 5;
            this.toolTip1.SetToolTip(this.github, "Github");
            this.github.Click += new System.EventHandler(this.github_Click);
            // 
            // skype
            // 
            this.skype.BackColor = System.Drawing.Color.Transparent;
            this.skype.Cursor = System.Windows.Forms.Cursors.Hand;
            this.skype.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.skype.Location = new System.Drawing.Point(0, 483);
            this.skype.Name = "skype";
            this.skype.Size = new System.Drawing.Size(35, 28);
            this.skype.TabIndex = 6;
            this.toolTip1.SetToolTip(this.skype, "Skype");
            this.skype.Click += new System.EventHandler(this.skype_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.BackColor = System.Drawing.Color.Transparent;
            this.toolTip1.ForeColor = System.Drawing.Color.White;
            // 
            // illustrator
            // 
            this.illustrator.BackColor = System.Drawing.Color.Transparent;
            this.illustrator.Cursor = System.Windows.Forms.Cursors.Hand;
            this.illustrator.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.illustrator.Location = new System.Drawing.Point(2, 396);
            this.illustrator.Name = "illustrator";
            this.illustrator.Size = new System.Drawing.Size(35, 30);
            this.illustrator.TabIndex = 24;
            this.toolTip1.SetToolTip(this.illustrator, "Illustrator");
            this.illustrator.Click += new System.EventHandler(this.illustrator_Click);
            // 
            // Document
            // 
            this.Document.BackColor = System.Drawing.Color.Black;
            this.Document.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Document.ContextMenuStrip = this.rc_Menu;
            this.Document.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Document.ForeColor = System.Drawing.SystemColors.Info;
            this.Document.Location = new System.Drawing.Point(72, 49);
            this.Document.Name = "Document";
            this.Document.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.Document.Size = new System.Drawing.Size(733, 471);
            this.Document.TabIndex = 4;
            this.Document.Text = "public class TestCode{\n     public static void main(String []args){\n        Syste" +
    "m.out.println(\"Hello World\");\n     }\n}";
            this.Document.TextChanged += new System.EventHandler(this.Document_TextChanged);
            this.Document.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Document_KeyUp);
            // 
            // rc_Menu
            // 
            this.rc_Menu.BackColor = System.Drawing.Color.White;
            this.rc_Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rc_Undo,
            this.rc_Redo,
            this.toolStripSeparator12,
            this.rc_Cut,
            this.rc_Copy,
            this.rc_Paste,
            this.toolStripSeparator8,
            this.rc_Sketch,
            this.rc_Share,
            this.rc_About});
            this.rc_Menu.Name = "rc_Menu";
            this.rc_Menu.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.rc_Menu.ShowImageMargin = false;
            this.rc_Menu.Size = new System.Drawing.Size(85, 192);
            // 
            // rc_Undo
            // 
            this.rc_Undo.Name = "rc_Undo";
            this.rc_Undo.Size = new System.Drawing.Size(84, 22);
            this.rc_Undo.Text = "Undo";
            this.rc_Undo.Click += new System.EventHandler(this.rc_Undo_Click);
            // 
            // rc_Redo
            // 
            this.rc_Redo.Name = "rc_Redo";
            this.rc_Redo.Size = new System.Drawing.Size(84, 22);
            this.rc_Redo.Text = "Redo";
            this.rc_Redo.Click += new System.EventHandler(this.rc_Redo_Click);
            // 
            // toolStripSeparator12
            // 
            this.toolStripSeparator12.Name = "toolStripSeparator12";
            this.toolStripSeparator12.Size = new System.Drawing.Size(81, 6);
            // 
            // rc_Cut
            // 
            this.rc_Cut.Name = "rc_Cut";
            this.rc_Cut.Size = new System.Drawing.Size(84, 22);
            this.rc_Cut.Text = "Cut";
            this.rc_Cut.Click += new System.EventHandler(this.rc_Cut_Click);
            // 
            // rc_Copy
            // 
            this.rc_Copy.Name = "rc_Copy";
            this.rc_Copy.Size = new System.Drawing.Size(84, 22);
            this.rc_Copy.Text = "Copy";
            this.rc_Copy.Click += new System.EventHandler(this.rc_Copy_Click);
            // 
            // rc_Paste
            // 
            this.rc_Paste.Name = "rc_Paste";
            this.rc_Paste.Size = new System.Drawing.Size(84, 22);
            this.rc_Paste.Text = "Paste";
            this.rc_Paste.Click += new System.EventHandler(this.rc_Paste_Click);
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(81, 6);
            // 
            // rc_Sketch
            // 
            this.rc_Sketch.Name = "rc_Sketch";
            this.rc_Sketch.Size = new System.Drawing.Size(84, 22);
            this.rc_Sketch.Text = "Sketch";
            this.rc_Sketch.Click += new System.EventHandler(this.rc_Sketch_Click_1);
            // 
            // rc_Share
            // 
            this.rc_Share.Name = "rc_Share";
            this.rc_Share.Size = new System.Drawing.Size(84, 22);
            this.rc_Share.Text = "Share";
            this.rc_Share.Click += new System.EventHandler(this.rc_Share_Click_1);
            // 
            // rc_About
            // 
            this.rc_About.Name = "rc_About";
            this.rc_About.Size = new System.Drawing.Size(84, 22);
            this.rc_About.Text = "About";
            this.rc_About.Click += new System.EventHandler(this.rc_About_Click_1);
            // 
            // openWork
            // 
            this.openWork.FileName = "openFileDialog";
            this.openWork.Filter = "Text Files|*.txt|RTF Files|*.rtf";
            this.openWork.Title = "Open Work";
            // 
            // saveWork
            // 
            this.saveWork.Filter = "Text Files|*.txt|RTF Files|*.rtf";
            this.saveWork.Title = "Save";
            // 
            // charCount
            // 
            this.charCount.AutoSize = true;
            this.charCount.BackColor = System.Drawing.Color.Transparent;
            this.charCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.charCount.ForeColor = System.Drawing.Color.White;
            this.charCount.Location = new System.Drawing.Point(0, 523);
            this.charCount.Name = "charCount";
            this.charCount.Size = new System.Drawing.Size(63, 15);
            this.charCount.TabIndex = 9;
            this.charCount.Text = "charCount";
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.Black;
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.ForeColor = System.Drawing.Color.White;
            this.richTextBox1.Location = new System.Drawing.Point(43, 49);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.richTextBox1.Size = new System.Drawing.Size(28, 471);
            this.richTextBox1.TabIndex = 8;
            this.richTextBox1.Text = "";
            this.richTextBox1.WordWrap = false;
            // 
            // message
            // 
            this.message.Location = new System.Drawing.Point(811, 491);
            this.message.Name = "message";
            this.message.Size = new System.Drawing.Size(143, 20);
            this.message.TabIndex = 11;
            // 
            // send
            // 
            this.send.Enabled = false;
            this.send.Location = new System.Drawing.Point(960, 491);
            this.send.Name = "send";
            this.send.Size = new System.Drawing.Size(51, 20);
            this.send.TabIndex = 12;
            this.send.Text = "Send";
            this.send.UseVisualStyleBackColor = true;
            this.send.Click += new System.EventHandler(this.send_Click);
            // 
            // localPort
            // 
            this.localPort.Location = new System.Drawing.Point(63, 41);
            this.localPort.Name = "localPort";
            this.localPort.Size = new System.Drawing.Size(79, 20);
            this.localPort.TabIndex = 16;
            // 
            // localIp
            // 
            this.localIp.Location = new System.Drawing.Point(63, 19);
            this.localIp.Name = "localIp";
            this.localIp.Size = new System.Drawing.Size(131, 20);
            this.localIp.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(-1, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Port";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(-1, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "IP Address";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.localIp);
            this.groupBox1.Controls.Add(this.localPort);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(811, 52);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 85);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "User 1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.peerIp);
            this.groupBox2.Controls.Add(this.peerPort);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(811, 143);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 85);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "User 2";
            // 
            // peerIp
            // 
            this.peerIp.Location = new System.Drawing.Point(63, 19);
            this.peerIp.Name = "peerIp";
            this.peerIp.Size = new System.Drawing.Size(131, 20);
            this.peerIp.TabIndex = 15;
            // 
            // peerPort
            // 
            this.peerPort.Location = new System.Drawing.Point(63, 45);
            this.peerPort.Name = "peerPort";
            this.peerPort.Size = new System.Drawing.Size(79, 20);
            this.peerPort.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(-1, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "IP Address";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(-1, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Port";
            // 
            // connect
            // 
            this.connect.Location = new System.Drawing.Point(879, 234);
            this.connect.Name = "connect";
            this.connect.Size = new System.Drawing.Size(75, 23);
            this.connect.TabIndex = 23;
            this.connect.Text = "Connect";
            this.connect.UseVisualStyleBackColor = true;
            this.connect.Click += new System.EventHandler(this.connect_Click);
            // 
            // chatLog
            // 
            this.chatLog.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.chatLog.FormattingEnabled = true;
            this.chatLog.Location = new System.Drawing.Point(813, 260);
            this.chatLog.Name = "chatLog";
            this.chatLog.Size = new System.Drawing.Size(197, 221);
            this.chatLog.TabIndex = 25;
            // 
            // output
            // 
            this.output.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.output.Location = new System.Drawing.Point(44, 327);
            this.output.Name = "output";
            this.output.ReadOnly = true;
            this.output.Size = new System.Drawing.Size(764, 193);
            this.output.TabIndex = 26;
            this.output.Text = "";
            this.output.Visible = false;
            // 
            // RexEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1023, 540);
            this.Controls.Add(this.output);
            this.Controls.Add(this.chatLog);
            this.Controls.Add(this.illustrator);
            this.Controls.Add(this.connect);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.send);
            this.Controls.Add(this.message);
            this.Controls.Add(this.charCount);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.skype);
            this.Controls.Add(this.github);
            this.Controls.Add(this.Document);
            this.Controls.Add(this.Tools);
            this.Controls.Add(this.mainMenu);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "RexEditor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rex Editor";
            this.Load += new System.EventHandler(this.RexEditor_Load);
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            this.Tools.ResumeLayout(false);
            this.Tools.PerformLayout();
            this.rc_Menu.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mainMenu;
        private System.Windows.Forms.ToolStripMenuItem Mm_Files;
        private System.Windows.Forms.ToolStripMenuItem file_New;
        private System.Windows.Forms.ToolStripMenuItem file_Open;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem file_Save;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem file_Exit;
        private System.Windows.Forms.ToolStripMenuItem Mm_Edit;
        private System.Windows.Forms.ToolStripMenuItem edit_Undo;
        private System.Windows.Forms.ToolStripMenuItem edit_Redo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem edit_Cut;
        private System.Windows.Forms.ToolStripMenuItem edit_Copy;
        private System.Windows.Forms.ToolStripMenuItem edit_Paste;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem edit_SelectAll;
        private System.Windows.Forms.ToolStripMenuItem Mm_Tools;
        private System.Windows.Forms.ToolStripMenuItem customizeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStrip Tools;
        private System.Windows.Forms.ToolStripButton tb_New;
        private System.Windows.Forms.ToolStripButton tb_Open;
        private System.Windows.Forms.ToolStripButton tb_Save;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripButton tb_Cut;
        private System.Windows.Forms.ToolStripButton tb_Copy;
        private System.Windows.Forms.ToolStripButton tb_Paste;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripButton tb_Redo;
        private System.Windows.Forms.ToolStripButton tb_Undo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton tb_Start;
        private System.Windows.Forms.Label github;
        private System.Windows.Forms.Label skype;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.RichTextBox Document;
        private System.Windows.Forms.OpenFileDialog openWork;
        private System.Windows.Forms.SaveFileDialog saveWork;
        private System.Windows.Forms.ContextMenuStrip rc_Menu;
        private System.Windows.Forms.ToolStripMenuItem rc_Undo;
        private System.Windows.Forms.ToolStripMenuItem rc_Redo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator12;
        private System.Windows.Forms.ToolStripMenuItem rc_Cut;
        private System.Windows.Forms.ToolStripMenuItem rc_Copy;
        private System.Windows.Forms.ToolStripMenuItem rc_Paste;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripMenuItem rc_Sketch;
        private System.Windows.Forms.ToolStripMenuItem rc_Share;
        private System.Windows.Forms.ToolStripMenuItem rc_About;
        private System.Windows.Forms.Label charCount;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TextBox message;
        private System.Windows.Forms.Button send;
        private System.Windows.Forms.TextBox localPort;
        private System.Windows.Forms.TextBox localIp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox peerIp;
        private System.Windows.Forms.TextBox peerPort;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button connect;
        private System.Windows.Forms.Label illustrator;
        private System.Windows.Forms.ListBox chatLog;
        private System.Windows.Forms.RichTextBox output;
        private System.Windows.Forms.ToolStripButton build;
        private System.Windows.Forms.ToolStripButton stop;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
    }
}

