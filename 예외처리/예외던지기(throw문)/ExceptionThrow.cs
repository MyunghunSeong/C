using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 예외던지기_throw문_
{
    class ExceptionThrow
    {
        public void Div(int a, int b)
        {
            int result = 0;

            if (b != 0)
                result = a / b;
            else
                throw new DivideByZeroException(); //Div함수에게 예외가 던저진다. => Div함수를 호출한 쪽에서 예외를 처리
        }
    }
}
