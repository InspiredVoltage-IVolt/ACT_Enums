namespace ACT.Enums
{
    /// <summary>
    /// Defines Basic Access Levels
    /// </summary>
    [Flags]
    public enum AccessLevel
    {
        Read = 0,
        Write = 1,
        Modify = 2,
        Custom = Modify | Write, // 0x00000003
        Create = 4,
        Delete = Create | Write, // 0x00000005
    }

    /// <summary>Defines Common Error Levels.</summary>
    public enum ErrorLevel
    {
        Informational,
        /// <summary>Warning. Log Error. Take No Additional Action</summary>
        Warning,
        /// <summary>Severe: Log Error, Notify Admin</summary>
        Severe,
        /// <summary>Critical: Log Error, Notify Admin, Throw Exception</summary>
        Critical,
    }

    /// <summary>
    /// Randomizaion Options
    /// </summary>
    public enum Randomization_Options
    {
        Standard,
        Crypto,
    }



    /// <summary>Mouse Events (ACT Standards)</summary>
    public enum MouseEvents
    {
        LeftMouseButtonClick,
        LeftMouseButtonDrag,
        RightMouseButtonClick,
        RightMouseButtonDrag,
        Hovor,
    }

    /// <summary>
    /// Defines Operators that can be passed and saved as values
    /// </summary>
    public enum Operators
    {
        /// <summary>=</summary>
        Equals = 0,
        /// <summary>
        /// 
        /// </summary>
        LessThan = 1,
        /// <summary>
        /// 
        /// </summary>
        GreaterThan = 2,
        /// <summary>Substring, % - %</summary>
        Contains = 4,
        WithIn = 8,
    }

    /// <summary>
    /// Programming Languages
    /// </summary>
    public enum ProgrammingLanguages
    {
        CSharp,
        JavaScript,
    }


    /// <summary>
    /// Replacement Standards
    /// </summary>
    public enum RepacementStandard
    {
        UPPERCASE = 1,
        IGNORECASE = 2,
        USEDELIMETER = 3,
    }

    /// <summary>
    /// Security Access Errors
    /// </summary>
    public enum SecurityAccessError
    {
        FREQUENT_ATTEMPTS,
        INVALID_CREDENTIALS,
        SECURITY_PRIVLEDGES,
        TOKEN_FAILEDTOCREATE,
        INVALID_APIKEY,
        OTHER,
    }


}
