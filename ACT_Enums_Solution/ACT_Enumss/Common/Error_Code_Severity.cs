namespace ACT.Core.Enums.Common
{

    /// <summary>
    /// Defines Common Error Levels.
    /// Enum Other
    /// </summary>
    public enum Error_Code_Severity
    {
        /// <summary>
        /// The informational
        /// </summary>
        Informational = 0,
        /// <summary>
        /// Warning. Log Error. Take No Additional Action
        /// The warning
        /// </summary>
        Warning = 1,
        /// <summary>
        /// Severe: Log Error, Notify Admin
        /// The severe
        /// </summary>
        Severe = 2,
        /// <summary>
        /// Critical: Log Error, Notify Admin, Throw Exception
        /// The critical
        /// </summary>
        Critical = 3,
        DebuggingError = 4,
        SystemCore = 5
    }

    /// <summary>
    /// Enum ErrorCodeEnums
    /// </summary>
    public enum Error_Code
    {
        /// <summary>
        /// The general error code
        /// </summary>
        GeneralErrorCode = 1,
        /// <summary>
        /// The exception in error logger
        /// </summary>
        ExceptionInErrorLogger = 2,

    }
}
