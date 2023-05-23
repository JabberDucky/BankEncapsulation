namespace BankEncapsulation
{
    public class Program
    {
        static void Main(string[] args)
        {
            var myAccount = new BankAcccount();

            Console.WriteLine("Your current balance is:");
            var balanceTotal = myAccount.GetBalance();
            Console.WriteLine(balanceTotal);

            Console.WriteLine();

            Console.WriteLine("How much would you like to add?");
            double total = Convert.ToDouble(Console.ReadLine());
            myAccount.Deposit(total);
            balanceTotal = myAccount.GetBalance();

            Console.WriteLine();

            Console.WriteLine("Your current balance now is:");
            Console.WriteLine(balanceTotal);

            Console.WriteLine();

            Console.WriteLine("Would you like to deposit more?");
            string answer = Console.ReadLine().ToLower();

            Console.WriteLine();

            if (answer == "yes")
            {
                Console.WriteLine("How much would you like to add?");
                double total2 = Convert.ToDouble(Console.ReadLine());
                myAccount.Deposit(total2);
                balanceTotal = myAccount.GetBalance();

                Console.WriteLine();

                Console.WriteLine("Your current balance now is:");
                Console.WriteLine(balanceTotal);
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("Thank you have a great day!");
            }
          

        }
    }
}
