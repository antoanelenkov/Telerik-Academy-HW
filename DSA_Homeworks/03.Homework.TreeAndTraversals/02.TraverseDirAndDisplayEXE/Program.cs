using System;
using System.Collections.Generic;
using System.IO;

/*Write a program to traverse the directory C:\WINDOWS and all its subdirectories recursively and to display all files matching the mask *.exe */

namespace _02.TraverseDirAndDisplayEXE
{
    class Program
    {
        static void Main(string[] args)
        {
            TraverseDirDFS(new DirectoryInfo("C:\\"), "exe");
        }   

        private static void TraverseDirDFS(DirectoryInfo directory, string extensionName)
        {
            Stack<DirectoryInfo> dirs = new Stack<DirectoryInfo>();
            DirectoryInfo dir = directory;

            dirs.Push(dir);
            while (dirs.Count > 0)
            {
                try
                {
                    var currentDir = dirs.Pop();

                    if (currentDir.Extension.Contains(extensionName))
                    {
                        Console.WriteLine(currentDir.FullName);
                    }

                    var dirChildren = currentDir.GetDirectories();

                    foreach (var child in dirChildren)
                    {
                        dirs.Push(child);
                    }
                }
                catch (UnauthorizedAccessException)
                {
                    continue;
                }
                catch (PathTooLongException)
                {
                    Console.WriteLine("Name of directory is too long to be handled...");
                }
            }
        }
    }
}
