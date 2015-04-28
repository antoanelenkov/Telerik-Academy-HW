namespace BitArray64
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class BitArray64 : IEnumerable<int>
    {
        private readonly ulong numberToConvert;
        private readonly int[] bitArray = new int[64];

        public BitArray64(ulong number)
        {
            this.numberToConvert = number;
            this.bitArray = ConvertFromDecimalToBinary(number);
        }


        public int[] BitArray
        {
            get
            {
                return this.bitArray;
            }
        }

        public int this[int index]
        {
            get
            {
                if (index < 0 || index > 63)
                {
                    throw new ArgumentOutOfRangeException("There is no such index in the array.");
                }
                return bitArray[index];
            }
            set
            {
                if (value != 0 && value != 1)
                {
                    throw new ArgumentOutOfRangeException("The value must be [1] or [0].");
                }
                else
                {
                    bitArray[index] = value;
                }
            }
        }

        private int[] ConvertFromDecimalToBinary(ulong number)
        {
            int[] result = new int[64];
            var sb = new StringBuilder();
            while (number > 0)
            {
                sb.Insert(0, number % 2);
                number /= 2;
            }
            for (int i = result.Length - 1; i >= 0; i--)
            {
                if (sb.Length > 0)
                {
                    result[i] = Convert.ToInt32(sb[sb.Length - 1] - 48);
                    sb.Remove(sb.Length - 1, 1);
                }
                else
                {
                    result[i] = 0;
                }
            }
            return result;
        }

        public static bool operator ==(BitArray64 a, BitArray64 b)
        {
            return (a.Equals(b));
        }

        public static bool operator !=(BitArray64 a, BitArray64 b)
        {
            return !(a.Equals(b));
        }

        public override bool Equals(object obj)
        {
            BitArray64 otherBitArray = obj as BitArray64;
            if (obj == null)
            {
                return false;
            }
            return this.numberToConvert.Equals(otherBitArray.numberToConvert);
        }

        public IEnumerator<int> GetEnumerator()
        {
            for (int i = 0; i < bitArray.Length; i++)
            {
                yield return BitArray[i];
            }
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int result = 17;
                result = result * 23 + this.numberToConvert.GetHashCode();
                result = result * 23 + ((bitArray != null) ? this.bitArray.GetHashCode() : 0);
                return result;
            }
        }
    }
}
