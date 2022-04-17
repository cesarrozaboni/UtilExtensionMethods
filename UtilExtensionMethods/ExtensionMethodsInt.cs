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
            return value.Any(x => number.Equals(x));
        }

        /// <summary>
        /// check if value contain in object of values
        /// </summary>
        /// <param name="number">Value to check</param>
        /// <param name="value">object for check</param>
        /// <returns>true if not contains</returns>
        public static bool NotIn(this int number, params object[] value)
        {
            return !value.Any(x => number.Equals(x));
        }
    }
}


