using System;

namespace MyApp
{
    public class Program
    {
        public static void Main(string[] args)
        {

            // Menu
            string menu = "table of content".ToUpper();
            Console.WriteLine($"#### {menu} ####");
            Console.WriteLine("1)Stacks in c#");
            Console.WriteLine("2)Queuse in c#");
            Console.WriteLine("3)Linked-Lists in c#");

            Console.WriteLine();
            Console.Write("Pick content: ");
            Console.ForegroundColor = ConsoleColor.Green;
            int choice = int.Parse(Console.ReadLine());
            Console.ResetColor();

            switch (choice)
            {
                case 1:
                    Stacks.DisplayStack();
                    break;
                case 2:
                    Queus.DisplayQueus();
                    break;
                default:
                    Console.WriteLine("invalid choice");
                    break;
            }
        }
    }
}
