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
            alphaBuildLabel = new Label();
            modsCheckedListBox = new CheckedListBox();
            contextMenuStrip1 = new ContextMenuStrip(components);
            renameModsToolStripMenuItem = new ToolStripMenuItem();
            panel1 = new Panel();
            materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            fileNameLabel = new MaterialSkin.Controls.MaterialLabel();
            windowBorderPanel = new Panel();
            applicationCloseButton = new Button();
            materialButton3 = new MaterialSkin.Controls.MaterialButton();
            materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            pictureBox1 = new PictureBox();
            settingsMaterialButton = new MaterialSkin.Controls.MaterialButton();
            materialButton1 = new MaterialSkin.Controls.MaterialButton();
            NavBar = new Panel();
            materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            materialButton2 = new MaterialSkin.Controls.MaterialButton();
            contextMenuStrip2 = new ContextMenuStrip(components);
            contextMenuStrip1.SuspendLayout();
            panel1.SuspendLayout();
            windowBorderPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            NavBar.SuspendLayout();
            SuspendLayout();
            // 
            // alphaBuildLabel
            // 
            alphaBuildLabel.AutoSize = true;
            alphaBuildLabel.ForeColor = Color.FromArgb(64, 64, 64);
            alphaBuildLabel.Location = new Point(604, 108);
            alphaBuildLabel.Name = "alphaBuildLabel";
            alphaBuildLabel.Size = new Size(126, 15);
            alphaBuildLabel.TabIndex = 4;
            alphaBuildLabel.Text = "* Early Progress Build *";
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
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(materialLabel5);
            panel1.Controls.Add(materialLabel4);
            panel1.Controls.Add(fileNameLabel);
            panel1.Location = new Point(228, 589);
            panel1.Name = "panel1";
            panel1.Size = new Size(951, 177);
            panel1.TabIndex = 7;
            panel1.Paint += panel1_Paint;
            // 
            // materialLabel5
            // 
            materialLabel5.AutoSize = true;
            materialLabel5.Depth = 0;
            materialLabel5.Enabled = false;
            materialLabel5.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel5.ForeColor = SystemColors.ActiveCaption;
            materialLabel5.Location = new Point(7, 123);
            materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel5.Name = "materialLabel5";
            materialLabel5.Size = new Size(96, 19);
            materialLabel5.TabIndex = 2;
            materialLabel5.Text = "Date Created:";
            // 
            // materialLabel4
            // 
            materialLabel4.AutoSize = true;
            materialLabel4.Depth = 0;
            materialLabel4.Enabled = false;
            materialLabel4.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel4.Location = new Point(7, 75);
            materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel4.Name = "materialLabel4";
            materialLabel4.Size = new Size(64, 19);
            materialLabel4.TabIndex = 1;
            materialLabel4.Text = "File Size:";
            // 
            // fileNameLabel
            // 
            fileNameLabel.AutoSize = true;
            fileNameLabel.Depth = 0;
            fileNameLabel.Enabled = false;
            fileNameLabel.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            fileNameLabel.Location = new Point(7, 30);
            fileNameLabel.MouseState = MaterialSkin.MouseState.HOVER;
            fileNameLabel.Name = "fileNameLabel";
            fileNameLabel.Size = new Size(112, 19);
            fileNameLabel.TabIndex = 0;
            fileNameLabel.Text = "Mod File Name:";
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
            applicationCloseButton.FlatAppearance.MouseDownBackColor = Color.Red;
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
            // materialButton3
            // 
            materialButton3.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButton3.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButton3.Depth = 0;
            materialButton3.HighEmphasis = true;
            materialButton3.Icon = null;
            materialButton3.Location = new Point(66, 139);
            materialButton3.Margin = new Padding(4, 6, 4, 6);
            materialButton3.MouseState = MaterialSkin.MouseState.HOVER;
            materialButton3.Name = "materialButton3";
            materialButton3.NoAccentTextColor = Color.Empty;
            materialButton3.Size = new Size(112, 36);
            materialButton3.TabIndex = 9;
            materialButton3.Text = "Import Mod";
            materialButton3.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButton3.UseAccentColor = false;
            materialButton3.UseVisualStyleBackColor = true;
            // 
            // materialLabel1
            // 
            materialLabel1.AutoSize = true;
            materialLabel1.BackColor = Color.Transparent;
            materialLabel1.Depth = 0;
            materialLabel1.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel1.ForeColor = Color.White;
            materialLabel1.Location = new Point(228, 107);
            materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(63, 19);
            materialLabel1.TabIndex = 10;
            materialLabel1.Text = "All Mods";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Radius_Icon_1024x1024px;
            pictureBox1.Location = new Point(41, 9);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(65, 51);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // settingsMaterialButton
            // 
            settingsMaterialButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            settingsMaterialButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            settingsMaterialButton.Depth = 0;
            settingsMaterialButton.HighEmphasis = true;
            settingsMaterialButton.Icon = null;
            settingsMaterialButton.Location = new Point(1250, 15);
            settingsMaterialButton.Margin = new Padding(4, 6, 4, 6);
            settingsMaterialButton.MouseState = MaterialSkin.MouseState.HOVER;
            settingsMaterialButton.Name = "settingsMaterialButton";
            settingsMaterialButton.NoAccentTextColor = Color.Empty;
            settingsMaterialButton.Size = new Size(90, 36);
            settingsMaterialButton.TabIndex = 9;
            settingsMaterialButton.Text = "Settings";
            settingsMaterialButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            settingsMaterialButton.UseAccentColor = false;
            settingsMaterialButton.UseVisualStyleBackColor = true;
            settingsMaterialButton.Click += materialButton2_Click;
            // 
            // materialButton1
            // 
            materialButton1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButton1.Depth = 0;
            materialButton1.HighEmphasis = true;
            materialButton1.Icon = null;
            materialButton1.Location = new Point(1165, 15);
            materialButton1.Margin = new Padding(4, 6, 4, 6);
            materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            materialButton1.Name = "materialButton1";
            materialButton1.NoAccentTextColor = Color.Empty;
            materialButton1.Size = new Size(64, 36);
            materialButton1.TabIndex = 5;
            materialButton1.Text = "Play";
            materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButton1.UseAccentColor = false;
            materialButton1.UseVisualStyleBackColor = true;
            materialButton1.Click += materialButton1_Click_1;
            // 
            // NavBar
            // 
            NavBar.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            NavBar.BackColor = Color.Black;
            NavBar.Controls.Add(materialLabel2);
            NavBar.Controls.Add(materialButton1);
            NavBar.Controls.Add(settingsMaterialButton);
            NavBar.Controls.Add(pictureBox1);
            NavBar.ForeColor = Color.FromArgb(255, 192, 128);
            NavBar.Location = new Point(-8, 28);
            NavBar.Name = "NavBar";
            NavBar.Size = new Size(1382, 67);
            NavBar.TabIndex = 2;
            // 
            // materialLabel2
            // 
            materialLabel2.AutoSize = true;
            materialLabel2.Depth = 0;
            materialLabel2.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel2.Location = new Point(112, 25);
            materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel2.Name = "materialLabel2";
            materialLabel2.Size = new Size(131, 19);
            materialLabel2.TabIndex = 10;
            materialLabel2.Text = "ITR Mod Launcher";
            // 
            // materialButton2
            // 
            materialButton2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButton2.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButton2.Depth = 0;
            materialButton2.HighEmphasis = true;
            materialButton2.Icon = null;
            materialButton2.Location = new Point(76, 187);
            materialButton2.Margin = new Padding(4, 6, 4, 6);
            materialButton2.MouseState = MaterialSkin.MouseState.HOVER;
            materialButton2.Name = "materialButton2";
            materialButton2.NoAccentTextColor = Color.Empty;
            materialButton2.Size = new Size(88, 36);
            materialButton2.TabIndex = 11;
            materialButton2.Text = "Profiles";
            materialButton2.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButton2.UseAccentColor = false;
            materialButton2.UseVisualStyleBackColor = true;
            materialButton2.Click += materialButton2_Click_1;
            // 
            // contextMenuStrip2
            // 
            contextMenuStrip2.Name = "contextMenuStrip2";
            contextMenuStrip2.Size = new Size(61, 4);
            contextMenuStrip2.Opening += contextMenuStrip2_Opening;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(1374, 822);
            Controls.Add(materialButton2);
            Controls.Add(materialLabel1);
            Controls.Add(materialButton3);
            Controls.Add(windowBorderPanel);
            Controls.Add(panel1);
            Controls.Add(alphaBuildLabel);
            Controls.Add(NavBar);
            Controls.Add(modsCheckedListBox);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "      ";
            Load += Form1_Load;
            MouseClick += Form1_MouseClick;
            contextMenuStrip1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            windowBorderPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            NavBar.ResumeLayout(false);
            NavBar.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Panel NavBar;
        private Label alphaBuildLabel;
        private CheckedListBox modsCheckedListBox;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem renameModsToolStripMenuItem;
        private Panel panel1;
        private Panel windowBorderPanel;
        private Button applicationCloseButton;
        private MaterialSkin.Controls.MaterialButton materialButton1;
        private MaterialSkin.Controls.MaterialButton settingsMaterialButton;
        private MaterialSkin.Controls.MaterialButton materialButton3;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel fileNameLabel;
        private MaterialSkin.Controls.MaterialButton materialButton2;
        private ContextMenuStrip contextMenuStrip2;
    }
}
