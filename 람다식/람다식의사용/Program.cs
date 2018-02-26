using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/***********************************************
* 
*                  람다식의 사용
*          
*                 1. 람다식 선언
*                 2. 람다식 사용
* 
* *********************************************/
namespace 람다식의사용
{
    public delegate void PrintDelegate<T>(T[] val); //람다식에 사용될 델리게이트 선언
 
    class Program
    {
        public const int SIZE = 3;
        static void Main(string[] args)
        {
            string[] str_arr = new string[SIZE];
            int[] int_arr = new int[SIZE];
            double[] double_arr = new double[SIZE];

            for(int i = 0; i < SIZE; i++)
            {
                Console.Write("값을 입력하세요 : ");
                string val = Console.ReadLine();
                int_arr[i] = Convert.ToInt32(val);
            }

            PrintDelegate<int> dele = (arr) =>
                                {
                                    for (int i = 0; i < arr.Length; i++)  //람다식 사용(매개변수목록 => 코드)
                                                                          //익명함수를 만들기위해 람다식을 사용
                                        Console.WriteLine(arr[i]);
                                };

            Console.WriteLine();

            dele(int_arr); //함수 호출
        }
    }
}
