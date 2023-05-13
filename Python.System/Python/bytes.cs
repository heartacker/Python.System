using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;

namespace Python
{
    public static partial class System
    {
        #region bytes

        public static byte[] bytes(string source, string encoding = "utf-8", string errors = "strict")
                                    => bytearray(source, encoding, errors);
        /// <summary>
        /// 仅支持byte sbyte int uint ushort short 数组
        /// </summary>
        /// <param name="source"></param>
        /// <returns></returns>
        public static byte[] bytes(IEnumerable<object> source) => bytearray(source);
        public static byte[] bytes(uint source) => bytearray(source);
        public static byte[] bytes(int source) => bytearray(source);


        public static byte[] bytearray(string source, string encoding = "utf-8", string errors = "strict")
        {
            return Encoding.GetEncoding(encoding, new EncoderExceptionFallback(), new DecoderExceptionFallback()).GetBytes(source);
        }

        public static byte[] bytearray(uint source) => new byte[source];
        public static byte[] bytearray(int source) => bytearray((uint)source);

        /// <summary>
        /// 仅支持byte sbyte int uint ushort short 数组
        /// </summary>
        /// <param name="source"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentException"></exception>
        public static byte[] bytearray(IEnumerable<object> source)
        {
            if (source is IEnumerable<byte> bytei)
            {
                byte[] byteArray = bytei.ToArray();
                return byteArray;
            }
            else if (source is IEnumerable<sbyte> sbytei)
            {
                byte[] byteArray = sbytei.Select(i => (byte)i).ToArray();
                return byteArray;
            }
            else if (source is IEnumerable<short> shorti)
            {
                byte[] byteArray = shorti.Select(i => (byte)i).ToArray();
                return byteArray;
            }
            else if (source is IEnumerable<ushort> ushorti)
            {
                byte[] byteArray = ushorti.Select(i => (byte)i).ToArray();
                return byteArray;
            }
            else if (source is IEnumerable<int> inti)
            {
                byte[] byteArray = inti.Select(i => (byte)i).ToArray();
                return byteArray;
            }
            else if (source is IEnumerable<uint> uinti)
            {
                byte[] byteArray = uinti.Select(i => (byte)i).ToArray();
                return byteArray;
            }
            else
            {
                throw new ArgumentException("source parameter must be an integer, a string, or an iterable object of integers or bytes");
            }
        }
        #endregion
    }
}
