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

            p1.Quantity = 5;
            Console.WriteLine(p1.Quantity);


            Product p2 = new Product(101, "Laptop", 1200);

            Product p3 = new();
            //var p4 = new();
            var p5 = new Product();

            //Console.WriteLine(p1._price);


            Product p6 = new Product();
            p6.Name = "Mobile";
            p6.Price = 2000;
            p6.Quantity = 5;

            Product p7 = new Product()
            {
                Name = "Tablet",
                Price = 500,
                Quantity = 5
            };


            int[] arr = { 2, 4, 5, 6, 4, 3, 3 };



            Console.WriteLine("\n\n\n");



            BankAccount myAcc = new BankAccount(500);
            Console.WriteLine("Balance = " + myAcc.Balance.ToString("C"));

            myAcc.Deposit(200);
            Console.WriteLine("Balance = " + myAcc.Balance.ToString("C"));

            try
            {
                myAcc.Withdraw(4000);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine("Balance = " + myAcc.Balance.ToString("C"));
        }
    }
}
