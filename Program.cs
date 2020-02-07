using System;

namespace CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            var sum = new Calculator().Add(150).Add(50.78).Result;
            Console.WriteLine("Sum = {0}", sum); 
        }
    }
}
