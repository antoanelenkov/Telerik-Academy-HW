namespace ConsoleApplication1
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    class TraverseDirectoryDFS
    {
        private static void TraverseDirDFS(DirectoryInfo directory){
            Console.WriteLine(directory.FullName);

            var children = directory.GetDirectories();

            foreach (var child in children)
            {
                TraverseDirDFS(child);
            }
        }

        static void Main(string[] args)
        {
            TraverseDirDFS(new DirectoryInfo("C:\\TFS_Antoan\\"));
        }
    }
}
