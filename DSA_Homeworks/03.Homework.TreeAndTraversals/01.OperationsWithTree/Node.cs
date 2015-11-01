using System;
using System.Collections;
using System.Collections.Generic;

/*  
 
      6
    1 2
    2 4
    3 4
    4 6
    6 8

*/

namespace _01.OperationsWithTree
{
    public class Node<T>
    {
        public ICollection<Node<T>> children;
        public T Value { get; set; }
        public bool HasParent { get; set; }

        public Node()
        {
            this.children = new List<Node<T>>();
        }

        public Node(T value):this()
        {
            this.Value = value;
        }

        public void AddChild(Node<T> node){
            this.children.Add(node);
        }

        public int CountOfChildren()
        {
            return this.children.Count;
        }

        public override string ToString()
        {
            return this.Value.ToString();
        }
    }
}
