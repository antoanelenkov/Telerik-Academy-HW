namespace _03.FileDirectoriesTree
{
    using _01.OperationsWithTree;
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;


    class Program
    {
        private static MyFolder mainFolder = new MyFolder("WINDOWS");

        static void Main(string[] args)
        {
            TraverseDirDFS(new DirectoryInfo(@"C:\WINDOWS\Web"), mainFolder);
            TraverseMyFolderDFS(mainFolder);

            Console.WriteLine("The content size of all is: " + mainFolder.GetSizeOfAll());
        }

        private static void TraverseMyFolderDFS(MyFolder folder)
        {
            var folders = folder.SubFolders;
            foreach (var item in folders)
            {
                Console.WriteLine("Folder name: " + item.Name);
                TraverseMyFolderDFS(item);
            }

            var files = folder.Files;
            foreach (var item in files)
            {
                Console.WriteLine("File name: " + item.Name);
            }
        }

        private static void TraverseDirDFS(DirectoryInfo directory, MyFolder folder)
        {
            try
            {
                var files = directory.GetFiles();
                foreach (var file in files)
                {
                    var myFile = new MyFile(file.Name, file.Length);

                    folder.Files.Add(myFile);
                }

                var directories = directory.GetDirectories();
                foreach (var dir in directories)
                {
                    var newFolder = new MyFolder(dir.Name);

                    TraverseDirDFS(dir, newFolder);

                    folder.SubFolders.Add(newFolder);
                }
            }
            catch (UnauthorizedAccessException)
            {
                return;
            }
        }


    }
}
