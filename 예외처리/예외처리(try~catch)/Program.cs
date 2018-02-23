using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 예외처리_try_catch_
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 10;
            int num2 = 0; 
            double result = 0;

            DivideException div = new DivideException();

            div.Div(ref num1, ref num2, ref result); //num2가 0이면 예외발생

            Console.WriteLine("result = " + result);
        }
    }
}
