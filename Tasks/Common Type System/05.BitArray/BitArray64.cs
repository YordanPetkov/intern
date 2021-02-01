using System;
using System.Collections.Generic;
using System.Text;

namespace _05.BitArray
{
    class BitArray64
    {
        private ulong data;

        public BitArray64()
        {
            data = 0;
        }

        public byte this[int index]
        {
            get
            {
                ulong tempData = data;

                for (int i = 1; i < index; i++)
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
                    data += (ulong)Math.Pow(2, (double)index);
                }
                else if(this[index] == 1 && value == 0)
                {
                    data -= (ulong)Math.Pow(2, (double)index);
                }
            }
        }
    }
}
