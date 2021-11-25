
using System;

namespace EssentialLesson17Task1
{

    //Создайте класс Calculator, методы которого принимают аргументы и возвращают значения типа dynamic.

    class Program
    {
        static void Main(string[] args)
        {
            dynamic a = Calculator.Plus(10, 5, "int");
            dynamic b = Calculator.Plus(10, 5, "smthElse");

            Console.WriteLine(a);
            Console.WriteLine(b);

            dynamic z = Calculator.Div(10, 0, "int");
            dynamic x = Calculator.Div(10, 0, "smthElse");

            Console.WriteLine(z);
            Console.WriteLine(x);
        }
    }
}
