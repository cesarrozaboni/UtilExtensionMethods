using System;
using System.ComponentModel;
using System.Reflection;

namespace UtilExtensionMethods
{
    /// <summary>
    /// Extension to Enum
    /// </summary>
    public static partial class ExtensionMethods
    {
        /// <summary>
        /// Get description from Enum
        /// </summary>
        /// <param name="value">enum to get description</param>
        /// <returns>string with description</returns>
        public static string GetEnumDescription(this Enum value)
        {
            FieldInfo field = value.GetType().GetField(value.ToString());

            DescriptionAttribute[] attributes = (DescriptionAttribute[])field.GetCustomAttributes(typeof(DescriptionAttribute), false);

            if (attributes != null && attributes.Length > 0)
                return attributes[0].Description;
            else
                return value.ToString();
        }
    }
}


