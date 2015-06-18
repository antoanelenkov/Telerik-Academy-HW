using System;
using System.Collections.Generic;
using System.IO;

namespace _18.DFS
{
    class TraverseDirectoryBFS
    {
        private static void TraverseDirDFS(DirectoryInfo directory)
        {
            Stack<DirectoryInfo> dirs = new Stack<DirectoryInfo>();
            DirectoryInfo dir = directory;

            dirs.Push(dir);
            while (dirs.Count > 0)
            {
                var currentDir = dirs.Pop();
                Console.WriteLine(currentDir);
                var dirChildren = currentDir.GetDirectories();
  
                foreach (var child in dirChildren)
                {
                    dirs.Push(child);
                }
            }
        }

        static void Main(string[] args)
        {
            TraverseDirDFS(new DirectoryInfo("C:\\TFS_Antoan\\"));
        }
    }
}
