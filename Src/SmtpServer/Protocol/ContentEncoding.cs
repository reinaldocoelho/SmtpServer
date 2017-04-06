namespace SmtpServer.Protocol
{
    public enum ContentEncoding
    {
        /// <summary>
        /// Eight bit encoding (UTF8 Encoding). 
        /// </summary>
        EightBit = 0,

        /// <summary>
        /// Seven bit encoding (ASCII encoding).
        /// </summary>
        SevenBit = 1,

        /// <summary>
        /// The default transfer encoding.
        /// </summary>
        Default = EightBit
    }
}