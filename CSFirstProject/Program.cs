using System;

namespace CSFirstProject
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a line in the console
            Console.WriteLine("Enter your name:");

            //User input string from the console
            string name = Console.ReadLine();

            Console.WriteLine("Enter your age:");

            //User input from console, converted to int
            int age = Convert.ToInt32(Console.ReadLine());

            //C# if statement
            if (age >= 116)
            {
                Console.WriteLine("Whoa, sorry you're too old to use this.");
            }
            else if (age < 13)
            {
                Console.WriteLine("Whoa, sorry you're too young to use this.");
            }
            else {
                Console.WriteLine("Enter an inspirational quote:");

                string inspirationalQuote = Console.ReadLine();
                
                //Create new object in memory, assign values using constructor with values passed as arguments
                Doid jenkins = new Doid(name, age, inspirationalQuote);


                //Use object method
                jenkins.greeting();
            }

        }
    }

    //Object class
    public class Doid
    {
        //Instantiate object properties
        private string name;
        private int age;
        private bool isDoid = true;
        private string inspirationalQuote;

        //Constructor method, taking arguments from 
        public Doid(string doidName, int doidAge, string doidInspirationalQuote)
        {
            name = doidName;
            age = doidAge;
            isDoid = true;
            inspirationalQuote = doidInspirationalQuote;
        }

        //Object method that can be run from main class
        public void greeting()
        {
            Console.WriteLine("\n\nAlright, " + name + "? You're " + age + " years old by the way..");
            if (isDoid)
            {
                Console.WriteLine("You're a 'Doid' as well.\n");
            }
            Console.WriteLine("Remember when you said \"" + inspirationalQuote + "\" was an inspirational quote? Each to their own..");
        }

    }
}
