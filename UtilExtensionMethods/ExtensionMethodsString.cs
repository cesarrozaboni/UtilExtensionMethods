namespace UtilExtensionMethods
{
    /// <summary>
    /// Extension to string
    /// </summary>
    public static partial class ExtensionMethods
    {
        /// <summary>
        /// Return value in upper
        /// </summary>
        /// <param name="value">string to change</param>
        /// <returns>string in upper</returns>
        public static string ReturnUpper(this string value)
        {
            return value.Trim().ToUpper();
        }

        /// <summary>
        /// check if string is empty
        /// </summary>
        /// <param name="str">string to check</param>
        /// <returns>true if is empty</returns>
        public static bool IsEmpty(this string str)
        {
            return string.IsNullOrWhiteSpace(str);
        }

        /// <summary>
        /// check if string is empty
        /// </summary>
        /// <param name="str">string to check</param>
        /// <returns>true if is not empty</returns>
        public static bool IsNotEmpty(this string str)
        {
            return !string.IsNullOrWhiteSpace(str);
        }

        /// <summary>
        /// check if value contain in object of values
        /// </summary>
        /// <param name="str">Value to check</param>
        /// <param name="value">object for check</param>
        /// <returns>true if contains</returns>
        public static bool In(this string str, params string[] value)
        {
            return value.Any(x => x.Equals(str));
        }

        /// <summary>
        /// check if value contain in object of values
        /// </summary>
        /// <param name="str">Value to check</param>
        /// <param name="value">object for check</param>
        /// <returns>true if not contains</returns>
        public static bool NotIn(this string str, params object[] value)
        {
            return !value.Any(x => x.Equals(str));
        }

        /// <summary>
        /// add quote in string
        /// </summary>
        /// <param name="str">string to change</param>
        /// <returns>string changed</returns>
        public static string QuotedStr(this string str)
        {
            return $"'{str}'";
        }

        /// <summary>
        /// send params in url
        /// </summary>
        /// <param name="url">url</param>
        /// <param name="parameter">parameter to add in url</param>
        /// <returns></returns>
        public static string SendParams(this string url, params string[] parameter)
        {
            if(parameter.Count(x => x.IsNotEmpty()).Equals(0))
                return url;

            for (int i = 0; i < parameter.Length; i++)
            {
                url += string.Format("{0}p{1}={2}", (i == 0 ? "?" : "&"), (i + 1), parameter[i]);
            }

            return url;
        }

        /// <summary>
        /// if the first expression is null return the second
        /// </summary>
        /// <param name="str"></param>
        /// <param name="value1"></param>
        /// <param name="value2"></param>
        /// <returns><see cref="string"/></returns>
        public static string IfNull(this string str, string value1, string value2)
        {
            return value1.IsEmpty() ? value2 : value1;
        }


       
    }
}


