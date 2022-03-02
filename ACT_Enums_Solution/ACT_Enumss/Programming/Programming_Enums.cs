namespace ACT.Core.Enums.Programming
{

    /// <summary>
    /// Coding Languages
    /// </summary>
    [Flags]
    public enum Programming_Language
    {
        Assembly,
        CSharp,
        FSharp,
        VisualBasic,
        CPlusPlus,
        C,
        Perl,
        Javascript,
        Ruby,
        Python,
        Swift,
        Rust,
        Scala,
        GoLang_Go,
        Java,
        R,
        PHP,
        ObjectiveC,
        Lua,
        Pascal,
        TypeScript,
        Delphi,
        Matlab,
        VBA,
        Groovy,
        Dart,
        Cobol,
        Other
    }

    /// <summary>
    /// Master List of DOT NET VERSIONS
    /// </summary>
    [Flags()]
    public enum DOTNET_VERSIONS
    {
        FRAMEWORK_4_8_0,
        FRAMEWORK_4_7_2,
        FRAMEWORK_4_7_1,
        FRAMEWORK_4_7_0,
        FRAMEWORK_4_6_2,
        FRAMEWORK_4_6_1,
        FRAMEWORK_4_6_0,
        FRAMEWORK_4_5_2,
        FRAMEWORK_4_5_1,
        FRAMEWORK_4_5_0,
        FRAMEWORK_4_0_0,
        FRAMEWORK_3_5_0,
        NETCORE_6_0,
        NETCORE_5_0,
        NETCORE_3_1,
        
    }

    /// <summary>
    /// OLD EOL DOTNET VERSIONS
    /// </summary>
    [Flags()]
    public enum DOTNET_EOL_VERSIONS
    {
        FRAMEWORK_3_0_0,
        FRAMEWORK_2_0_0,
        FRAMEWORK_1_1_0,
        FRAMEWORK_1_0_0,
        NETCORE_3_0,
        NETCORE_2_1,
        NETCORE_2_2,
        NETCORE_2_0,
        NETCORE_1_1

    }
}
