using System.IO;

namespace ITRModLoader.Logic
{
    public static class PathManager
    {
        public static string GetPaksFolderPath(string gameFolderPath)
        {
            return Path.Combine(gameFolderPath, "IntoTheRadius", "Content", "Paks");
        }

        public static string GetDeactivatedModsPath(string gameFolderPath)
        {
            string pakModsFolderPath = GetPaksFolderPath(gameFolderPath);
            return Path.Combine(Path.GetDirectoryName(pakModsFolderPath), "ITR_ModStage");
        }

        public static string GetGameExePath(string gameFolderPath)
        {
            return Path.Combine(gameFolderPath, "IntoTheRadius", "IntoTheRadius.exe");
        }
    }
}