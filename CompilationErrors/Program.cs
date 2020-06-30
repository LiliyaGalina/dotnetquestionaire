using System;

namespace CompilationErrors
{
    //пояснити і виправити всі помилки компіляції
    class Program
    {
        const TimeSpan severalMinutes = TimeSpan.FromMinutes(3);

        static void Main(string[] args)
        {
            var result = SomeFunction(DateTime.Now);

            Console.WriteLine(result);
        }

        void SomeFunction(DateTime dat = DateTime.Now)
        {
            return dat.Add(severalMinutes);
        }

    }
}
