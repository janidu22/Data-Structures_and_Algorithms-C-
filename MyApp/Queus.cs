using System;

namespace MyApp;

public class Queus
{
    public static void DisplayQueus()
    {
        Queue<string> cars = new Queue<string>();
        // first in first out
        cars.Enqueue("Toyota");
        cars.Enqueue("Nissan");
        cars.Enqueue("BenZ");
        cars.Enqueue("Mazda");



        foreach (var car in cars)
        {
            Console.WriteLine(car);
        }

        Console.WriteLine(cars.Peek());



    }
}
