using System;
using System.Collections.Generic;
//using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class GenericList<T> where T : IComparable
    {
        private int capacity;//problem 6
        private T[] arr;
        private int lastIndex = 0;

        public GenericList(int capacity)
        {
            this.capacity = capacity;
            this.Arr = new T[capacity];
        }

        public T[] Arr
        {
            get { return arr; }
            set { arr = value; }
        }

        //problem 7
        public T Min()
        {
            T result = this.Arr[lastIndex];
            if (lastIndex == 0)
            {
                Console.WriteLine("The list is empty!");
                return result;
            }
            else
            {
                for (int i = 0; i <= this.lastIndex; i++)
                {
                    if (this.Arr[i].CompareTo(result) < 0)
                    {
                        result = this.Arr[i];
                    }
                }
            }

            return result;
        }
        //problem 7
        public T Max()
        {
             T result = default(T);
            if (lastIndex == 0)
            {
                Console.WriteLine("The list is empty!");
                return result;
            }
            else
            {
                for (int i = 0; i <= this.lastIndex; i++)
                {
                    if (this.Arr[i].CompareTo(result) > 0)
                    {
                        result = this.Arr[i];
                    }
                }

                return result;
            }
        }

        public void Add(T element)
        {
            if (this.lastIndex == this.capacity - 1)
            {
                Resize();
            }
            Arr[lastIndex] = element;
            this.lastIndex++;
        }

        public void Insert(int index, T element)
        {
            if (this.lastIndex == this.capacity - 1)
            {
                Resize();
            }

            if (index < 0)
            {
                throw new IndexOutOfRangeException("The index is out of bounds!");
            }
            //if the index is greater than the capacity, this method will add an element at last position
            if (index > this.lastIndex)
            {
                index = this.lastIndex;
            }
            for (int i = this.lastIndex + 1; i > index; i--)
            {
                this.Arr[i] = this.Arr[i - 1];
            }
            this.Arr[index] = element;
            this.lastIndex++;
        }

        public void Remove(int index)
        {
            if (index < 0 || index > this.lastIndex)
            {
                throw new IndexOutOfRangeException("The index is out of bounds!");
            }
            for (int i = index; i < this.lastIndex - 1; i++)
            {
                this.Arr[i] = this.Arr[i + 1];
            }
            this.Arr[lastIndex] = default(T);
            this.lastIndex--;
        }

        public void Clear()
        {
            for (int i = 0; i < Arr.Length; i++)
            {
                this.Arr[i] = default(T);
            }
            this.lastIndex = 0;
        }

        public void Find(T element)
        {
            var listOfIndexes = new List<int>();
            for (int i = 0; i < this.lastIndex; i++)
            {
                if (element.Equals(Arr[i]))
                {
                    listOfIndexes.Add(i);
                }
            }
            if (listOfIndexes.Count > 0)
            {
                Console.WriteLine("The element {0} is met in the list at these indexes:", element);
                Console.WriteLine(String.Join(",", listOfIndexes));
            }
            else
            {
                Console.WriteLine("There is no such element in the list");
            }
        }
        //problem 6
        private void Resize()
        {
            T[] newArr = new T[2 * this.capacity];
            for (int i = 0; i < this.lastIndex; i++)
            {
                newArr[i] = this.Arr[i];
            }
            this.Arr = newArr;
            this.capacity *= 2;
        }

        public T this[int index]
        {
            get
            {
                if (index >= 0 && index <= this.lastIndex)
                {
                    return this.Arr[index];
                }
                else
                {
                    throw new IndexOutOfRangeException("The index is out of bounds!");
                }
            }
            set
            {
                if (index < 0 && index > this.lastIndex)
                {
                    throw new IndexOutOfRangeException("The index is out of bounds!");
                }

                this.Arr[index] = value;
            }
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            for (int i = 0; i < this.lastIndex; i++)
            {
                sb.Append(Arr[i] + ",");
            }
            if (sb.Length > 0)
            {
                sb.Remove(sb.Length - 1, 1);
                return sb.ToString();
            }
            else
            {
                return null;
            }
        }

    }
}
