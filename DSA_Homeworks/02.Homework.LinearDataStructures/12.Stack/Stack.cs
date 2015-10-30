namespace Stack
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class MyStack<T>
    {
        private const int InitialSize = 8;

        public MyStack()
        {
            this.Collection = new T[InitialSize];
            this.Count = 0;
        }

        public MyStack(int size):this()
        {
            this.Collection = new T[size];
        }

        public T[] Collection { get; set; }

        public int Count { get; set; }

        public void Push(T value)
        {
            if (this.Count == this.Collection.Length)
            {
                var tempCollection = new T[this.Count * 2];

                for (int i = 0; i < this.Collection.Length; i++)
                {
                    // TODO: implement logic for deep copy
                    tempCollection[i] = this.Collection[i];
                }

                this.Collection = tempCollection;
            }
            
            this.Collection[this.Count] = value;
            this.Count++;
        }

        public T Pop()
        {
            this.Count--;

            if (this.Count < 0)
            {
                throw new InvalidOperationException("Stack is empty. You cannot pop");
            }

            return this.Collection[this.Count];
        }

        public T Peek()
        {
            if (this.Count == 0)
            {
                throw new ArgumentException("Stack is empty. You cannot peek.");
            }

            return this.Collection[this.Count-1];
        }

        public bool IsEmpty()
        {
            return this.Count > 0 ? true : false;
        }
    }

}
