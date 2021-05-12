using System;

namespace Aufgabe3
{
    class Model : Subject
    {
        private Random _random;

        public int RandomNumber { get; private set; }

        public Model()
        {
            _random = new Random();
        }

        public void NextRandomNumber()
        {
            RandomNumber = _random.Next(1, 51);
            NotifyObservers(this);
        }
    }
}
