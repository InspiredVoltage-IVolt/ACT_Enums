namespace ACT.Enums
{
    public enum HashType
    {
        SHA512,
        SHA384,
        SHA256,
        SHA1,
        MD5,
    }

    [Flags]
    public enum PermissionLevel
    {
        Read = 0,
        Write = 1,
        Modify = 2,
        Delete = Modify | Write, // 0x00000003
        ReadSelf = 4,
        ModifySelf = ReadSelf | Write, // 0x00000005
        DeleteSelf = ReadSelf | Modify, // 0x00000006
        ReadOther = DeleteSelf | Write, // 0x00000007
        ModifyOther = 8,
        DeleteOther = ModifyOther | Write, // 0x00000009
    }

    /// <summary>
    /// The security Difficulty of the process
    /// Easy = 6 Characters
    /// Medium = 8, Hard = 12, Impossible = 16, Galaxy = 32, Universe = 64
    /// Phrase + Easy = 2 Words, Phrase + Medium = 2, ... 4... 6... 8... 10...
    /// </summary>
    [Flags]
    public enum SecurityDifficulty
    {
        Length_Easy = 0,
        Length_Medium = 1,
        Length_Hard = 2,
        Length_Impossible = Length_Hard | Length_Medium, // 0x00000003
        Length_GalaxySize = 4,
        Length_UniverseSize = Length_GalaxySize | Length_Medium, // 0x00000005
        Characters_AlphaLower = Length_GalaxySize | Length_Hard, // 0x00000006
        Characters_AlphaUpper = Characters_AlphaLower | Length_Medium, // 0x00000007
        Characters_AlphaLowerUpper = 8,
        Characters_Special = Characters_AlphaLowerUpper | Length_Medium, // 0x00000009
        Phrase_Dictionary = Characters_AlphaLowerUpper | Length_Hard, // 0x0000000A
        Phrase_Songs = Phrase_Dictionary | Length_Medium, // 0x0000000B
        Phrase_Nonsense = Characters_AlphaLowerUpper | Length_GalaxySize, // 0x0000000C
    }

    /// <summary>
    /// Security Provider Generic Result
    /// </summary>
    public enum Security_Provider_Generic_Result
    {
        EmailAddressRegisteredAlready,
        UserNameTaken,
        PasswordComplexityInvalid,
        RegistrationOK,
        UnKnownError,
        InvalidAPIKey,
        ApplicationCantCreateUser,
        UserNotAssociatedToApp,
        ActionAlreadyExists,
        AccessDenied,
        Success,
    }
}
