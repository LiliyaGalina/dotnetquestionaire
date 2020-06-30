using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;

namespace D.LINQ
{
    class Info
    {
        public int IntProperty { get; set; }
        public string StrProperty { get; set; }
        public double DoubleProperty { get; set; }
    }

    class Program
    {

        static List<Info> infos = new List<Info>()
        {
            new Info
            {
                IntProperty = 42,
                StrProperty = "Bohemian Rhapsody",
                DoubleProperty = 0.3
            },
            new Info
            {
                IntProperty = -100,
                StrProperty = "You don`t fool me",
                DoubleProperty = 0.99
            },
            new Info
            {
                IntProperty = 1,
                StrProperty = "Don`t stop me now",
                DoubleProperty = Double.NegativeInfinity
            },
        };

        static void Main(string[] args)
        {

            var result = infos
                .Select((x, i) =>
                {
                    x.IntProperty *= i;
                    x.DoubleProperty = ((double)x.IntProperty) / x.DoubleProperty;
                    return x;
                })
                .Where(x => x.StrProperty.Contains("on") && x.IntProperty > 0)
                .OrderBy(x => x.StrProperty)
                .Select(x => x.DoubleProperty)
                .LastOrDefault();

            Console.WriteLine(result);
        }
    }
}
