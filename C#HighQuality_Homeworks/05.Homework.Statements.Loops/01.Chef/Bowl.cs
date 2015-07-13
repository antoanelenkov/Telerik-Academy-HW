namespace Chef
{
    using System;
    using System.Collections.Generic;

    public class Bowl
    {
        private IList<Vegetable> vegetables;

        public Bowl()
        {
            this.vegetables = new List<Vegetable>();
        }

        public void Add(Vegetable vegToAdd)
        {
            this.vegetables.Add(vegToAdd);
        }
    }
}
