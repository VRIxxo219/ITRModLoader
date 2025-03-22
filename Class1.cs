using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ITRModLoader
{
    internal class ModFileMover
    {
        private string modFolderPath;
        private string deactivatedModspath;
        private List<string> excludedFiles = new List<string>
        {
            "pakchunk0optional-WindowsNoEditor.pak",
            "pakchunk0-WindowsNoEditor.pak",
            "pakchunk1optional-WindowsNoEditor.pak",
            "pakchunk1-WindowsNoEditor.pak"
        };

        public ModFileMover(string mainITRFolder)
        {
            // Construct the path to the Paks folder with the extra "IntoTheRadius" folder
            this.modFolderPath = Path.Combine(mainITRFolder, "IntoTheRadius", "Content", "Paks");

            // Create the path for the deactivated mods folder at the same level as the Paks folder
            this.deactivatedModspath = Path.Combine(
                Path.GetDirectoryName(this.modFolderPath),
                "ITR_ModStage"
            );

            // Ensure the "ITR_ModStage" folder exists
            if (!Directory.Exists(deactivatedModspath))
            {
                try
                {
                    Directory.CreateDirectory(deactivatedModspath);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error creating deactivated mods folder: {ex.Message}");
                    throw;
                }
            }

            Console.WriteLine($"Mod folder path: {modFolderPath}");
            Console.WriteLine($"Deactivated mods path: {deactivatedModspath}");
        }

        /// <summary>
        /// Moves unselected mods to the "ITR_ModStage" folder.
        /// </summary>
        public void MoveUnselectedMods(string[] selectedMods)
        {
            try
            {
                // Get all .pak files in the Paks directory
                var activeMods = Directory.GetFiles(modFolderPath, "*.pak");
                var deactivatedMods = Directory.GetFiles(deactivatedModspath, "*.pak");

                Console.WriteLine($"Total active mods found: {activeMods.Length}");
                Console.WriteLine($"Total deactivated mods found: {deactivatedMods.Length}");

                // Process active mods - move unselected ones to deactivated folder
                foreach (var mod in activeMods)
                {
                    string modName = Path.GetFileName(mod);
                    string destination = Path.Combine(deactivatedModspath, modName);

                    Console.WriteLine($"Processing active mod: {modName}");

                    // Skip excluded files
                    if (excludedFiles.Contains(modName, StringComparer.OrdinalIgnoreCase))
                    {
                        Console.WriteLine($"Skipping excluded file: {modName}");
                        continue;
                    }

                    // Only move unselected mods
                    if (!selectedMods.Contains(modName, StringComparer.OrdinalIgnoreCase))
                    {
                        Console.WriteLine($"Mod {modName} is not selected for activation");

                        // Only move if it isn't already deactivated
                        if (!File.Exists(destination))
                        {
                            try
                            {
                                File.Move(mod, destination);
                                Console.WriteLine($"Moved {modName} to ITR_ModStage folder.");
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine($"Error moving {modName}: {ex.Message}");
                            }
                        }
                        else
                        {
                            Console.WriteLine($"Mod {modName} is already in the ITR_ModStage folder.");
                        }
                    }
                }

                // Process deactivated mods - move selected ones back to active folder
                foreach (var mod in deactivatedMods)
                {
                    string modName = Path.GetFileName(mod);
                    string destination = Path.Combine(modFolderPath, modName);

                    Console.WriteLine($"Processing deactivated mod: {modName}");

                    // Skip excluded files
                    if (excludedFiles.Contains(modName, StringComparer.OrdinalIgnoreCase))
                    {
                        Console.WriteLine($"Skipping excluded file: {modName}");
                        continue;
                    }

                    // Move selected mods back to active folder
                    if (selectedMods.Contains(modName, StringComparer.OrdinalIgnoreCase))
                    {
                        Console.WriteLine($"Mod {modName} is selected for activation");

                        // Only move if it isn't already active
                        if (!File.Exists(destination))
                        {
                            try
                            {
                                File.Move(mod, destination);
                                Console.WriteLine($"Moved {modName} back to active folder.");
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine($"Error moving {modName}: {ex.Message}");
                            }
                        }
                        else
                        {
                            Console.WriteLine($"Mod {modName} is already in the active folder.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error processing mods: {ex.Message}");
                throw;
            }
        }
    }
}