using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _01.MenuOfLinks
{
    public class Item
    {
        private string name;
        private string url;
        private string fontColor;
      
        public Item(string name,string url)
        {
            this.name = name;
            this.url = url;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string  Url
        {
            get { return url; }
            set { url = value; }
        }

        public string FontColor
        {
            get { return fontColor; }
            set { fontColor = value; }
        }
    }
}