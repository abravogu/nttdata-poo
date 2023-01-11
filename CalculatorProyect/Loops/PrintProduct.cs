using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorProyect.Loops
{
    public class PrintProduct
    {
        public static List<Product> products = new List<Product>();

        public static void CreateListProduct()
        {
            var potetoes = new Product();
            potetoes.Id = 1;
            potetoes.Name = "Patatas";
            potetoes.Price= 24.56f;
            products.Add(potetoes);

            var oil = new Product
            {
                Id = 2,
                Name = "Aceite",
                Price = 35.27f
            };
            products.Add(oil);

            var game = new Product
            {
                Id = 2,
                Name = "Juego",
                Price = 39.99f
            };
            products.Add(game);
        }

        public static List<Product> GetProductGraterThan30WithFor()
        {
            List<Product> productsGratherThan30 = new List<Product>();
            for (int i=0;i<products.Count;i++) {
               
                if (products[i].Price>30f)
                {
                    productsGratherThan30.Add(products[i]);
                }
            }
        return productsGratherThan30;    
        }
        public static List<Product> GetProductGraterThan30WithForEach()
        {
            List<Product> productsGratherThan30 = new List<Product>();
            foreach (Product prod in products)
            {
                if (prod.Price > 30f)
                {
                    productsGratherThan30.Add(prod);
                }
            }
            return productsGratherThan30;
        }

        public static List<Product> GetProductGraterThan30WithWhile()
        {
            List<Product> productsGratherThan30 = new List<Product>();
            var cont = 0;
            while(cont<products.Count)
            {
                if (products[cont].Price > 30f)
                {
                    productsGratherThan30.Add(products[cont]);
                }
                cont++;
            }
            return productsGratherThan30;
        }

         public static List<Product> GetProductGraterThan30WithLinQ()
         {
             //List<Product> productsGratherThan30 = products.Where(products.< 30);
            IEnumerable<Product> PriceQuery =
    from product in products
    where product.Price > 30
    select product;
            return PriceQuery.ToList();
         }

    }
}
