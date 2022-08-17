using System;

namespace Calculator 
{
    class Program
    {
        static void Main(string[] args)
        {
               Menu();       
               
        }

        static void Menu() 
        {
            Console.Clear();

            Console.WriteLine("Welcome, what do you want?");
            Console.WriteLine("1 - Addition");
            Console.WriteLine("2 - Subtraction");
            Console.WriteLine("3 - Division");
            Console.WriteLine("4 - Multiplication");
            Console.WriteLine("5 - Exit");
            Console.WriteLine("-------------");
            Console.WriteLine("Select one option");

            short res = short.Parse(Console.ReadLine());
            
            switch(res) 
            {
                case 1: Addition(); break;
                case 2: Subtraction(); break;
                case 3: Division(); break;
                case 4: Multiplication(); break;
                case 5: Exit(); break;
                default: Menu(); break; 
            }
        }
        static void Addition() 
        {
            Console.Clear();
            Console.WriteLine("First Value: ");
            float v1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Second Value: ");
            float v2 = float.Parse(Console.ReadLine());
            Console.WriteLine("");
            float additionResult = v1 + v2;
            Console.WriteLine($"The result of the sum is: {additionResult}");
            Console.ReadKey();
            Menu();
        }

        static void Subtraction()
        {
            Console.Clear();
            Console.WriteLine("First value:");
            float v1 = float.Parse(Console.ReadLine());
        
        Console.WriteLine("Second value:");
            float v2 = float.Parse(Console.ReadLine());
        
        Console.WriteLine("");
        float subtractionResult = v1 - v2;
        Console.WriteLine($"The result of the Minus Operation is:{subtractionResult}");
        Console.ReadKey();
        Menu();
        }
   
        static void Division()
        {
            Console.Clear();
            Console.WriteLine("Initial number: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Divided by:");
            float v2 = float.Parse(Console.ReadLine());
            float divisionResult = v1 / v2;

            Console.WriteLine("");

            Console.WriteLine($"The result of division is: {divisionResult} ");
            Console.ReadKey();
            Menu();
        }
        static void Multiplication()
        {
            Console.Clear();
            Console.WriteLine("First value:");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Multiplier:");
            float v2 = float.Parse(Console.ReadLine());
            float multiplicationResult = v1 * v2;
            Console.WriteLine("");
            Console.WriteLine($"The result of the multiplication is: {multiplicationResult}");
            Console.ReadKey();
            Menu();
        }
        static void Exit()
        {
            Console.Clear();
            Console.WriteLine("-------------");
            Console.WriteLine("Thank you for using the Basic Calculator App. For more content - access: <https://github.com/victorpomim>");
            Console.WriteLine("-------------");
            System.Environment.Exit(0);
        }
    }
}
