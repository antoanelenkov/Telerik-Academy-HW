using System;
namespace Queue
{
    class MyQueue<T>
    {
        private const int InitialSize = 8;
        private int currentIndex = 0;

        public MyQueue()
        {
            this.Collection = new T[InitialSize];
            this.Count = 0;
            this.currentIndex = 0;
        }

        public MyQueue(int size)
            : this()
        {
            this.Collection = new T[size];
        }

        public T[] Collection { get; set; }

        public int Count { get; set; }

        public void Enqueue(T value)
        {
            if (this.Count == this.Collection.Length)
            {
                var tempCollection = new T[this.Count * 2];

                for (int i = this.currentIndex, j = 0; i < this.Collection.Length; i++, j++)
                {
                    // TODO: implement logic for deep copy
                    tempCollection[j] = this.Collection[i];
                }

                this.Collection = tempCollection;
            }

            this.Collection[this.Count] = value;
            this.Count++;
        }

        public T Dequeue()
        {
            this.Count--;

            if (this.Count < 0)
            {
                throw new InvalidOperationException("Queue is empty. You cannot pop");
            }

            return this.Collection[this.currentIndex++];
        }

        public T Peek()
        {
            if (this.Count == 0)
            {
                throw new ArgumentException("Queue is empty. You cannot peek.");
            }

            return this.Collection[this.currentIndex];
        }

        public bool IsEmpty()
        {
            return this.Count > 0 ? true : false;
        }
    }

}
