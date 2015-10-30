namespace LinkedList
{
    using System.Collections.Generic;

    public class MyLinkedList<T>
    {
        public int Count { get; set; }

        public Node<T> Head { get; set; }

        public Node<T> CurrentElement { get; set; }

        public MyLinkedList()
        {
            this.Head = null;
            this.Count = 0;
        }

        public void Add(T value)
        {
            var nodeToAdd = new Node<T>(value);

            if (this.Head == null)
            {
                this.Head = nodeToAdd;
                this.CurrentElement = this.Head;
            }
            else
            {
                this.CurrentElement.Next = nodeToAdd;
                this.CurrentElement = nodeToAdd;
            }

            this.Count++;
        }

        public void Remove(T value)
        {
            var tempNode = this.Head;

            if (tempNode.Value.Equals(value))
            {
                tempNode = null;
                this.Head = this.Head.Next;

                return;
            }

            while (tempNode != null && tempNode.Next != null)
            {
                if (tempNode.Next.Value.Equals(value))
                {
                    if (tempNode.Next.Next != null)
                    {
                        tempNode.Next = tempNode.Next.Next;
                    }
                    else
                    {
                        tempNode.Next = null;
                    }

                    this.Count--;
                }

                tempNode = tempNode.Next;
            }
        }

        public IEnumerable<T> GetAllNodes()
        {
            var allNodes = new List<T>();
            var tempNode = this.Head;

            while (tempNode != null)
            {
                allNodes.Add(tempNode.Value);
                tempNode = tempNode.Next;
            }

            return allNodes;
        }

        public void ClearAll()
        {
            var tempNode = this.Head;

            while (tempNode != null)
            {
                this.Head = this.Head.Next;
                tempNode = this.Head;
            }

            this.Count = 0;
        }

        public bool Contains(T value)
        {
            var tempNode = this.Head;

            while (tempNode != null)
            {
                if (tempNode.Value.Equals(value))
                {
                    return true;
                }
                tempNode = tempNode.Next;
            }

            return false;
        }
    }
}
