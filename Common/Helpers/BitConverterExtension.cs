using System;

namespace Common.Helpers
{
    public static class BitConverterExtension
    {
        public static byte GetBit(bool bit) => Convert.ToByte(bit);
    }
}
