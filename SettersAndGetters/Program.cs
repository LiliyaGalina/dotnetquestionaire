using System;

namespace SettersAndGetters
{
    //що буде в консолі?
    class Program
    {
        static void Main(string[] args)
        {

            var rand = new Random();
            var point = new Point(rand.Next(0,10), rand.Next(0, 10));

            Console.WriteLine(point);

        }
    }

    class Point
    {

        int x, y;

        public int X { 
            get {
                return x;
            }
            set {
                x = value;
            }
        }
        public int Y
        {
            get
            {
                return y;
            }
            set
            {
                Y = value;
            }
        }

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        public override string ToString()
        {
            return $"({x}, {y})";
        }

    }
}
