using System.Drawing.Drawing2D;
using System.Diagnostics;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Text;

namespace ITRModLoader
{
    public partial class Form1 : MaterialForm
    {
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;
        private MaterialSkinManager materialSkinManager;

        public Form1()
        {
            InitializeComponent();
            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.EnforceBackcolorOnAllComponents = true;
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Red600, Primary.Blue800, Primary.Red100, Accent.DeepOrange700, TextShade.WHITE);

            materialSkinManager.AddFormToManage(this);
        }

        // Constants for window resizing
        private const int WM_NCHITTEST = 0x84;
        private const int HTLEFT = 10;
        private const int HTRIGHT = 11;
        private const int HTTOP = 12;
        private const int HTTOPLEFT = 13;
        private const int HTTOPRIGHT = 14;
        private const int HTBOTTOM = 15;
        private const int HTBOTTOMLEFT = 16;
        private const int HTBOTTOMRIGHT = 17;

        protected override void WndProc(ref Message m)
        {
            //Overwrite Porcess to reate Cusotm Resizable Borders
            base.WndProc(ref m);

            // Allow resizing by dragging edges
            if (m.Msg == WM_NCHITTEST)
            {
                var cursorPosition = PointToClient(Cursor.Position);

                int gripSize = 10; // Thickness of the resize border

                if (cursorPosition.X <= gripSize && cursorPosition.Y <= gripSize)
                    m.Result = (IntPtr)HTTOPLEFT;
                else if (cursorPosition.X >= Width - gripSize && cursorPosition.Y <= gripSize)
                    m.Result = (IntPtr)HTTOPRIGHT;
                else if (cursorPosition.X <= gripSize && cursorPosition.Y >= Height - gripSize)
                    m.Result = (IntPtr)HTBOTTOMLEFT;
                else if (cursorPosition.X >= Width - gripSize && cursorPosition.Y >= Height - gripSize)
                    m.Result = (IntPtr)HTBOTTOMRIGHT;
                else if (cursorPosition.X <= gripSize)
                    m.Result = (IntPtr)HTLEFT;
                else if (cursorPosition.X >= Width - gripSize)
                    m.Result = (IntPtr)HTRIGHT;
                else if (cursorPosition.Y <= gripSize)
                    m.Result = (IntPtr)HTTOP;
                else if (cursorPosition.Y >= Height - gripSize)
                    m.Result = (IntPtr)HTBOTTOM;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            //Assign Mod Paths TODO: Support more than PAK mods
            string mainGamePath = Properties.Settings.Default.GameFolderPath;
            string relativeModsPath = @"IntoTheRadius\Content\Paks";
            string pakModsFolderPath = Path.Combine(mainGamePath, relativeModsPath);
            if (Directory.Exists(pakModsFolderPath))
            {
                MessageBox.Show("Mods Folder Found! You Did It!");
                modsCheckedListBox.Items.Clear(); //Remove Debug Text
                string[] enabledMods = Directory.GetFiles(pakModsFolderPath, "*.pak");
                foreach (string mod in enabledMods)
                {
                    // Skip core files containing "pakchunk"
                    if (mod.ToLower().Contains("pakchunk"))
                    {
                        continue;
                    }
                    string modName = Path.GetFileName(mod);
                    materialCheckedListBox1.Items.Add(modName, true);  // Checked = Enabled
                }
            }
            else
            {
                MessageBox.Show("Mods folder not found! Big Sad");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void playButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Enter The Zone?", "Ready Explorer?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Process.Start(Path.Combine(Properties.Settings.Default.GameFolderPath, @"IntoTheRadius.exe"));
            }
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // TODO: Use ModConfig.JSON to return Original Mod Name
            fileNameLabel.Text = $"Mod File Name: {modsCheckedListBox.Text}";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void contextMenuStrip1_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void renameModsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Click(object sender, EventArgs e)
        {
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            //Draw ITR Native Colors //TODO: Create Appliation Wide color variables for future theme engine
            ControlPaint.DrawBorder(e.Graphics, panel1.ClientRectangle, Color.FromArgb(227, 30, 40), ButtonBorderStyle.Solid);
        }

        private void fileNameLabel_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }

        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point diff = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(diff));
            }
        }

        private void panel2_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void materialButton1_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void materialButton2_Click(object sender, EventArgs e)
        {
            SettingsForm settingsForm = new SettingsForm(this);
            settingsForm.ShowDialog();  // Open as modal dialog
        }

        private void materialCheckedListBox1_Paint(object sender, PaintEventArgs e)
        {
        }
        private void materialCheckedListBox1_Click(object sender, EventArgs e)
        {
        }

        private void materialCheckedListBox1_MouseHover(object sender, EventArgs e)
        {
        }

        private void materialCheckedListBox1_TabIndexChanged(object sender, EventArgs e)
        {

        }
    }
}