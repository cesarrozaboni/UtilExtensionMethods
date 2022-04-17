namespace UtilExtensionMethods
{
    /// <summary>
    /// Extension to type byte
    /// </summary>
    public static partial class ExtensionMethods
    {
        /// <summary>
        /// Convert <see cref="string"/> to <see cref="byte"/> using base64
        /// </summary>
        /// <param name="ImgBase64"><see cref="string"></see> with base64 value</param>
        /// <returns><![CDATA[byte[]]]> with values</returns>
        public static byte[] Convert64ToByte(this string ImgBase64)
        {
            return Convert.FromBase64String(ImgBase64);

        }
    }
}


