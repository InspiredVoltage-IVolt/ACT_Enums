namespace ACT.Core.Enums.TemplateEngine
{
    /// <summary>
    /// Cache Methods Available
    /// </summary>
    public enum CacheMethod
    {
        /// <summary>
        /// Database caching
        /// </summary>
        Database = 1,
        /// <summary>
        /// DLL Caching using external DLL for Caching
        /// </summary>
        DLL = 2,
        /// <summary>
        /// Use Internal Caching
        /// </summary>
        Memory = 4
    }

    /// <summary>
    /// Enum PackageType
    /// </summary>
    public enum PackageType
    {
        /// <summary>
        /// Nebula Template Standard Package
        /// </summary>
        NGT = 1,
        /// <summary>
        /// Nebula Database Template Package
        /// </summary>
        DBNGT = 2,
        /// <summary>
        /// Nebula Custom Package Definition - Plugin Based Execution
        /// </summary>
        CUSTOM = 3
    }


    /// <summary>
    /// Enum TemplateType
    /// </summary>
    public enum TemplateType
    {
        /// <summary>
        /// Advanced Nebula Template
        /// </summary>
        NGT = 1,
        /// <summary>
        /// Simple Nebula Template
        /// </summary>
        SIMPLE = 2,
        /// <summary>
        /// Web Platform Specific Structure
        /// </summary>
        WEBPLATFORM = 3,
        /// <summary>
        /// Reporting Engine Structure
        /// </summary>
        REPORTENGINE = 4,
        /// <summary>
        /// Query Engine Structure
        /// </summary>
        QUERYENGINE = 5,
        /// <summary>
        /// Email Engine Structure
        /// </summary>
        EMAILENGINE = 6,
        /// <summary>
        /// Javascript Engine
        /// </summary>
        JAVASCRIPTENGINE = 7
    }
}
