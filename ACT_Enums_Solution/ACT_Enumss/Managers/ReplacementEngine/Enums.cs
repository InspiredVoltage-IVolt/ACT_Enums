using ACT.Core.Attributes.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACT.Core.Enums.Managers.ReplacementEngine
{
    public static class AttributeFuncs
    {
        public static Dictionary<string, bool> Parameters = new Dictionary<string, bool>();

        static AttributeFuncs()
        {
            Parameters.Add("PluginInfo", true );
        }


    }
    #region Function_Methods Documentation
    /// Enum:   Build in Function_Methods 
    /// Summary:    Values that represent function methods.
    #endregion
    public enum Function_Methods
    {

       // [Enum_ReplacementEngine_Attribute(ParameterCount = 1)]
        FUNC_I_EXECUTE_PLUGIN,
        
      //  [Enum_ReplacementEngine_Attribute(ParameterCount = 1)]
        FUNC_GET_LATLONG,
        
      //  [Enum_ReplacementEngine_Attribute(ParameterCount = 1)]
        FUNC_DOWNLOAD_URL_CONTENTS

    }

    #region Math_Operations
    /// Enum:   Replacement Engine Math Operations
    /// Summary:    Values that represent Math operations.
    #endregion
    public enum Math_Operations
    {
       MATH_ADD,
       MATH_SUBTRACT,
       MATH_MULTIPLY,
       MATH_DIVIDE,
       MATH_ROUND,
       MATH_SQUARE,
       MATH_EXPONENTIAL,
       MATH_SQUAREROOT,
       MATH_LOG,
       MATH_SIN,
       MATH_COS,
       MATH_TAN,
       MATH_MOD
    }

    #region String_Operations
    /// Enum:   Replacement Engine String Operations
    /// Summary:    Values that represent string operations.
    #endregion
    public enum String_Operations
    {
      STRING_TRIM,
      STRING_LEFT,
      STRING_RIGHT,
      STRING_REPLACE,
      STRING_FIRSTINDEXPOS,
      STRING_REVERSEINDEXPOS,
      STRING_TOUPPER,
      STRING_TOLOWER,
      STRING_CONCAT,
      STRING_LENGTH,
      STRING_SUBSTRING,
      STRING_REVERSE
    }

    public enum ReplacementTagType
    {
        Key_Standard_Identifier = 1,
        Key_Dynamic_Identifier = 2,
        Value_Code_Execution_Identifier = 3,
        Value_Plugin_ID_Identifier = 4,
        Value_Call_ID_Identifier = 5,
        Value_Pointer_To_Key_Identifier = 6,
        Custom = 88,
        Other = 99

    }
}
