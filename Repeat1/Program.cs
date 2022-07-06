using System;
using System.Globalization;
using System.Threading;
using System.IO;

namespace Repeat1
{
    class Program
    {

        static void Main(string[] args)
        {
            var filePath = "imiona.txt";

            var fileContent = File.ReadAllText(filePath);
        }
    }

}