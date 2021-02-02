using System;
using System.Collections.Generic;
using System.Text;

namespace _05.BitArray
{
    class BitArray64
    {
        public BitArray64()
        {
            Data = 0;
        }

        public ulong Data { get; set; }

        public byte this[int index]
        {
            get
            {
                ulong tempData = Data;

                for (int i = 0; i < index; i++)
                {
                    tempData = tempData / 2;
                }

                if(tempData % 2 == 1)
                {
                    return 1;
                }
                return 0;
            }

            set
            {
                if(this[index] == 0 && value == 1)
                {
                    Data += (ulong)Math.Pow(2, (double)index);
                }
                else if(this[index] == 1 && value == 0)
                {
                    Data -= (ulong)Math.Pow(2, (double)index);
                }
            }
        }

        public static bool operator ==(BitArray64 firstArray, BitArray64 secondArray)
        {
            return firstArray.Data == secondArray.Data;
        }

        public static bool operator !=(BitArray64 firstArray, BitArray64 secondArray)
        {
            return firstArray.Data != secondArray.Data;
        }

        public bool Equals(BitArray64 bitArray)
        {
            return this.Data == bitArray.Data;
        }

        public override int GetHashCode()
        {
            return this.Data.GetHashCode();
        }

    }
}
