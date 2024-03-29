﻿namespace ACT.Core.Enums
{
    public enum CacheMethod
    {
        /// <summary>Database caching</summary>
        Database = 1,
        /// <summary>DLL Caching using external DLL for Caching</summary>
        DLL = 2,
        /// <summary>Use Internal Caching</summary>
        Memory = 4,
    }

    /// <summary>
    /// Represents the State Of a CacheEngine
    /// </summary>
    public enum CacheEngineState
    {
        Live, Initializing, Rebuilding, Saving, Error
    }
}
