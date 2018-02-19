using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/***********************************************
 * 
 *          가변길이 매개변수
 *      1. params 키워드 사용
 * 
 * *********************************************/
namespace 가변길이매개변수
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== 매개변수 3개 ===");
            new Program().sum(1, 2, 3);
            Console.WriteLine("=== 매개변수 4개 ===");
            new Program().sum(1, 2, 3, 4);
            Console.WriteLine("=== 매개변수 5개 ===");
            new Program().sum(1, 2, 3, 4, 5);
        }

        /* 1. params 키워드 사용 */
        private void sum(params int[] arr) //가변적으로 들어오는 매개변수에 대해서 params키워드를 사용하여 해결 
        {
            int sum = 0;
            foreach(int value in arr)
            {
                sum += value;
            }

            Console.WriteLine("size of arr = " + arr.Length);
            Console.WriteLine("result = " + sum);
            Console.WriteLine();
        }
    }
}
