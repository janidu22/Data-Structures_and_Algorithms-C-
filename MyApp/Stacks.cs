// Data Structures Stacks
using System.Collections.Generic;
namespace MyApp
{
    public class Stacks
    {

        public static void DisplayStack()
        {
            Stack<string> names = new Stack<string>();

            // add eliments to a stack

            names.Push("Janidu");
            names.Push("Kavindu");
            names.Push("Ravindu");
            names.Push("Chamindu");

            // view eliments using a foreach

            foreach (var name in names)
            {
                Console.WriteLine(name);
            }

            // checking the last item in the stack 

            Console.WriteLine(names.Peek());


            // search an eliments - true or false

            Console.WriteLine(names.Contains("Kavindu"));

            // remove the Last item in the stack

            Console.WriteLine(names.Pop());

            // clear stack using stack.Clear(); --> names.Clear();
        }

    }
}