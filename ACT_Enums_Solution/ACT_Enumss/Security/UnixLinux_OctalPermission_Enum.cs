using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACT.Core.Enums.Security
{
    /// <summary>
    /// Example 777 All Permissions
    /// </summary>
    public enum UnixLinuxOctalPermissions
    {
        No_Permission = 0,
        ExecutePermission = 1,
        WritePermission = 2,
        ExecuteAndWritePermission = 3,
        ReadPermission = 4,
        ReadAndExecutePermission = 5,
        ReadAndWritePermission = 6,
        AllPermissions = 7
    }
}
