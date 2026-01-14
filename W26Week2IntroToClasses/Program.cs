namespace W26Week2IntroToClasses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product p1 = new Product();

            p1.SetId(200);
            Console.WriteLine(p1.GetId());

            p1.Name = "John";
            Console.WriteLine(p1.Name);


            Product p2 = new Product(101, "Laptop", 1200);

            Product p3 = new();
            //var p4 = new();
            var p5 = new Product();

            //Console.WriteLine(p1._price);


        }
    }
}
