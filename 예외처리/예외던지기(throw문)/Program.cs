using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/***********************************************
 * 
 *          출력전용매개변수
 *          
 *        1. throw된 예외 처리하기
 * 
 * *********************************************/
namespace 예외던지기_throw문_
{
    class Program
    {
        static void Main(string[] args)
        {
            string num1 = string.Empty;
            string num2 = string.Empty;

            ExceptionThrow throw_ex = new ExceptionThrow();

            Console.Write("정수1을 입력하세요 : ");
            num1 = Console.ReadLine();
            Console.Write("정수2를 입력하세요 : ");
            num2 = Console.ReadLine();

            try
            {
                throw_ex.Div(Convert.ToInt32(num1), Convert.ToInt32(num2)); // --- 1. Div함수를 호출(기능실행)
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine(e.Message); // --- 1. Div함수에서 throw한 예외를 받아 처리한다.
            }
        }
    }
}
