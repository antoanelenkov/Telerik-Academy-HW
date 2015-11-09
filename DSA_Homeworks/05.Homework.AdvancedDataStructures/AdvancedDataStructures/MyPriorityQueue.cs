using System;
using System.Collections;
using System.Collections.Generic;

namespace AdvancedDataStructures
{
    class MyPriorityQueue<T> where T : IComparable<T>
    {
        private const int InitialSize = 8;
        public T[] heapElements;

        public MyPriorityQueue()
        {
            this.heapElements = new T[InitialSize];
            this.Size = 0;
        }

        public int Size { get; set; }

        public void Enqueue(T element)
        {
            if (this.Size == this.heapElements.Length)
            {
                this.Resize();
            }

            this.AddRecursive(element, this.Size);
            this.Size++;
        }

        private void Resize()
        {
            var size = this.heapElements.Length;
            var newCollection = new T[size * 2];

            for (int i = 0; i < this.heapElements.Length; i++)
            {
                newCollection[i] = this.heapElements[i];
            }

            this.heapElements = newCollection;
        }

        public T Dequeue()
        {
            var elementToDelete = this.heapElements[0];

            this.heapElements[0] = this.heapElements[Size - 1];
            this.Size--;
            this.DeleteRecursive(this.heapElements[0], 0);

            return elementToDelete;
        }

        public IEnumerable<T> All()
        {
            var collection = new T[this.Size];

            for (int i = 0; i < this.Size; i++)
            {
                collection[i] = this.heapElements[i];
            }

            return collection;
        }

        public int Count()
        {
            return this.Size;
        }

        private void AddRecursive(T element, int position)
        {
            var previousPosition = 0;

            if (position == 0)
            {
                this.heapElements[position] = element;
                return;
            }
            else if (position == 1)
            {
                previousPosition = 0;
            }
            else if (position % 2 != 0)
            {
                previousPosition = position / 2;
            }
            else
            {
                previousPosition = position / 2 - 1;
            }

            if (this.heapElements[previousPosition].CompareTo(element) < 0)
            {
                var temp = this.heapElements[previousPosition];
                this.heapElements[previousPosition] = element;
                this.heapElements[position] = temp;

                AddRecursive(element, previousPosition);
            }
            else
            {
                this.heapElements[position] = element;
            }

            return;
        }

        private void DeleteRecursive(T element, int position)
        {
            var nextLeftIndex = position == 0 ? 1 : position * 2 + 1;
            var nextRightIndex = position == 0 ? 2 : position * 2 + 2;

            if (nextLeftIndex >= this.Size && nextRightIndex >= this.Size)
            {
                return;
            }

            var leftNode = this.heapElements[nextLeftIndex];
            var rightNode = this.heapElements[nextRightIndex];

            var nextIndex = this.heapElements[nextLeftIndex]
                .CompareTo(this.heapElements[nextRightIndex]) > 0 ? nextLeftIndex : nextRightIndex;

            if (this.heapElements[nextIndex].CompareTo(element) > 0)
            {
                var temp = this.heapElements[nextIndex];
                this.heapElements[nextIndex] = element;
                this.heapElements[position] = temp;

                DeleteRecursive(element, nextIndex);
            }

            return;
        }
    }
}
