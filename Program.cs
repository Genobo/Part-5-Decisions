namespace Part_5_Decisions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int balance = 150;
            int deposit;
            int withdraw;
            string enter;
            Console.WriteLine("Welcome to the Bank of Blorb");
            Console.WriteLine("Please enter the transaction that you wish to perform:");
            enter = Console.ReadLine();
            if (enter == "Deposit")
            {
                Console.WriteLine("You have selected: Deposit");
                Console.WriteLine("Please enter the amount you would like to deposit:");
                deposit = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"You have deposited {deposit} dollars into your account");
                Console.WriteLine($"You now have {balance + deposit} dollars in your account");
            }
            else if (enter == "Withdrawal")
            {
                Console.WriteLine("You have selected: Withdrawal");
                Console.WriteLine("Please enter the amount you would like to withdraw:");
                withdraw = Convert.ToInt32(Console.ReadLine());
                if (withdraw > balance)
                {
                    Console.WriteLine("You do not have enough money in your account to make that withdrawal!");
                }
                else if (withdraw <= balance)
                {
                    Console.WriteLine($"You have withdrawn {withdraw} dollars from your account");
                    Console.WriteLine($"You have {balance - withdraw} dollars left in your account");
                }
            }
            else if (enter == "Bill Payment")
            {
                Console.WriteLine("You have selected: Bill Payment");
                Console.WriteLine("Which bill would you like to pay off?");
            }
            else if (enter == "Account Balance")
            {
                Console.WriteLine("You have selected: Account Balance");
                Console.WriteLine($"You currently have ${balance} in your account");
            }
            else
            {
                Console.WriteLine("ERROR 404 INPUT NOT RECOGNIZED AS VALID TRANSACTION ERROR 404");
            }
            Console.WriteLine("The transaction has ended, thank you for using the Bank of Blorb.");
            Console.WriteLine();
            Console.WriteLine("Welcome to Sam's Parking Garage. You will be charged every hour for parking.");
            Console.WriteLine("Please enter the time for how long you've been parked for:");
            double time = Convert.ToDouble(Console.ReadLine());
            double pay = time / 60 * 2 + 2;
            if (time > 0 && time < 540)
            {
                Console.WriteLine($"You have been parked for {time} minutes. Your total is {pay.ToString("C")}");
            }
            Console.WriteLine();
            Console.WriteLine("The intensity of a hurricane will be measured by its current speed");
            double speed = Convert.ToDouble(Console.ReadLine());
            switch (speed)
            {
                case > 70:
                case < 100:
                    Console.WriteLine($"The measured speed of the hurricane is {speed} mph, faster than the normal speed");
                    break;

                default:
                    Console.WriteLine($"The measured speed of the hurricane is {speed} mph.");
                    break;
            }
        }
    }
}