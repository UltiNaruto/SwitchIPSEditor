namespace SwitchIPSEditor
{
    internal static class NumberUtils
    {
        internal static byte[] Get3Bytes(this Int32 val, bool isLittleEndian=true)
        {
            var datas = isLittleEndian ? BitConverter.GetBytes(val) : BitConverter.GetBytes(val).Reverse().ToArray();
            return new byte[3] { datas[1], datas[2], datas[3] };
        }

        internal static byte[] Get3Bytes(this UInt32 val, bool isLittleEndian = true)
        {
            var datas = isLittleEndian ? BitConverter.GetBytes(val) : BitConverter.GetBytes(val).Reverse().ToArray();
            return new byte[3] { datas[1], datas[2], datas[3] };
        }

        internal static Int32 ToInt24(this byte[] val, bool isLittleEndian = true)
        {
            var datas = val.Length == 3 ? (isLittleEndian ? new byte[] { 0, val[0], val[1], val[2] } : new byte[] { val[2], val[1], val[0], 0 }) : val;
            return BitConverter.ToInt32(datas, 0);
        }

        internal static UInt32 ToUInt24(this byte[] val, bool isLittleEndian = true)
        {
            var datas = val.Length == 3 ? (isLittleEndian ? new byte[] { 0, val[0], val[1], val[2] } : new byte[] { val[2], val[1], val[0], 0 }) : val;
            return BitConverter.ToUInt32(datas, 0);
        }
    }
}
