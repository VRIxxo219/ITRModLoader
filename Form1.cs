﻿using System.Drawing.Drawing2D;
using System.Diagnostics;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Text;
using ITRModLoader.Logic;
using System.IO;

namespace ITRModLoader
{
    public partial class Form1 : MaterialForm
    {
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;
        private MaterialSkinManager materialSkinManager;
        private ModManager _modManager;
        public Form1()
        {
            InitializeComponent();

            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.EnforceBackcolorOnAllComponents = true;
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Red700, Primary.Red900, Primary.Red100, Accent.DeepOrange700, TextShade.WHITE);
            materialSkinManager.AddFormToManage(this);
            string gameFolderPath = Properties.Settings.Default.GameFolderPath;
            _modManager = new ModManager(gameFolderPath);

            modsCheckedListBox.ColumnWidth = 50; // Set the width for the priority column\
            alphaBuildLabel.Left = (this.ClientSize.Width - alphaBuildLabel.Width) / 2;
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
            base.WndProc(ref m);

            if (m.Msg == WM_NCHITTEST)
            {
                var cursorPosition = PointToClient(Cursor.Position);
                int gripSize = 10;

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

        public void LoadMods()
        {
            List<string> excludedFiles = new List<string>
    {
        "pakchunk0optional-WindowsNoEditor.pak",
        "pakchunk0-WindowsNoEditor.pak",
        "pakchunk1optional-WindowsNoEditor.pak",
        "pakchunk1-WindowsNoEditor.pak"
    };
            string mainGamePath = Properties.Settings.Default.GameFolderPath;
            string pakModsFolderPath = Path.Combine(mainGamePath, "IntoTheRadius", "Content", "Paks");
            string deactivatedModsPath = Path.Combine(Path.GetDirectoryName(pakModsFolderPath), "ITR_ModStage");

            modsCheckedListBox.Items.Clear();

            // Add headers
            modsCheckedListBox.AddHeader("Active Mods");
            //DEBUG Fake Priority
            if (Directory.Exists(pakModsFolderPath))
            {
                int debugPriority = 0;
                string[] activeMods = Directory.GetFiles(pakModsFolderPath, "*.pak");
                foreach (string mod in activeMods)
                {
                    string modName = Path.GetFileName(mod);
                    if (!excludedFiles.Contains(modName, StringComparer.OrdinalIgnoreCase))
                    {
                        // Create ModItem with default priority (you can adjust this logic)
                        int priority = debugPriority += 1;
                        modsCheckedListBox.AddModItem(new ModItem { Name = modName, Priority = priority, IsSelected = true });
                    }
                }
            }

            modsCheckedListBox.AddHeader("Inactive Mods");

            if (Directory.Exists(deactivatedModsPath))
            {
                string[] deactivatedMods = Directory.GetFiles(deactivatedModsPath, "*.pak");
                foreach (string mod in deactivatedMods)
                {
                    string modName = Path.GetFileName(mod);
                    string destination = Path.Combine(pakModsFolderPath, modName);

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
                            }
                        }
                    }
                    else
                    {
                        // Link priority with ModLoader.config.json || TODO: Create Priority handler
                        int priority = 0;
                        modsCheckedListBox.AddModItem(new ModItem { Name = modName, Priority = priority, IsSelected = false });
                    }
                }
            }
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

        private void button2_Click(object sender, EventArgs e)
        {
            // Cast to ModItem instead of string
            var selectedModItems = modsCheckedListBox.CheckedItems.Cast<ModItem>().ToList();

            // Extract the mod names from the ModItem objects
            var selectedMods = selectedModItems.Select(modItem => modItem.Name).ToList();

            _modManager.MoveUnselectedMods(selectedMods.ToArray());
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

        private void materialButton1_Click1(object sender, EventArgs e)
        {
            string gameFolderPath = Properties.Settings.Default.GameFolderPath;
            string pakModsFolderPath = PathManager.GetPaksFolderPath(gameFolderPath);
            string deactivatedModsPath = PathManager.GetDeactivatedModsPath(gameFolderPath);

            if (!Directory.Exists(pakModsFolderPath))
            {
                MessageBox.Show($"Paks folder not found at: {pakModsFolderPath}");
                return;
            }

            var selectedModItems = modsCheckedListBox.GetCheckedModItems();
            var selectedMods = selectedModItems.Select(modItem => modItem.Name).ToList();
            _modManager.MoveUnselectedMods(selectedMods.ToArray());

            string gameExePath = PathManager.GetGameExePath(gameFolderPath);
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
            using (var settingsForm = new SettingsForm(this))
            {
                settingsForm.ShowDialog();
            }
        }

        private void materialButton2_Click_1(object sender, EventArgs e)
        {
        }

        private void contextMenuStrip2_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {
        }

        private void materialButton3_Click(object sender, EventArgs e)
        {
        }

        private void alphaBuildLabel_Click(object sender, EventArgs e)
        {

        }
    }
}