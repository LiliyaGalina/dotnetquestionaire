using System;

namespace PassingArguments
{

    class Program
    {
        static void Main(string[] args)
        {
            var pointAClass = new PointAsClass(2, 2);
            var pointBStruct = new PointAsStruct(2, 2);

            ChangeClassPointSomehow(pointAClass);
            ChangeStructPointSomehow(pointBStruct);
           
            Console.WriteLine($"PointAsClass-> x:{pointAClass.X}, y:{pointAClass.Y}");
            Console.WriteLine($"PointAsStruct-> x:{pointBStruct.X}, y:{pointBStruct.Y}");
            Console.ResetColor();

        }


        static void ChangeClassPointSomehow( PointAsClass point)
        {
           point.X = 3;
           point.Y = 3;
        }
        static void ChangeStructPointSomehow(PointAsStruct point)
        {
            point.X = 3;
            point.Y = 3;
        }


    }


    class PointAsClass 
    {
        public int X { get; set; }
        public int Y { get; set; }

        public PointAsClass(int x, int y)
        {
            X = x;
            Y = y;
        }
    }

    struct PointAsStruct 
    {
        public int X { get; set; }
        public int Y { get; set; }

        public PointAsStruct(int x, int y)
        {
            X = x;
            Y = y;
        }
    }



}
