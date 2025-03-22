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
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Red600, Primary.Red900, Primary.Red100, Accent.DeepOrange700, TextShade.WHITE);

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
            LoadMods();
        }

        private void LoadMods()
        {
            // Define the list of excluded core game files
            List<string> excludedFiles = new List<string>
            {
                "pakchunk0optional-WindowsNoEditor.pak",
                "pakchunk0-WindowsNoEditor.pak",
                "pakchunk1optional-WindowsNoEditor.pak",
                "pakchunk1-WindowsNoEditor.pak"
            };
            string mainGamePath = Properties.Settings.Default.GameFolderPath;
            string relativeModsPath = @"IntoTheRadius\Content\Paks";
            string pakModsFolderPath = Path.Combine(mainGamePath, relativeModsPath);
            string deactivatedModsPath = Path.Combine(Path.GetDirectoryName(pakModsFolderPath), "ITR_ModStage");

            modsCheckedListBox.Items.Clear();

            // Load active mods
            if (Directory.Exists(pakModsFolderPath))
            {
                string[] activeMods = Directory.GetFiles(pakModsFolderPath, "*.pak");
                foreach (string mod in activeMods)
                {
                    string modName = Path.GetFileName(mod);
                    if (!excludedFiles.Contains(modName, StringComparer.OrdinalIgnoreCase))
                    {
                        modsCheckedListBox.Items.Add(modName, true);  // Checked = Enabled
                    }
                }
            }

            // Load deactivated mods
            if (Directory.Exists(deactivatedModsPath))
            {
                string[] deactivatedMods = Directory.GetFiles(deactivatedModsPath, "*.pak");
                foreach (string mod in deactivatedMods)
                {
                    string modName = Path.GetFileName(mod);
                    string destination = Path.Combine(pakModsFolderPath, modName);

                    // Move excluded files back to active folder
                    if (excludedFiles.Contains(modName, StringComparer.OrdinalIgnoreCase))
                    {
                        if (!File.Exists(destination))
                        {
                            try
                            {
                                File.Move(mod, destination);
                            }
                            catch
                            {
                                // Handle error if needed
                            }
                        }
                        else
                        {
                            try
                            {
                                File.Delete(mod);
                            }
                            catch
                            {
                                // Handle error if needed
                            }
                        }
                    }
                    else
                    {
                        modsCheckedListBox.Items.Add(modName, false);  // Unchecked = Disabled
                    }
                }
            }
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            // TODO: Use ModConfig.JSON to return Original Mod Name
            fileNameLabel.Text = $"Mod File Name: {modsCheckedListBox.Text}";
        }

        private void contextMenuStrip1_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void renameModsToolStripMenuItem_Click(object sender, EventArgs e)
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
            // Get the main ITR folder path from your settings
            string mainITRFolder = Properties.Settings.Default.GameFolderPath;

            // Construct the path to the Paks folder with the extra "IntoTheRadius" folder
            string pakModsFolderPath = Path.Combine(mainITRFolder, "IntoTheRadius", "Content", "Paks");
            string deactivatedModsPath = Path.Combine(Path.GetDirectoryName(pakModsFolderPath), "ITR_ModStage");

            // Check if the Paks folder exists
            if (!Directory.Exists(pakModsFolderPath))
            {
                MessageBox.Show($"Paks folder not found at: {pakModsFolderPath}");
                return;
            }

            // Get the list of selected mods
            List<string> selectedMods = new List<string>();
            foreach (var item in modsCheckedListBox.CheckedItems)
            {
                selectedMods.Add(item.ToString());
            }

            Console.WriteLine($"Selected mods: {string.Join(", ", selectedMods)}");

            // Create an instance of ModFileMover with the main ITR folder path
            ModFileMover modMover = new ModFileMover(mainITRFolder);

            // Debug: Show all mods before moving
            var allMods = Directory.GetFiles(pakModsFolderPath, "*.pak");
            Console.WriteLine($"Total mods found in active folder: {allMods.Length}");
            foreach (var mod in allMods)
            {
                Console.WriteLine($"Active mod: {Path.GetFileName(mod)}");
            }

            var allDeactivatedMods = Directory.GetFiles(deactivatedModsPath, "*.pak");
            Console.WriteLine($"Total mods found in deactivated folder: {allDeactivatedMods.Length}");
            foreach (var mod in allDeactivatedMods)
            {
                Console.WriteLine($"Deactivated mod: {Path.GetFileName(mod)}");
            }

            // Move unselected mods
            modMover.MoveUnselectedMods(selectedMods.ToArray());

            // Debug: Show all mods after moving
            var remainingMods = Directory.GetFiles(pakModsFolderPath, "*.pak");
            Console.WriteLine($"Total mods remaining in active folder: {remainingMods.Length}");
            foreach (var mod in remainingMods)
            {
                Console.WriteLine($"Remaining active mod: {Path.GetFileName(mod)}");
            }

            // Launch the game
            string gameExePath = Path.Combine(mainITRFolder, "IntoTheRadius", "IntoTheRadius.exe");
            if (File.Exists(gameExePath))
            {
                Process.Start(gameExePath);
            }
            else
            {
                MessageBox.Show($"Game executable not found at: {gameExePath}");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void materialButton2_Click(object sender, EventArgs e)
        {
            SettingsForm settingsForm = new SettingsForm(this);
            settingsForm.ShowDialog();  // Open as modal dialog
        }


        private void materialButton2_Click_1(object sender, EventArgs e)
        {

        }

        private void contextMenuStrip2_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }
    }
}