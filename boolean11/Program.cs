using System;
using static System.Console;

namespace boolean11
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(ReadLine());
            int b = int.Parse(ReadLine());
            
            bool result = a%2 ==0 && b%2 == 0;
            WriteLine(result);
        }
    }
}