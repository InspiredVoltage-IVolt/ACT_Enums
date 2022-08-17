using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace ACT.Core.Enums.Encryption
{
    public enum DatabaseKeys_Identities
    {
        SYSTEM,
        COMPANY,
        CLIENT,
        MEMBER,
        PLUGIN,
        APPLICATION,
        OTHER
    }
    public enum DatabaseKeys_SubIdentities
    {
        SYSTEM_FILES,
        SYSTEM_INTERNAL,
        SYSTEM_CONNECTIONSTRINGS,
        COMPANY_FILES,
        COMPANY_INTERNAL,
        COMPANY_CONNECTIONSTRINGS,
        CLIENT_FILES,
        CLIENT_INTERNAL,
        CLIENT_CONNECTIONSTRINGS,
        MEMBER_FILES,
        MEMBER_INTERNAL,
        MEMBER_CONNECTIONSTRINGS,
        PLUGIN_FILES,
        PLUGIN_INTERNAL,
        PLUGIN_CONNECTIONSTRINGS,
        APPLICATION_FILES,
        APPLICATION_INTERNAL,
        APPLICATION_CONNECTIONSTRINGS,
        OTHER_OTHER
    }
}
