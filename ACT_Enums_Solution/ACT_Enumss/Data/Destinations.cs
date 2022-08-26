using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACT.Core.Enums.Data
{
    /// <summary>
    /// Common Destinations -  Always Used With Supporting Data.
    /// </summary>
    public enum Common_Destinations
    {
        Directory,
		DatabaseTable,
        NetworkLocation,
        FTP,
        SFTP,
        WebPost,
        WebGet,
        ACT_CACHE,
        I_Saveable_Plugin,
        I_Cacheable_Plugin
    }
}
