using System;

namespace Re // Note: actual namespace depends on the project name.
{
    enum Text
    {
        One, Two, Three
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Text text = Text.Two;
            Console.WriteLine(text);
        }
    }
}