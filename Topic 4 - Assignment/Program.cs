using System.Transactions;

namespace Topic_4___Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {   //Andre
            string  name, firstname, lastname, login, item1, item2;
            int age, grade, id;
            double money, average, num1, num2, num3, num4, price1, price2, total; 
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
            Console.WriteLine("Enter your first name");
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

            Console.WriteLine("\tLogin: " + login);
            Console.WriteLine("\tStudent ID: " + id);
            Console.WriteLine("\tFirst name: " + firstname + " " +lastname);
            Console.WriteLine("\tYour Average:\t" + average + "%");
            Console.WriteLine("\tGrade: " + grade);
            Console.WriteLine("Press Enter to continue");
            Console.ReadLine();
            Console.Clear ();
            Console.WriteLine("Hello what is your name?");
            name = Console.ReadLine();
            Console.WriteLine("Hi " + name + "! How old are you? ");
            Int32.TryParse(Console.ReadLine(), out age);
            Console.WriteLine("Did you know that in 5 years you will be " + (age + 5) + (" Years old?!"));
            Thread.Sleep(1000);
            Console.WriteLine("And 5 years ago you were " + (age - 5) + (" Years old"));
            Console.WriteLine("Press Enter to continue");
            Console.ReadLine();
            Console.Clear ();
            Console.WriteLine("Hello friends this is calk, and today im'a do some pretty good math. Give me 3 numbers to add together then devide by 2 with ");
            Console.WriteLine("Enter number 1");
            Double.TryParse (Console.ReadLine(), out num1);
            Console.WriteLine("Enter number 2");
            Double.TryParse(Console.ReadLine(), out num2);
            Console.WriteLine("Give me the last number now");
            Double.TryParse(Console.ReadLine(), out num3);
            Console.WriteLine("Cool man ima do the math now :) ");
            Console.WriteLine("''CALCULATING ''");
            Thread.Sleep(2000);
            num4 = ((num1 + num2 + num3) / 2);
            Console.WriteLine("The calculated number is = " + num4);
            Console.WriteLine("Press Enter to continue");
            Console.ReadLine ();
            Console.Clear ();
            Console.WriteLine("Hey man how's it going? Just kidding i dont care, i am going to scan your items now what are they ");
            Console.Write("Item 1: ");
            item1 = Console.ReadLine();
            Console.WriteLine("Ok and item 2?");
            Console.Write("Item 2: ");
            item2 = Console.ReadLine();
            Console.WriteLine("Alright cool is it only " + item1 + " And " + item2);
            Thread.Sleep(1000);
            Console.WriteLine("Uhhhhhhhh so how much do they cost again?");
            Console.Write("Price of " + item1 + ": ");
            Double.TryParse(Console.ReadLine(), out price1);
            Console.WriteLine("And item two?");
            Console.Write("Price of " + item2  + ": ");
            Double.TryParse(Console.ReadLine (), out price2);
            total = (price1 + price2);
            




            Console.WriteLine("Ok so your total is: " + total.ToString("C"));
            Console.WriteLine(" Ok your recipt is going to print now. ");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("\t Sales Receipt ");
            Console.WriteLine("");
            Console.WriteLine("\t Item 1:\t" + item1);
            Console.WriteLine("\t Price:\t \t" + price1.ToString("C"));
            Console.WriteLine("\t Item 2:\t" + item2);
            Console.WriteLine("\t Price:\t \t" + price2.ToString("C"));
            Console.WriteLine("\t ===================");
            Console.WriteLine("\t Total:\t \t  " + total.ToString("C"));

        }
    }
}
