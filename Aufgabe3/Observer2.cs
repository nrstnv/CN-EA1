using System;

namespace Aufgabe3
{
    /* creating concrete Observer2 */
    public class Observer2 : IObserver
    {
        public void DisplayNumber(object o)
        {
            Model model = o as Model;
            Console.WriteLine("Observer2: ".PadRight(totalWidth: 11 + model.RandomNumber, paddingChar: '#'));            
        }
    }
}
