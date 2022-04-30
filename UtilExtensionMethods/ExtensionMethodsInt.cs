namespace UtilExtensionMethods
{
    /// <summary>
    /// Extension to Int
    /// </summary>
    public static partial class ExtensionMethods
    {
        /// <summary>
        /// check if value contain in object of values
        /// </summary>
        /// <param name="number">Value to check</param>
        /// <param name="value">object for check</param>
        /// <returns>true if contains</returns>
        public static bool In(this int number, params int[] value)
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
        public static bool NotIn(this int number, params object[] value)
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


