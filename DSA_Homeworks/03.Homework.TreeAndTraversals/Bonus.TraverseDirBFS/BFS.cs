using System;
using System.Collections.Generic;
using System.IO;

namespace _18.BFS
{
    class TraverseDirectoryBFS
    {
        private static void TraverseDirBFS(DirectoryInfo directory)
        {
            Queue<DirectoryInfo> dirs=new Queue<DirectoryInfo>();
            DirectoryInfo dir = directory;

            dirs.Enqueue(dir);
            while (dirs.Count > 0)
            {
                var currentDir = dirs.Dequeue();
                Console.WriteLine(currentDir);
                var dirChildren = currentDir.GetDirectories();

                foreach (var child in dirChildren)
                {
                    dirs.Enqueue(child);
                }
            }
        }

        static void Main(string[] args)
        {
            TraverseDirBFS(new DirectoryInfo("C:\\Antoan\\"));
        }
    }
}
