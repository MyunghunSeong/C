using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*****************************************
 * 
 *             일반화 메소드
 *      
 *          1. 일반화 메소드 선언
 *          2. 일반화 메소드 사용
 * 
 * ***************************************/
namespace 일반화메소드
{
    enum RETURN_TYPE
    {
        UNKNOWN = -1,
        INT32   = 0,
        STRING  ,
        kjlhjkhjk

    }
       
    class Program
    {
        public const int MAX = 10;

        static void PrintValue<T>(T oper1) // --- 1. 일반화 메소드 사용<>안에 T를 넣어서 선언한다.(T는 Type을 의미)
        {
            Console.WriteLine("value = " + oper1 + ", " + "Type = " + oper1.GetType());
        }

        static void Main(string[] args)
        {
            int[] num = new int[MAX];
            char[] array = { 'a', 'b', 'c', 'd', 'e'};

            Console.WriteLine("=== int형 ===");
            for (int i = 0; i < MAX; i++)
            {
                PrintValue<int>(i); // --- 2. int형으로 메서드를 사용
            }
            Console.WriteLine();

            Console.WriteLine("=== char형 ===");
            for (int i = 0; i < array.Length; i++)
            {
                PrintValue<char>(array[i]); // --- 2. char형으로 메서드를 사용
            }
        }
    }
}
