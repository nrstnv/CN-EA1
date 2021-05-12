using System;

namespace Aufgabe3
{
    public class Observer1 : IObserver
    {
        /* creating concrete Observer1 */
        public void DisplayNumber(object o)
        {
            Model model = o as Model;
            Console.WriteLine($"Observer1: {model.RandomNumber}");
        }
    }
}
