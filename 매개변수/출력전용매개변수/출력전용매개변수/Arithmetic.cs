using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 출력전용매개변수
{
    class Arithmetic
    {
        public void Add(int num1, int num2, out int result)
        {
            result = num1 + num2;
        }

        public void Sub(int num1, int num2, out int result)
        {
            result = num1 - num2;
        }

        public void Mul(int num1, int num2, out int result)
        {
            result = num1 * num2;
        }

        public void Div(int num1, int num2, ref double result)
        {
            if (num2 == 0)
                num2 = 1;

            result = (double)num1 / num2;
        }
    }
}
