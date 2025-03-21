using System;

public class ModManager
{
    private readonly string appFolderPath;
    private readonly string gameFolderPath;

    public ModManager(string appFolder, string gameFolder)
	{
        appFolderPath = ITRModLoader.Properties.Settings.Default.AppFolderPath;
        gameFolderPath = ITRModLoader.Properties.Settings.Default.GameFolderPath;
	}
}
