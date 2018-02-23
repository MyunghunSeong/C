using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 예외처리_try_catch_finally_
{
    class Program
    {
        static void Main(string[] args)
        {
            OutOfIndexRange range = new OutOfIndexRange();
            string[] arr = new string[5];

            for(int i = 0; i < arr.Length; i++)
            {
                arr[i] = "arr" + i;
            }

            range.PrintValue(ref arr);
        }
    }
}
