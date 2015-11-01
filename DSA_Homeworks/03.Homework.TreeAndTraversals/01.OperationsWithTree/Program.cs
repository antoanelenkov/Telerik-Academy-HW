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
 c) all middle nodes
 (*) all paths in the tree with given sum `S` of their nodes
 (*) all subtrees with given sum `S` of their nodes*/

namespace _01.OperationsWithTree
{
    class Program
    {
        private static int maxDepth = 0;
        private static int depth = 0;
        private static ICollection<Stack<int>> pathsWithSumS = new List<Stack<int>>();
        private static List<Stack<int>> subtreesWithSumS = new List<Stack<int>>();
        private static Stack<int> currentValues = new Stack<int>();

        static void Main(string[] args)
        {
            int[,] inputValues = ReadConsoleInput();
            ICollection<Node<int>> treeStructure = ConstructTree(inputValues);

            //a) the root node
            Node<int> root = FindRoot(treeStructure);
            Console.WriteLine("1. The root is: " + root.ToString());

            //b) all leaf nodes
            var leafs = FindLeafs(treeStructure);
            Console.WriteLine("2. Leafs are: " + String.Join(", ", leafs));

            //c) all middle nodes
            var middleNodes = FindMiddleNodes(treeStructure);
            Console.WriteLine("3. Middle nodes are: " + String.Join(", ", middleNodes));

            //d) find longest path
            FindLongestPath(root);
            Console.WriteLine("4. Longest path is from {0} nodes", maxDepth);

            //e) (*) all paths in the tree with given sum `S` of their nodes
            var sum = 9;
            FindAllPathWithSumS(root, sum, pathsWithSumS);

            Console.WriteLine("All paths with sum of {0}", sum);
            PrintTrees(pathsWithSumS);

            //d) (*) all subtrees with given sum `S` of their nodes
            var sumD = 6;

            GenerateSubtreesWithSumS(treeStructure, sumD, subtreesWithSumS);

            Console.WriteLine("All subtrees with sum of {0}", sumD);
            PrintTrees(subtreesWithSumS);
        }

        private static void PrintTrees(IEnumerable<IEnumerable<int>> trees)
        {
            foreach (var list in trees)
            {
                foreach (var item in list)
                {
                    Console.Write(item + " ");
                }
                Console.WriteLine();
            }
        }

        private static void GenerateSubtreesWithSumS(ICollection<Node<int>> treeStructure, int sumD, ICollection<Stack<int>> resultCollection)
        {
            foreach (var node in treeStructure)
            {
                currentValues = new Stack<int>();

                FindAllPathWithSumS(node, sumD, resultCollection);
            }
        }

        private static void FindAllPathWithSumS(Node<int> node, int sum, ICollection<Stack<int>> resultCollection)
        {
            currentValues.Push(node.Value);

            if (node.children.Count == 0)
            {
                var currentSum = 0;
                currentValues.ToList().ForEach(x => currentSum += x);

                if (currentSum == sum)
                {
                    var stackToAdd = new Stack<int>();

                    foreach (var item in currentValues)
                    {
                        stackToAdd.Push(item);
                    }

                    resultCollection.Add(new Stack<int>(stackToAdd));
                }

                return;
            }

            foreach (var children in node.children)
            {

                FindAllPathWithSumS(children, sum, resultCollection);
                currentValues.Pop();
            }
        }

        private static void FindLongestPath(Node<int> node)
        {
            depth++;

            if (depth > maxDepth)
            {
                maxDepth = depth;
            }

            if (node.children.Count == 0)
            {
                return;
            }

            foreach (var children in node.children)
            {

                FindLongestPath(children);
                depth--;
            }          
        }

        private static int FindLongestPath(ICollection<Node<int>> treeStructure)
        {
            var root = treeStructure.FirstOrDefault(x => x.HasParent == false);
            var nodes = new Stack<Node<int>>();
            var depth = 0;
            var maxDepth = 0;
            nodes.Push(root);

            while (nodes.Count > 0)
            {
                var node = nodes.Pop();

                if (node.children.Count == 0)
                {
                    if (depth > maxDepth)
                    {
                        maxDepth = depth;
                    }

                    continue;
                }

                depth++;

                foreach (var child in node.children)
                {
                    nodes.Push(child);
                }

            }

            return maxDepth;
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
                if (node.HasParent && node.CountOfChildren() > 0)
                {
                    middleNodes.Add(node);
                }
            }

            return middleNodes;
        }

        private static int[,] ReadConsoleInput()
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
