using System.Transactions;

namespace Topic_4___Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {   //Andre
            string  name, firstname, lastname, login;
            int age, grade, id;
            double money, average;
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
            Console.WriteLine("Please enter your info so i can steal your personal info. :3");
            Thread.Sleep(1000);
            Console.WriteLine("Enter your firstname");
            firstname = Console.ReadLine();
            Console.WriteLine("Enter your last name");
            lastname = Console.ReadLine();
            Console.WriteLine("Enter your grade");
            Int32.TryParse (Console.ReadLine(), out grade);
            Console.WriteLine("Enter your student id");
            Int32.TryParse (Console.ReadLine(), out id);
            Console.WriteLine("Enter your login"); 
            login = Console.ReadLine();
            Console.WriteLine("Enter your average");
            double.TryParse (Console.ReadLine(), out average);

            Console.WriteLine("\tLogin : " + login);
            Console.WriteLine("\tStudent ID : " + id);
            Console.WriteLine("\tFirst name : " + firstname + " " +lastname);
            Console.WriteLine("\tYour Average :\t" + average + "%");
            Console.WriteLine("\tGrade : " + grade);
            Console.WriteLine("Press Enter to continue");
            Console.ReadLine();
            Console.Clear ();
            Console.WriteLine("Hello what is your name?" + name);
            Console.ReadLine();
            Console.WriteLine("Hi " + name + "! How old are you? ");
            Int32.TryParse(Console.ReadLine(), out age);
            Console.WriteLine("Did you know that in 5 years you will be " + (age + 5) + (" Years old?!"));
            Thread.Sleep(1000);
            Console.WriteLine("And 5 years ago you were " + (age - 5) + (" Years old"));
            Console.WriteLine("Press Enter to continue");
            Console.ReadLine();
            Console.Clear ();
            Console.WriteLine();
            
            
            
        }
    }
}
