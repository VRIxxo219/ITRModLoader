using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace ITRModLoader
{
    public partial class SettingsForm : MaterialForm
    {
        private MaterialSkinManager materialSkinManager;

        public SettingsForm(Form parent)
        {
            InitializeComponent();

            //Open Settings Form in middle of Parent Form
            if (parent != null)
            {
                int x = parent.Location.X + (parent.Width - this.Width) / 2;
                int y = parent.Location.Y + (parent.Height - this.Height) / 2;
                this.StartPosition = FormStartPosition.Manual;
                this.Location = new System.Drawing.Point(x, y);
            }

            //Load Data from Settings
            settingsGamePathTextBox.Text = Properties.Settings.Default.GameFolderPath;
            settingsAppPathTextBox.Text = Properties.Settings.Default.AppFolderPath;

            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.EnforceBackcolorOnAllComponents = false;
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;

            materialSkinManager.AddFormToManage(this);
        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {

        }

        private void gamePathTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void gamePathFindButton_Click(object sender, EventArgs e)
        {
            //TODO: Create Folder Handler
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.InitialDirectory = "c:\\";

            if (fbd.ShowDialog() == DialogResult.OK)
            {
                // Get the selected file path
                string filePath = fbd.SelectedPath;
                //Write Path to TextBox
                settingsGamePathTextBox.Text = filePath;
            }
        }

        private void gamePathLabel_Click(object sender, EventArgs e)
        {
        }

        private void appPathFindButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.InitialDirectory = "c:\\";

            if (fbd.ShowDialog() == DialogResult.OK)
            {
                string filePath = fbd.SelectedPath;
                settingsAppPathTextBox.Text = filePath;
            }
        }

        private void saveDataButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to continue?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                MessageBox.Show("Confirmed!");
                Properties.Settings.Default.GameFolderPath = settingsGamePathTextBox.Text;
                Properties.Settings.Default.AppFolderPath = settingsAppPathTextBox.Text;
                Properties.Settings.Default.Save();
            }
            else
            {
                MessageBox.Show("Cancelled.");
                settingsGamePathTextBox.Text = Properties.Settings.Default.GameFolderPath;
                settingsAppPathTextBox.Text = Properties.Settings.Default.AppFolderPath;
            }
        }

        private void appPathTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
