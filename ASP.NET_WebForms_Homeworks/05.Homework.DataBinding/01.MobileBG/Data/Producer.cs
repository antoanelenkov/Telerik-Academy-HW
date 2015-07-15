using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _01.MobileBG
{
    public class Producer
    {
        private string name;
        private List<string> models;

        public List<string> Models
        {
            get { return models; }
            set { models = value; }
        }
        

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
    }
}