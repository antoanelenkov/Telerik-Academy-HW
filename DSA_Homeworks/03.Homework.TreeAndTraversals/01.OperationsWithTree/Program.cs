using System;
using System.Collections.Generic;
using System.Linq;

/*You are given a tree of N nodes represented as a set of N-1 pairs of nodes (parent node, child node),
 * each in the range (0..N-1). Example:
    7
    2 4
    3 2
    5 0
    3 5
    5 6
    5 1
Write a program to read the tree and find:
 a) the root node
 b) all leaf nodes
 c) all middle nodes*/

namespace _01.OperationsWithTree
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] inputValues = readConsoleInput();
            ICollection<Node<int>> treeStructure = ConstructTree(inputValues);

            //a) the root node
            var root = FindRoot(treeStructure);
            Console.WriteLine("1. The root is: " + root.ToString());

            //b) all leaf nodes
            var leafs = FindLeafs(treeStructure);
            Console.WriteLine("2. Leafs are: " +String.Join(", ",leafs));

            //c) all middle nodes
            var middleNodes = FindMiddleNodes(treeStructure);
            Console.WriteLine("3. Middle nodes are: " + String.Join(", ", middleNodes));
        }

        

        private static Node<int> FindRoot(ICollection<Node<int>> treeStructure)
        {
            var root = new Node<int>();

            foreach (var node in treeStructure)
            {
                if (!node.HasParent)
                {
                    return node;
                }
            }

            return root;
        }

        private static ICollection<Node<int>> FindLeafs(ICollection<Node<int>> treeStructure)
        {
            var leafs = new List<Node<int>>();

            foreach (var node in treeStructure)
            {
                if (node.CountOfChildren() == 0)
                {
                    leafs.Add(node);
                }
            }

            return leafs;
        }

        private static ICollection<Node<int>> FindMiddleNodes(ICollection<Node<int>> treeStructure)
        {
            var middleNodes = new List<Node<int>>();

            foreach (var node in treeStructure)
            {
                if (node.HasParent&&node.CountOfChildren()>0)
                {
                    middleNodes.Add(node);
                }
            }

            return middleNodes;
        }

        private static int[,] readConsoleInput()
        {
            //Console.WriteLine("Enter value for number of nodes: ");
            //var nodesCount = int.Parse(Console.ReadLine());
            //var bufferArr = new int[nodesCount - 1, 2];

            //Console.WriteLine("Enter value for parent and child, separated by comma and press [Enter]!");
            //for (int i = 0; i < bufferArr.GetLength(0); i += 1)
            //{
            //    var edges = Console.ReadLine().Split(' ');
            //    bufferArr[i, 0] = int.Parse(edges[0]);
            //    bufferArr[i, 1] = int.Parse(edges[1]);
            //}

            //return bufferArr;
            return new int[,] { { 2, 4 }, { 3, 2 }, { 5, 0 }, { 3, 5 }, { 5, 6 }, { 5, 1 } };
        }

        private static ICollection<Node<int>> ConstructTree(int[,] array)
        {
            var nodes = new List<Node<int>>(array.GetLength(0));

            for (var i = 0; i < array.GetLength(0); i++)
            {
                int parentValue = array[i, 0];
                int childValue = array[i, 1];

                var parentNode = nodes.FirstOrDefault(x => x.Value == parentValue);
                var childNode = nodes.FirstOrDefault(x => x.Value == childValue);

                if (parentNode == null)
                {
                    parentNode = new Node<int>(parentValue);
                    nodes.Add(parentNode);
                }

                if (childNode == null)
                {
                    childNode = new Node<int>(childValue);
                    childNode.HasParent = true;
                    nodes.Add(childNode);
                }
                else if (childNode.HasParent == false)
                {
                    childNode.HasParent = true;
                }

                parentNode.AddChild(childNode);
            }

            return nodes;
        }
    }
}
