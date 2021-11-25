using System;
using System.Collections.Generic;
using System.Linq;

namespace EssentialLesson17Task3
{
    //    Задание 3
    //Используя Visual Studio, создайте проект по шаблону Console Application.
    //Используя динамические и анонимные типы данных, создайте Англо-Русский словарь на 10 слов и выведите на экран его содержание.

    class Program
    {
        static void Main(string[] args)
        {
            List<int> integers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            List<string> rus = new List<string>() { "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten" };
            List<string> eng = new List<string>() { "odin", "dva", "tri", "chetyre", "pyat", "west", "sem", "vosem", "devyat", "desyat" };

            var zip = integers.Zip(rus, (first, second) => $"{first} - {second}").Zip(eng, (first, second) => $"{first} - {second}");

            foreach (var item in zip)
                Console.WriteLine(item);

        }
    }
}
