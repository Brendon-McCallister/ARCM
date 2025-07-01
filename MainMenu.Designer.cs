namespace ARCCM
{
    partial class MainMenu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            splitContainer1 = new SplitContainer();
            clubUserViewer = new TreeView();
            imageList1 = new ImageList(components);
            groupBox = new GroupBox();
            roleLabel = new Label();
            addressLabel = new Label();
            button1 = new Button();
            groupBox1 = new GroupBox();
            IDLabel = new Label();
            dobLabel = new Label();
            line2label = new Label();
            line1label = new Label();
            pictureBox1 = new PictureBox();
            expiration = new Label();
            labelName = new Label();
            labelPhone = new Label();
            label1 = new Label();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            importToolStripMenuItem = new ToolStripMenuItem();
            newToolStripMenuItem = new ToolStripMenuItem();
            saveToolStripMenuItem = new ToolStripMenuItem();
            clubToolStripMenuItem = new ToolStripMenuItem();
            newToolStripMenuItem1 = new ToolStripMenuItem();
            userToolStripMenuItem = new ToolStripMenuItem();
            clubToolStripMenuItem1 = new ToolStripMenuItem();
            deleteSelectedToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            groupBox.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 24);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(clubUserViewer);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(groupBox);
            splitContainer1.Panel2.Controls.Add(label1);
            splitContainer1.Size = new Size(1139, 519);
            splitContainer1.SplitterDistance = 281;
            splitContainer1.TabIndex = 0;
            // 
            // clubUserViewer
            // 
            clubUserViewer.Dock = DockStyle.Fill;
            clubUserViewer.ImageIndex = 0;
            clubUserViewer.ImageList = imageList1;
            clubUserViewer.Location = new Point(0, 0);
            clubUserViewer.Name = "clubUserViewer";
            clubUserViewer.SelectedImageIndex = 0;
            clubUserViewer.Size = new Size(281, 519);
            clubUserViewer.TabIndex = 0;
            clubUserViewer.AfterSelect += updateGroupBox;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "shell32_4.ico");
            imageList1.Images.SetKeyName(1, "shell32_152.ico");
            // 
            // groupBox
            // 
            groupBox.Controls.Add(roleLabel);
            groupBox.Controls.Add(addressLabel);
            groupBox.Controls.Add(button1);
            groupBox.Controls.Add(groupBox1);
            groupBox.Controls.Add(labelName);
            groupBox.Controls.Add(labelPhone);
            groupBox.Dock = DockStyle.Fill;
            groupBox.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            groupBox.Location = new Point(0, 0);
            groupBox.Name = "groupBox";
            groupBox.Size = new Size(854, 519);
            groupBox.TabIndex = 1;
            groupBox.TabStop = false;
            groupBox.Text = "Callsign";
            groupBox.Visible = false;
            // 
            // roleLabel
            // 
            roleLabel.AutoSize = true;
            roleLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            roleLabel.Location = new Point(6, 44);
            roleLabel.Name = "roleLabel";
            roleLabel.Size = new Size(60, 15);
            roleLabel.TabIndex = 6;
            roleLabel.Text = "Treasurer";
            // 
            // addressLabel
            // 
            addressLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            addressLabel.AutoSize = true;
            addressLabel.Location = new Point(87, 488);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new Size(214, 15);
            addressLabel.TabIndex = 5;
            addressLabel.Text = "100 North Street Birmingham, Alabama";
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            button1.Location = new Point(6, 484);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 4;
            button1.Text = "Edit";
            button1.UseVisualStyleBackColor = true;
            button1.Click += editUser;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(IDLabel);
            groupBox1.Controls.Add(dobLabel);
            groupBox1.Controls.Add(line2label);
            groupBox1.Controls.Add(line1label);
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Controls.Add(expiration);
            groupBox1.Dock = DockStyle.Right;
            groupBox1.Location = new Point(651, 19);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(200, 497);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Info";
            // 
            // IDLabel
            // 
            IDLabel.AutoSize = true;
            IDLabel.Location = new Point(7, 190);
            IDLabel.Name = "IDLabel";
            IDLabel.Size = new Size(79, 15);
            IDLabel.TabIndex = 9;
            IDLabel.Text = "ID: 321293402";
            // 
            // dobLabel
            // 
            dobLabel.AutoSize = true;
            dobLabel.Location = new Point(6, 56);
            dobLabel.Name = "dobLabel";
            dobLabel.Size = new Size(96, 15);
            dobLabel.TabIndex = 8;
            dobLabel.Text = "DOB: 01/02/2013";
            // 
            // line2label
            // 
            line2label.AutoSize = true;
            line2label.Location = new Point(6, 122);
            line2label.Name = "line2label";
            line2label.Size = new Size(40, 15);
            line2label.TabIndex = 7;
            line2label.Text = "LINE 2";
            // 
            // line1label
            // 
            line1label.AutoSize = true;
            line1label.Location = new Point(6, 89);
            line1label.Name = "line1label";
            line1label.Size = new Size(40, 15);
            line1label.TabIndex = 6;
            line1label.Text = "LINE 1";
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            pictureBox1.Location = new Point(6, 208);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(191, 283);
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // expiration
            // 
            expiration.AutoSize = true;
            expiration.Font = new Font("Georgia", 13.5F, FontStyle.Bold);
            expiration.Location = new Point(6, 25);
            expiration.Name = "expiration";
            expiration.Size = new Size(156, 21);
            expiration.TabIndex = 3;
            expiration.Text = "Exp: 11/11/2025";
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Font = new Font("Segoe UI Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelName.Location = new Point(6, 19);
            labelName.Name = "labelName";
            labelName.Size = new Size(100, 25);
            labelName.TabIndex = 0;
            labelName.Text = "John Doe";
            // 
            // labelPhone
            // 
            labelPhone.AutoSize = true;
            labelPhone.Location = new Point(6, 60);
            labelPhone.Name = "labelPhone";
            labelPhone.Size = new Size(85, 15);
            labelPhone.TabIndex = 2;
            labelPhone.Text = "(000)-000-0000";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(570, 495);
            label1.Name = "label1";
            label1.Size = new Size(279, 15);
            label1.TabIndex = 0;
            label1.Text = "ARCM PreRelease 0.0.10 Dev - Do not Distribute!";
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, clubToolStripMenuItem, helpToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1139, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { importToolStripMenuItem, newToolStripMenuItem, saveToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "File";
            // 
            // importToolStripMenuItem
            // 
            importToolStripMenuItem.Name = "importToolStripMenuItem";
            importToolStripMenuItem.Size = new Size(180, 22);
            importToolStripMenuItem.Text = "Import";
            importToolStripMenuItem.Click += clickToImport;
            // 
            // newToolStripMenuItem
            // 
            newToolStripMenuItem.Name = "newToolStripMenuItem";
            newToolStripMenuItem.Size = new Size(180, 22);
            newToolStripMenuItem.Text = "Export";
            newToolStripMenuItem.Click += clickToExport;
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.Size = new Size(180, 22);
            saveToolStripMenuItem.Text = "Save";
            saveToolStripMenuItem.Click += saveOnClick;
            // 
            // clubToolStripMenuItem
            // 
            clubToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { newToolStripMenuItem1, deleteSelectedToolStripMenuItem });
            clubToolStripMenuItem.Name = "clubToolStripMenuItem";
            clubToolStripMenuItem.Size = new Size(44, 20);
            clubToolStripMenuItem.Text = "Club";
            // 
            // newToolStripMenuItem1
            // 
            newToolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { userToolStripMenuItem, clubToolStripMenuItem1 });
            newToolStripMenuItem1.Name = "newToolStripMenuItem1";
            newToolStripMenuItem1.Size = new Size(154, 22);
            newToolStripMenuItem1.Text = "New";
            // 
            // userToolStripMenuItem
            // 
            userToolStripMenuItem.Name = "userToolStripMenuItem";
            userToolStripMenuItem.Size = new Size(99, 22);
            userToolStripMenuItem.Text = "User";
            userToolStripMenuItem.Click += userToolStripMenuItem_Click;
            // 
            // clubToolStripMenuItem1
            // 
            clubToolStripMenuItem1.Name = "clubToolStripMenuItem1";
            clubToolStripMenuItem1.Size = new Size(99, 22);
            clubToolStripMenuItem1.Text = "Club";
            clubToolStripMenuItem1.Click += newClub;
            // 
            // deleteSelectedToolStripMenuItem
            // 
            deleteSelectedToolStripMenuItem.Name = "deleteSelectedToolStripMenuItem";
            deleteSelectedToolStripMenuItem.Size = new Size(154, 22);
            deleteSelectedToolStripMenuItem.Text = "Delete Selected";
            deleteSelectedToolStripMenuItem.Click += deleteSelected;
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(44, 20);
            helpToolStripMenuItem.Text = "Help";
            helpToolStripMenuItem.Visible = false;
            // 
            // MainMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1139, 543);
            Controls.Add(splitContainer1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            MinimumSize = new Size(400, 300);
            Name = "MainMenu";
            Text = "ARCM PreRelease ";
            Load += Form1_Load;
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            groupBox.ResumeLayout(false);
            groupBox.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private SplitContainer splitContainer1;
        private ImageList imageList1;
        private TreeView clubUserViewer;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem importToolStripMenuItem;
        private ToolStripMenuItem newToolStripMenuItem;
        private ToolStripMenuItem clubToolStripMenuItem;
        private ToolStripMenuItem newToolStripMenuItem1;
        private ToolStripMenuItem userToolStripMenuItem;
        private ToolStripMenuItem clubToolStripMenuItem1;
        private ToolStripMenuItem helpToolStripMenuItem;
        private Label label1;
        private ToolStripMenuItem saveToolStripMenuItem;
        private GroupBox groupBox;
        private Label labelName;
        private Label labelPhone;
        private GroupBox groupBox1;
        private Label expiration;
        private Button edit;
        private PictureBox pictureBox1;
        private Button button1;
        private Label line2label;
        private Label line1label;
        private Label dobLabel;
        private Label addressLabel;
        private Label IDLabel;
        private Label roleLabel;
        private ToolStripMenuItem deleteSelectedToolStripMenuItem;
    }
}
