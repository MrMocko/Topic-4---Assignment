namespace Topic_4___Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {   //Andre
            string  name;
            int age;
            double money;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Hello. What is your name?");
            name = Console.ReadLine();
            Console.WriteLine("Hi there " +  name + (" how old are you again? "));
            Int32.TryParse(Console.ReadLine(), out age);
            Console.WriteLine("So your " + age + (" eh? Thats not old at all! "));
            
            Console.WriteLine("How much do you make? " + name);
            double.TryParse(Console.ReadLine(), out money);
            Console.WriteLine(money .ToString("C") + " I hope thats per hour not per year");
            Console.WriteLine("Press Enter to continue");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Please enter your info so i can steal your personal info. :3);

        }
    }
}
