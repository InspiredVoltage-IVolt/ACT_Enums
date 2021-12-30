namespace ACT.Core.Enums.IO
{
    public enum Structured_FileType
    {
        XML,
        JSON,
        ACTF,
        CSV,
        TEXT_TAB_DELIMITED,
        TEXT_OTHER_DELIMITED,
        XLSX,
        XLS,
        BINARY
    }

    /// <summary>
    /// Copy Options When Copying Folders
    /// </summary>
    [Flags()]
    public enum Folder_File_CopyOption
    {
        /// <summary>
        /// Overwrite existing files
        /// </summary>
        Overwrite = 1,
        /// <summary>
        /// Ignore existing files
        /// </summary>
        Ignore = 2,
        /// <summary>
        /// Place All files in the ROOT Folder of the Destination
        /// </summary>
        Placeinroot = 4,
        /// <summary>
        /// Save Duplicate Files
        /// </summary>
        Saveduplicatefiles = 8,
        /// <summary>
        /// For duplicate files check the filename and add the version to the filename xx-xx-xx-xx.xxx
        /// </summary>
        Addversiontoname = 16,
        /// <summary>
        /// Keeps only the highest version file with the original name
        /// </summary>
        Keeponlythehighestversion = 32,

        /// <summary>
        /// Creates Folders Based Off The Version Of The File
        /// </summary>
        Version_CreateFolders = 64,

        /// <summary>
        /// Define a Verbose Flag
        /// </summary>
        VerboseDebugging = 128,

        /// <summary>
        /// Cleans the Destination First By Deleting It and Recreating It
        /// </summary>
        CleanDestination = 256


    }
}
