

namespace ACT.Core.Enums
{

    /// <summary>
    /// The Sections of the Settings File
    /// </summary>
    [Flags()]
    public enum SystemSettingsSections
    {
        All, Basic, Complex, Dependancy, Interface, EncryptionKeys, InstalledApplication
    }

    /// <summary>
    /// Randomizaion Options
    /// </summary>
    public enum Randomization_Options
    {
        Standard,
        Crypto,
        /// <summary>ACT Special Random Engine </summary>
        ACTParticleRand
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
    /// Replacement Standards - Looks For Configuration Basic Setting ReplacementWrapper
    /// </summary>
    [Flags()]
    public enum RepacementStandard
    {
        UPPERCASE = 1,
        IGNORECASE = 2,
        WRAPPER_3HASHTAGSTANDARD = 4,
        WRAPPER_3BRACKETSTANDARD = 8,
        WRAPPER_CUSTOM = 16
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
