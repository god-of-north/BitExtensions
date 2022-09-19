using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GON.Extensions
{
    public static class BitExtensions
    {
        public static byte SetBit(this byte bt, int n) => (byte)(bt | (1UL << n));
        public static byte ClearBit(this byte bt, int n) => (byte)(bt & (~(1UL << n)));
        public static byte ToggleBit(this byte bt, int n) => (byte)(bt ^ (1UL << n));
        public static bool IsBitSet(this byte bt, int n) => ((bt >> n) & 1U) == 1;
        public static byte ChangeBit(this byte bt, int n, bool set) => (byte)((bt & ~(1UL << n)) | ((set ? 1UL : 0UL) << n));
    }
}
