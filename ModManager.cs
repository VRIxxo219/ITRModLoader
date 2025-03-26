using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ITRModLoader.Logic
{
    public class ModManager
    {
        private readonly string _gameFolderPath;
        private readonly List<string> _excludedFiles;

        public ModManager(string gameFolderPath)
        {
            _gameFolderPath = gameFolderPath;
            _excludedFiles = new List<string>
            {
                "pakchunk0optional-WindowsNoEditor.pak",
                "pakchunk0-WindowsNoEditor.pak",
                "pakchunk1optional-WindowsNoEditor.pak",
                "pakchunk1-WindowsNoEditor.pak"
            };
        }

        public List<string> LoadMods()
        {
            string pakModsFolderPath = Path.Combine(_gameFolderPath, "IntoTheRadius", "Content", "Paks");
            string deactivatedModsPath = Path.Combine(Path.GetDirectoryName(pakModsFolderPath), "ITR_ModStage");

            List<string> activeMods = new List<string>();
            List<string> deactivatedMods = new List<string>();

            if (Directory.Exists(pakModsFolderPath))
            {
                activeMods = Directory.GetFiles(pakModsFolderPath, "*.pak")
                    .Where(file => !_excludedFiles.Contains(Path.GetFileName(file), StringComparer.OrdinalIgnoreCase))
                    .Select(Path.GetFileName)
                    .ToList();
            }

            if (Directory.Exists(deactivatedModsPath))
            {
                deactivatedMods = Directory.GetFiles(deactivatedModsPath, "*.pak")
                    .Where(file => !_excludedFiles.Contains(Path.GetFileName(file), StringComparer.OrdinalIgnoreCase))
                    .Select(Path.GetFileName)
                    .ToList();
            }

            return activeMods.Concat(deactivatedMods).ToList();
        }

        public void MoveUnselectedMods(string[] selectedMods)
        {
            string pakModsFolderPath = Path.Combine(_gameFolderPath, "IntoTheRadius", "Content", "Paks");
            string deactivatedModsPath = Path.Combine(Path.GetDirectoryName(pakModsFolderPath), "ITR_ModStage");

            if (!Directory.Exists(deactivatedModsPath))
                Directory.CreateDirectory(deactivatedModsPath);

            // Move unselected mods to deactivated folder
            var activeMods = Directory.GetFiles(pakModsFolderPath, "*.pak")
                .Where(file => !_excludedFiles.Contains(Path.GetFileName(file), StringComparer.OrdinalIgnoreCase))
                .ToList();

            foreach (var mod in activeMods)
            {
                string modName = Path.GetFileName(mod);
                if (!selectedMods.Contains(modName))
                {
                    string destination = Path.Combine(deactivatedModsPath, modName);
                    File.Move(mod, destination);
                }
            }

            // Move selected mods back to active folder from deactivated folder
            if (Directory.Exists(deactivatedModsPath))
            {
                var deactivatedMods = Directory.GetFiles(deactivatedModsPath, "*.pak")
                    .Where(file => !_excludedFiles.Contains(Path.GetFileName(file), StringComparer.OrdinalIgnoreCase))
                    .ToList();

                foreach (var mod in deactivatedMods)
                {
                    string modName = Path.GetFileName(mod);
                    if (selectedMods.Contains(modName))
                    {
                        string destination = Path.Combine(pakModsFolderPath, modName);
                        if (!File.Exists(destination))
                        {
                            File.Move(mod, destination);
                        }
                        else
                        {
                            //Reserved for Processing mods already existing 
                        }
                    }
                }
            }
        }
    }
}