namespace ITRModLoader
{
    partial class Form1
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
            pictureBox1 = new PictureBox();
            label1 = new Label();
            NavBar = new Panel();
            playButton = new Button();
            alphaBuildLabel = new Label();
            category = new Label();
            button1 = new Button();
            modsCheckedListBox = new CheckedListBox();
            contextMenuStrip1 = new ContextMenuStrip(components);
            renameModsToolStripMenuItem = new ToolStripMenuItem();
            panel1 = new Panel();
            label4 = new Label();
            label3 = new Label();
            fileNameLabel = new Label();
            windowBorderPanel = new Panel();
            applicationCloseButton = new Button();
            settingsButton = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            NavBar.SuspendLayout();
            contextMenuStrip1.SuspendLayout();
            panel1.SuspendLayout();
            windowBorderPanel.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Radius_Icon_1024x1024px;
            pictureBox1.Location = new Point(12, 6);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(56, 56);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Black;
            label1.Font = new Font("Segoe UI Semibold", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(74, 9);
            label1.Name = "label1";
            label1.Size = new Size(287, 45);
            label1.TabIndex = 1;
            label1.Text = "ITR Mod Launcher";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            label1.Click += label1_Click;
            // 
            // NavBar
            // 
            NavBar.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            NavBar.BackColor = Color.Black;
            NavBar.Controls.Add(settingsButton);
            NavBar.Controls.Add(playButton);
            NavBar.Controls.Add(label1);
            NavBar.Controls.Add(pictureBox1);
            NavBar.ForeColor = Color.FromArgb(255, 192, 128);
            NavBar.Location = new Point(-8, 28);
            NavBar.Name = "NavBar";
            NavBar.Size = new Size(1382, 67);
            NavBar.TabIndex = 2;
            // 
            // playButton
            // 
            playButton.BackColor = Color.Black;
            playButton.FlatAppearance.BorderColor = Color.Red;
            playButton.FlatAppearance.BorderSize = 2;
            playButton.ForeColor = Color.White;
            playButton.Location = new Point(951, 12);
            playButton.Name = "playButton";
            playButton.Size = new Size(195, 40);
            playButton.TabIndex = 4;
            playButton.Text = "PLAY";
            playButton.UseVisualStyleBackColor = false;
            playButton.Click += playButton_Click;
            // 
            // alphaBuildLabel
            // 
            alphaBuildLabel.AutoSize = true;
            alphaBuildLabel.ForeColor = Color.FromArgb(64, 64, 64);
            alphaBuildLabel.Location = new Point(608, 108);
            alphaBuildLabel.Name = "alphaBuildLabel";
            alphaBuildLabel.Size = new Size(126, 15);
            alphaBuildLabel.TabIndex = 4;
            alphaBuildLabel.Text = "* Early Progress Build *";
            // 
            // category
            // 
            category.AutoSize = true;
            category.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            category.ForeColor = Color.White;
            category.Location = new Point(228, 99);
            category.Name = "category";
            category.Size = new Size(125, 37);
            category.TabIndex = 4;
            category.Text = "All Mods";
            // 
            // button1
            // 
            button1.BackColor = Color.Black;
            button1.FlatAppearance.BorderColor = Color.Red;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.White;
            button1.Location = new Point(22, 139);
            button1.Name = "button1";
            button1.Size = new Size(178, 44);
            button1.TabIndex = 5;
            button1.Text = "Import PAK";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // modsCheckedListBox
            // 
            modsCheckedListBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            modsCheckedListBox.BackColor = Color.FromArgb(33, 33, 33);
            modsCheckedListBox.ContextMenuStrip = contextMenuStrip1;
            modsCheckedListBox.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            modsCheckedListBox.ForeColor = Color.White;
            modsCheckedListBox.FormattingEnabled = true;
            modsCheckedListBox.Items.AddRange(new object[] { "Chucks Custom Items", "R3 Custom Weapons ", "Common DP", "M1911 TT33 Replacer" });
            modsCheckedListBox.Location = new Point(228, 139);
            modsCheckedListBox.Name = "modsCheckedListBox";
            modsCheckedListBox.Size = new Size(951, 444);
            modsCheckedListBox.TabIndex = 6;
            modsCheckedListBox.SelectedIndexChanged += checkedListBox1_SelectedIndexChanged;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { renameModsToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(146, 26);
            contextMenuStrip1.Opening += contextMenuStrip1_Opening;
            // 
            // renameModsToolStripMenuItem
            // 
            renameModsToolStripMenuItem.Name = "renameModsToolStripMenuItem";
            renameModsToolStripMenuItem.Size = new Size(145, 22);
            renameModsToolStripMenuItem.Text = "Rename Mod";
            renameModsToolStripMenuItem.Click += renameModsToolStripMenuItem_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(fileNameLabel);
            panel1.Location = new Point(228, 589);
            panel1.Name = "panel1";
            panel1.Size = new Size(951, 177);
            panel1.TabIndex = 7;
            panel1.Paint += panel1_Paint;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 12F);
            label4.ForeColor = Color.White;
            label4.Location = new Point(17, 99);
            label4.Name = "label4";
            label4.Size = new Size(103, 21);
            label4.TabIndex = 2;
            label4.Text = "Date Created:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 12F);
            label3.ForeColor = Color.White;
            label3.Location = new Point(17, 57);
            label3.Name = "label3";
            label3.Size = new Size(69, 21);
            label3.TabIndex = 1;
            label3.Text = "File Size:";
            // 
            // fileNameLabel
            // 
            fileNameLabel.AutoSize = true;
            fileNameLabel.BackColor = Color.Transparent;
            fileNameLabel.Font = new Font("Segoe UI", 12F);
            fileNameLabel.ForeColor = Color.White;
            fileNameLabel.Location = new Point(17, 16);
            fileNameLabel.Name = "fileNameLabel";
            fileNameLabel.Size = new Size(119, 21);
            fileNameLabel.TabIndex = 0;
            fileNameLabel.Text = "Mod File Name:";
            fileNameLabel.Click += fileNameLabel_Click;
            // 
            // windowBorderPanel
            // 
            windowBorderPanel.Controls.Add(applicationCloseButton);
            windowBorderPanel.Location = new Point(0, 0);
            windowBorderPanel.Name = "windowBorderPanel";
            windowBorderPanel.Size = new Size(1374, 28);
            windowBorderPanel.TabIndex = 8;
            windowBorderPanel.Paint += panel2_Paint;
            windowBorderPanel.MouseDown += panel2_MouseDown;
            windowBorderPanel.MouseMove += panel2_MouseMove;
            windowBorderPanel.MouseUp += panel2_MouseUp;
            // 
            // applicationCloseButton
            // 
            applicationCloseButton.BackColor = Color.FromArgb(64, 0, 0);
            applicationCloseButton.Dock = DockStyle.Right;
            applicationCloseButton.FlatAppearance.BorderSize = 0;
            applicationCloseButton.FlatStyle = FlatStyle.Flat;
            applicationCloseButton.ForeColor = Color.White;
            applicationCloseButton.Location = new Point(1334, 0);
            applicationCloseButton.Name = "applicationCloseButton";
            applicationCloseButton.Size = new Size(40, 28);
            applicationCloseButton.TabIndex = 9;
            applicationCloseButton.Text = "X";
            applicationCloseButton.UseVisualStyleBackColor = false;
            applicationCloseButton.Click += button2_Click;
            // 
            // settingsButton
            // 
            settingsButton.BackColor = Color.Black;
            settingsButton.FlatAppearance.BorderColor = Color.Red;
            settingsButton.FlatAppearance.BorderSize = 2;
            settingsButton.ForeColor = Color.White;
            settingsButton.Location = new Point(1152, 12);
            settingsButton.Name = "settingsButton";
            settingsButton.Size = new Size(195, 40);
            settingsButton.TabIndex = 3;
            settingsButton.Text = "SETTINGS";
            settingsButton.UseVisualStyleBackColor = false;
            settingsButton.Click += settingsButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(20, 20, 20);
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(1374, 822);
            Controls.Add(windowBorderPanel);
            Controls.Add(panel1);
            Controls.Add(modsCheckedListBox);
            Controls.Add(alphaBuildLabel);
            Controls.Add(button1);
            Controls.Add(category);
            Controls.Add(NavBar);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "             ";
            Load += Form1_Load;
            MouseClick += Form1_MouseClick;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            NavBar.ResumeLayout(false);
            NavBar.PerformLayout();
            contextMenuStrip1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            windowBorderPanel.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Panel NavBar;
        private Label category;
        private Button button1;
        private Label alphaBuildLabel;
        private Button playButton;
        private CheckedListBox modsCheckedListBox;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem renameModsToolStripMenuItem;
        private Panel panel1;
        private Label label4;
        private Label label3;
        private Label fileNameLabel;
        private Panel windowBorderPanel;
        private Button applicationCloseButton;
        private Button settingsButton;
    }
}
