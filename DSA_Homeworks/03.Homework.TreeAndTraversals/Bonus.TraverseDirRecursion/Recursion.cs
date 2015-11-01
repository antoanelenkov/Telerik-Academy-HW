namespace ConsoleApplication1
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    class TraverseDirRecursive
    {
        private static void TraverseDirDFS(DirectoryInfo directory){
            Console.WriteLine(directory.FullName);
            try
            {
                var children = directory.GetDirectories();

                foreach (var child in children)
                {
                    TraverseDirDFS(child);
                }
            }
            catch (UnauthorizedAccessException)
            {
                return;
            }
        }

        static void Main(string[] args)
        {
            TraverseDirDFS(new DirectoryInfo("C:\\"));
        }
    }
}
