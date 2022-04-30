namespace UtilExtensionMethods
{
    /// <summary>
    /// Extension to char
    /// </summary>
    public static partial class ExtensionMethods
    {
        /// <summary>
        /// check if value contain in object of values
        /// </summary>
        /// <param name="caracter">Value to check</param>
        /// <param name="value">object for check</param>
        /// <returns>true if contains</returns>
        public static bool In(this char? caracter, params char[] value)
        {
            foreach (var i in value)
            {
                if (caracter.Equals(i))
                    return true;
            }

            return false;
        }

        /// <summary>
        /// check if value contain in object of values
        /// </summary>
        /// <param name="caracter">Value to check</param>
        /// <param name="value">object for check</param>
        /// <returns>true if not contains</returns>
        public static bool NotIn(this char? caracter, params char[] value)
        {
            foreach (var i in value)
            {
                if (caracter.Equals(i))
                    return false;
            }

            return true;
        }
    }
}


