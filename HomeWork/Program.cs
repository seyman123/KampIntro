namespace HomeWork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.UrunAdi = "Computer";

            Product product2 = new Product();
            product2.UrunAdi = "Phone";

            Product product3 = new Product();
            product3.UrunAdi = "Table";

            Product[] products = new Product[] { product1, product2, product3 };

            for (int i = 0; i < products.Length; i++)
            {
                Console.WriteLine(products[i].UrunAdi);
            }

            foreach (var product in products)
            {
                Console.WriteLine(product.UrunAdi);
            }

            int sayac = 0;

            while (sayac != products.Length)
            {
                Console.WriteLine(products[sayac].UrunAdi);
                sayac++;
            }
        }
    }

    
    class Product
    {
        public string UrunAdi { get; set; }
    }
}