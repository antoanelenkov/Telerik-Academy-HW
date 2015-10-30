namespace LinkedList
{
    using System;
    using System.Collections.Generic;

    class TestApp
    {
        static void Main()
        {
            var linkedList = new MyLinkedList<int>();
            linkedList.Add(1);
            linkedList.Add(2);
            linkedList.Add(3);
            linkedList.Add(4);
            linkedList.Add(5);
            linkedList.Add(6);

            // Add
            Console.WriteLine("All nodes: ");
            ListAllNodes(linkedList);

            // Contains
            Console.WriteLine("Contains 4? : {0}",linkedList.Contains(4));
            Console.WriteLine("Contains 7? : {0}", linkedList.Contains(7));

            // Remove
            Console.WriteLine("All nodes after removing the first one: ");
            linkedList.Remove(1);
            ListAllNodes(linkedList);

        }

        private static void ListAllNodes(MyLinkedList<int> list)
        {
            Console.WriteLine(String.Join(", ", list.GetAllNodes()));
        }
    }
}
