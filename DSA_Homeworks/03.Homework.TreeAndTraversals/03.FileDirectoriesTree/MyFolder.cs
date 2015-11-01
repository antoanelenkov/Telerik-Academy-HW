using System.Collections.Generic;

namespace _03.FileDirectoriesTree
{
    public class MyFolder
    {
        private ICollection<MyFile> files;
        private ICollection<MyFolder> subFolders;

        public MyFolder(string name)
        {
            this.Name = name;
            this.files = new List<MyFile>();
            this.subFolders = new List<MyFolder>();
        }

        public string Name { get; set; }

        public ICollection<MyFile> Files
        {
            get { return this.files; }
            set { this.files = value; }
        }

        public ICollection<MyFolder> SubFolders
        {
            get { return this.subFolders; }
            set { this.subFolders = value; }
        }

        public override string ToString()
        {
            return this.Name;
        }

        private long size = 0;

        public long GetSizeOfAll()
        {
            if (this.SubFolders.Count == 0)
            {
                foreach (var file in this.Files)
                {
                    size += file.Size;
                }

                return size;
            }

            foreach (var file in this.Files)
            {
                size += file.Size;
            }

            foreach (var folder in this.SubFolders)
            {
                this.size += folder.GetSizeOfAll();
            }

            return this.size;
        }
    }
}
