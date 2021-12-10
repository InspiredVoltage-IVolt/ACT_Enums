namespace ACT.Internal.Enums.CodeGeneration
{
    /// <summary>
    /// Code Signature Items
    /// </summary>
    public enum CodeSignature_ItemType
    {
        Solution = 1,
        Project = 2,
        File = 3,
        Class = 4,
        Method = 5,
        Property = 6,
        Enum = 7,
        Interface = 8,
    }

    /// <summary>
    /// Coding Languages
    /// </summary>
    [Flags]
    public enum Language
    {
        CSharp = 0,
        VisualBasic = 1,
        CPlusPlus = 2,
        C = CPlusPlus | VisualBasic, // 0x00000003
        Perl = 4,
        Javascript = Perl | VisualBasic, // 0x00000005
        Ruby = Perl | CPlusPlus, // 0x00000006
        Python = Ruby | VisualBasic, // 0x00000007
        Custom = 8,
    }
}
