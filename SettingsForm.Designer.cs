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
            panel1 = new Panel();
            label1 = new Label();
            gamePathLabel = new Label();
            label2 = new Label();
            settingsGamePathTextBox = new TextBox();
            settingsAppPathTextBox = new TextBox();
            gamePathFindButton = new Button();
            appPathFindButton = new Button();
            button4 = new Button();
            savveDataButton = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(802, 56);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(134, 37);
            label1.TabIndex = 0;
            label1.Text = "SETTINGS";
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
            label2.Location = new Point(12, 156);
            label2.Name = "label2";
            label2.Size = new Size(131, 21);
            label2.TabIndex = 2;
            label2.Text = "Application Data";
            label2.Click += label2_Click;
            // 
            // settingsGamePathTextBox
            // 
            settingsGamePathTextBox.Location = new Point(12, 94);
            settingsGamePathTextBox.Name = "settingsGamePathTextBox";
            settingsGamePathTextBox.Size = new Size(651, 23);
            settingsGamePathTextBox.TabIndex = 3;
            settingsGamePathTextBox.TextChanged += gamePathTextBox_TextChanged;
            // 
            // settingsAppPathTextBox
            // 
            settingsAppPathTextBox.Location = new Point(12, 180);
            settingsAppPathTextBox.Name = "settingsAppPathTextBox";
            settingsAppPathTextBox.Size = new Size(651, 23);
            settingsAppPathTextBox.TabIndex = 4;
            settingsAppPathTextBox.TextChanged += appPathTextBox_TextChanged;
            // 
            // gamePathFindButton
            // 
            gamePathFindButton.Location = new Point(12, 123);
            gamePathFindButton.Name = "gamePathFindButton";
            gamePathFindButton.Size = new Size(95, 25);
            gamePathFindButton.TabIndex = 5;
            gamePathFindButton.Text = "Find";
            gamePathFindButton.UseVisualStyleBackColor = true;
            gamePathFindButton.Click += gamePathFindButton_Click;
            // 
            // appPathFindButton
            // 
            appPathFindButton.Location = new Point(12, 209);
            appPathFindButton.Name = "appPathFindButton";
            appPathFindButton.Size = new Size(95, 25);
            appPathFindButton.TabIndex = 6;
            appPathFindButton.Text = "Find";
            appPathFindButton.UseVisualStyleBackColor = true;
            appPathFindButton.Click += appPathFindButton_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.White;
            button4.FlatAppearance.BorderColor = Color.Black;
            button4.FlatAppearance.BorderSize = 2;
            button4.FlatStyle = FlatStyle.Flat;
            button4.ForeColor = SystemColors.ControlText;
            button4.Location = new Point(571, 251);
            button4.Name = "button4";
            button4.Size = new Size(92, 28);
            button4.TabIndex = 8;
            button4.Text = "Cancel";
            button4.UseVisualStyleBackColor = false;
            // 
            // savveDataButton
            // 
            savveDataButton.BackColor = Color.White;
            savveDataButton.FlatAppearance.BorderColor = Color.Red;
            savveDataButton.FlatAppearance.BorderSize = 2;
            savveDataButton.FlatStyle = FlatStyle.Flat;
            savveDataButton.Location = new Point(460, 251);
            savveDataButton.Name = "savveDataButton";
            savveDataButton.Size = new Size(92, 28);
            savveDataButton.TabIndex = 9;
            savveDataButton.Text = "Save";
            savveDataButton.UseVisualStyleBackColor = false;
            savveDataButton.Click += saveDataButton_Click;
            // 
            // SettingsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(224, 224, 224);
            ClientSize = new Size(679, 291);
            Controls.Add(savveDataButton);
            Controls.Add(button4);
            Controls.Add(appPathFindButton);
            Controls.Add(gamePathFindButton);
            Controls.Add(settingsAppPathTextBox);
            Controls.Add(settingsGamePathTextBox);
            Controls.Add(label2);
            Controls.Add(gamePathLabel);
            Controls.Add(panel1);
            Name = "SettingsForm";
            Text = "Form2";
            Load += SettingsForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label gamePathLabel;
        private Label label2;
        private TextBox settingsGamePathTextBox;
        private TextBox settingsAppPathTextBox;
        private Button gamePathFindButton;
        private Button appPathFindButton;
        private Button button4;
        private Button savveDataButton;
    }
}