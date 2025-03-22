namespace ITRModLoader
{
    partial class SettingsForm
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
            gamePathLabel = new Label();
            label2 = new Label();
            materialFindButton = new MaterialSkin.Controls.MaterialButton();
            appPathFindButton = new MaterialSkin.Controls.MaterialButton();
            settingsGamePathTextBox = new MaterialSkin.Controls.MaterialMaskedTextBox();
            settingsAppPathTextBox = new MaterialSkin.Controls.MaterialMaskedTextBox();
            materialButton3 = new MaterialSkin.Controls.MaterialButton();
            materialButton4 = new MaterialSkin.Controls.MaterialButton();
            SuspendLayout();
            // 
            // gamePathLabel
            // 
            gamePathLabel.AutoSize = true;
            gamePathLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gamePathLabel.Location = new Point(12, 70);
            gamePathLabel.Name = "gamePathLabel";
            gamePathLabel.Size = new Size(88, 21);
            gamePathLabel.TabIndex = 1;
            gamePathLabel.Text = "Game Path";
            gamePathLabel.Click += gamePathLabel_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 208);
            label2.Name = "label2";
            label2.Size = new Size(131, 21);
            label2.TabIndex = 2;
            label2.Text = "Application Data";
            label2.Click += label2_Click;
            // 
            // materialFindButton
            // 
            materialFindButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialFindButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialFindButton.Depth = 0;
            materialFindButton.HighEmphasis = true;
            materialFindButton.Icon = null;
            materialFindButton.Location = new Point(12, 151);
            materialFindButton.Margin = new Padding(4, 6, 4, 6);
            materialFindButton.MouseState = MaterialSkin.MouseState.HOVER;
            materialFindButton.Name = "materialFindButton";
            materialFindButton.NoAccentTextColor = Color.Empty;
            materialFindButton.Size = new Size(64, 36);
            materialFindButton.TabIndex = 10;
            materialFindButton.Text = "Find";
            materialFindButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            materialFindButton.UseAccentColor = false;
            materialFindButton.UseVisualStyleBackColor = true;
            materialFindButton.Click += materialButton1_Click;
            // 
            // appPathFindButton
            // 
            appPathFindButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            appPathFindButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            appPathFindButton.Depth = 0;
            appPathFindButton.HighEmphasis = true;
            appPathFindButton.Icon = null;
            appPathFindButton.Location = new Point(12, 289);
            appPathFindButton.Margin = new Padding(4, 6, 4, 6);
            appPathFindButton.MouseState = MaterialSkin.MouseState.HOVER;
            appPathFindButton.Name = "appPathFindButton";
            appPathFindButton.NoAccentTextColor = Color.Empty;
            appPathFindButton.Size = new Size(64, 36);
            appPathFindButton.TabIndex = 11;
            appPathFindButton.Text = "Find";
            appPathFindButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            appPathFindButton.UseAccentColor = false;
            appPathFindButton.UseVisualStyleBackColor = true;
            appPathFindButton.Click += appPathFindButton_Click_1;
            // 
            // settingsGamePathTextBox
            // 
            settingsGamePathTextBox.AllowPromptAsInput = true;
            settingsGamePathTextBox.AnimateReadOnly = false;
            settingsGamePathTextBox.AsciiOnly = false;
            settingsGamePathTextBox.BackgroundImageLayout = ImageLayout.None;
            settingsGamePathTextBox.BeepOnError = false;
            settingsGamePathTextBox.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            settingsGamePathTextBox.Depth = 0;
            settingsGamePathTextBox.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            settingsGamePathTextBox.HidePromptOnLeave = false;
            settingsGamePathTextBox.HideSelection = true;
            settingsGamePathTextBox.InsertKeyMode = InsertKeyMode.Default;
            settingsGamePathTextBox.LeadingIcon = null;
            settingsGamePathTextBox.Location = new Point(12, 94);
            settingsGamePathTextBox.Mask = "";
            settingsGamePathTextBox.MaxLength = 32767;
            settingsGamePathTextBox.MouseState = MaterialSkin.MouseState.OUT;
            settingsGamePathTextBox.Name = "settingsGamePathTextBox";
            settingsGamePathTextBox.PasswordChar = '\0';
            settingsGamePathTextBox.PrefixSuffixText = null;
            settingsGamePathTextBox.PromptChar = '_';
            settingsGamePathTextBox.ReadOnly = false;
            settingsGamePathTextBox.RejectInputOnFirstFailure = false;
            settingsGamePathTextBox.ResetOnPrompt = true;
            settingsGamePathTextBox.ResetOnSpace = true;
            settingsGamePathTextBox.RightToLeft = RightToLeft.No;
            settingsGamePathTextBox.SelectedText = "";
            settingsGamePathTextBox.SelectionLength = 0;
            settingsGamePathTextBox.SelectionStart = 0;
            settingsGamePathTextBox.ShortcutsEnabled = true;
            settingsGamePathTextBox.Size = new Size(545, 48);
            settingsGamePathTextBox.SkipLiterals = true;
            settingsGamePathTextBox.TabIndex = 12;
            settingsGamePathTextBox.TabStop = false;
            settingsGamePathTextBox.Text = "materialMaskedTextBox1";
            settingsGamePathTextBox.TextAlign = HorizontalAlignment.Left;
            settingsGamePathTextBox.TextMaskFormat = MaskFormat.IncludeLiterals;
            settingsGamePathTextBox.TrailingIcon = null;
            settingsGamePathTextBox.UseSystemPasswordChar = false;
            settingsGamePathTextBox.ValidatingType = null;
            settingsGamePathTextBox.Click += settingsGamePathTextBox_Click;
            // 
            // settingsAppPathTextBox
            // 
            settingsAppPathTextBox.AllowPromptAsInput = true;
            settingsAppPathTextBox.AnimateReadOnly = false;
            settingsAppPathTextBox.AsciiOnly = false;
            settingsAppPathTextBox.BackgroundImageLayout = ImageLayout.None;
            settingsAppPathTextBox.BeepOnError = false;
            settingsAppPathTextBox.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            settingsAppPathTextBox.Depth = 0;
            settingsAppPathTextBox.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            settingsAppPathTextBox.HidePromptOnLeave = false;
            settingsAppPathTextBox.HideSelection = true;
            settingsAppPathTextBox.InsertKeyMode = InsertKeyMode.Default;
            settingsAppPathTextBox.LeadingIcon = null;
            settingsAppPathTextBox.Location = new Point(12, 232);
            settingsAppPathTextBox.Mask = "";
            settingsAppPathTextBox.MaxLength = 32767;
            settingsAppPathTextBox.MouseState = MaterialSkin.MouseState.OUT;
            settingsAppPathTextBox.Name = "settingsAppPathTextBox";
            settingsAppPathTextBox.PasswordChar = '\0';
            settingsAppPathTextBox.PrefixSuffixText = null;
            settingsAppPathTextBox.PromptChar = '_';
            settingsAppPathTextBox.ReadOnly = false;
            settingsAppPathTextBox.RejectInputOnFirstFailure = false;
            settingsAppPathTextBox.ResetOnPrompt = true;
            settingsAppPathTextBox.ResetOnSpace = true;
            settingsAppPathTextBox.RightToLeft = RightToLeft.No;
            settingsAppPathTextBox.SelectedText = "";
            settingsAppPathTextBox.SelectionLength = 0;
            settingsAppPathTextBox.SelectionStart = 0;
            settingsAppPathTextBox.ShortcutsEnabled = true;
            settingsAppPathTextBox.Size = new Size(545, 48);
            settingsAppPathTextBox.SkipLiterals = true;
            settingsAppPathTextBox.TabIndex = 13;
            settingsAppPathTextBox.TabStop = false;
            settingsAppPathTextBox.Text = "materialMaskedTextBox2";
            settingsAppPathTextBox.TextAlign = HorizontalAlignment.Left;
            settingsAppPathTextBox.TextMaskFormat = MaskFormat.IncludeLiterals;
            settingsAppPathTextBox.TrailingIcon = null;
            settingsAppPathTextBox.UseSystemPasswordChar = false;
            settingsAppPathTextBox.ValidatingType = null;
            // 
            // materialButton3
            // 
            materialButton3.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButton3.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButton3.Depth = 0;
            materialButton3.HighEmphasis = true;
            materialButton3.Icon = null;
            materialButton3.Location = new Point(557, 352);
            materialButton3.Margin = new Padding(4, 6, 4, 6);
            materialButton3.MouseState = MaterialSkin.MouseState.HOVER;
            materialButton3.Name = "materialButton3";
            materialButton3.NoAccentTextColor = Color.Empty;
            materialButton3.Size = new Size(64, 36);
            materialButton3.TabIndex = 14;
            materialButton3.Text = "save";
            materialButton3.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButton3.UseAccentColor = false;
            materialButton3.UseVisualStyleBackColor = true;
            materialButton3.Click += materialButton3_Click;
            // 
            // materialButton4
            // 
            materialButton4.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButton4.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButton4.Depth = 0;
            materialButton4.HighEmphasis = true;
            materialButton4.Icon = null;
            materialButton4.Location = new Point(642, 352);
            materialButton4.Margin = new Padding(4, 6, 4, 6);
            materialButton4.MouseState = MaterialSkin.MouseState.HOVER;
            materialButton4.Name = "materialButton4";
            materialButton4.NoAccentTextColor = Color.Empty;
            materialButton4.Size = new Size(77, 36);
            materialButton4.TabIndex = 15;
            materialButton4.Text = "cancel";
            materialButton4.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButton4.UseAccentColor = false;
            materialButton4.UseVisualStyleBackColor = true;
            materialButton4.Click += materialButton4_Click;
            // 
            // SettingsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(224, 224, 224);
            ClientSize = new Size(741, 397);
            Controls.Add(materialButton4);
            Controls.Add(materialButton3);
            Controls.Add(settingsAppPathTextBox);
            Controls.Add(settingsGamePathTextBox);
            Controls.Add(appPathFindButton);
            Controls.Add(materialFindButton);
            Controls.Add(label2);
            Controls.Add(gamePathLabel);
            Name = "SettingsForm";
            Text = "SETTINGS";
            Load += SettingsForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label gamePathLabel;
        private Label label2;
        private MaterialSkin.Controls.MaterialButton materialFindButton;
        private MaterialSkin.Controls.MaterialButton appPathFindButton;
        private MaterialSkin.Controls.MaterialMaskedTextBox settingsGamePathTextBox;
        private MaterialSkin.Controls.MaterialMaskedTextBox settingsAppPathTextBox;
        private MaterialSkin.Controls.MaterialButton materialButton3;
        private MaterialSkin.Controls.MaterialButton materialButton4;
    }
}