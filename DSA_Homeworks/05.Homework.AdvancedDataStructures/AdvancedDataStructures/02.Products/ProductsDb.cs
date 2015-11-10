namespace AdvancedDataStructures
{
    using System.Collections.Generic;
    using System.Linq;
    using Wintellect.PowerCollections;

    class ProductsDb
    {
        private OrderedBag<Product> products;

        public ProductsDb()
        {
            this.products = new OrderedBag<Product>();
        }

        public void AddProduct(Product product)
        {
            this.products.Add(product);
        }

        public ICollection<Product> GetProductsInPriceRange(decimal bottomRange, decimal topRange)
        {
            var lowerBound = new Product("random", bottomRange);
            var upperBound = new Product("random", topRange);

            //return this.products.Where(x => x.Price >= bottomRange && x.Price <= topRange).ToList(); //0:64 sec.

            return this.products.Range(lowerBound,true, upperBound,true).ToList(); // 0:05 sec.
        }
    }
}
