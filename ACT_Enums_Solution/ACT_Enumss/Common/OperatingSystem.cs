namespace ACT.Core.Enums.Common
{
    /// <summary>
    /// List Of Operating systems
    /// </summary>
    [Flags()]
    public enum OperatingSystems
    {
        /// <summary>
        /// Windows
        /// </summary>
        Windows = 0,
        /// <summary>
        /// All version of Linux
        /// </summary>
        Linux = 1,
        /// <summary>
        /// Mac OS
        /// </summary>
        MaxOS = 2,
        /// <summary>
        /// Android
        /// </summary>
        Android = 4,
        /// <summary>
        /// iOS
        /// </summary>
        iOS = 8,
        /// <summary>
        /// Other
        /// </summary>
        Other = 16
    }
}
