using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ACT.Core.Enums.Licensing
{
    public enum LicenseFileType
    {
        Full,
		Partial
    }

    public enum LicenseDeploymentType
    {
        Education,
        Testing,
        Development,
        ProductionUsage
    }
}
