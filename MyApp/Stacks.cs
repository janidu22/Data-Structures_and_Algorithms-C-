// Data Structures Stacks

namespace MyApp;

public class Stacks
{

    static void DisplayStack()
    {
        Stack<string> names = new Stack<string>();
        names.Push("Janidu");
        names.Push("Kavindu");
        names.Push("Ravindu");
        names.Push("Chamindu");

        foreach (var name in names)
        {
            Console.WriteLine(name);
        }
    }

    public static void Main(string[] args)
    {

        DisplayStack();
    }

}
