using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EssentialLesson17Task1
{
    class Calculator
    {

        public static dynamic Plus(int a, int b, string type)
        {
            if (type == "int")
                return a + b;
            else
                return $"Result is: {a + b}";
        }

        public static dynamic Div(int a, int b, string type)
        {
            if (b == 0)
                return "The second arg is 0. Dividing is impossible";

            if (type == "int")
               return a / b;
            else
                return $"Result is: {a / b}";
        }

    }
}
