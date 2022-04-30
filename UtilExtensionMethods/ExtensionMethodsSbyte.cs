namespace UtilExtensionMethods
{
    /// <summary>
    /// Extension to sbyte
    /// </summary>
    public static partial class ExtensionMethods
    {
        /// <summary>
        /// check if value contain in object of values
        /// </summary>
        /// <param name="number">Value to check</param>
        /// <param name="value">object for check</param>
        /// <returns>true if contains</returns>
        public static bool In(this sbyte number, params sbyte[] value)
        {
            foreach (var i in value)
            {
                if (number.Equals(i))
                    return true;
            }

            return false;
        }

        /// <summary>
        /// check if value contain in object of values
        /// </summary>
        /// <param name="number">Value to check</param>
        /// <param name="value">object for check</param>
        /// <returns>true if not contains</returns>
        public static bool NotIn(this sbyte number, params sbyte[] value)
        {
            foreach (var i in value)
            {
                if (number.Equals(i))
                    return false;
            }

            return true;
        }
    }
}


