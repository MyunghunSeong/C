using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/***********************************************
 * 
 *          출력전용매개변수
 *          
 *        1. 출력전용매개변수 특징
 *        2. ref와 out의 차이점
 * 
 * *********************************************/
namespace 출력전용매개변수
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 10, num2 = 5;
            /* 1. 출력전용매개변수 특징*/
            int out_result; //out매개변수(출력전용)
            double ref_result = 0; //ref매개변수(참조)

            Arithmetic ari = new Arithmetic();

            Console.WriteLine("=== Initial Value ===");
            Console.WriteLine("num1 = " + num1 + " && " + "num2 = " + num2);
            Console.WriteLine();

            /* 2. ref와 out의 차이점 */
            Console.WriteLine("=== Arithmetic Operation ===");
            ari.Add(num1, num2, out out_result);
            Console.WriteLine("num1 + num2 = " + out_result);
            ari.Sub(num1, num2, out out_result);
            Console.WriteLine("num1 - num2 = " + out_result);
            ari.Mul(num1, num2, out out_result);                //out매개변수는 쓰기전용이고 초기화를 하지 않아도 됨.
            Console.WriteLine("num1 * num2 = " + out_result);
            ari.Div(num1, num2, ref ref_result);              //ref매개변수는 초기화를 하지 않으면 컴파일 오류가 발생.
            Console.WriteLine("num1 / num2 = " + ref_result);


            /*
             * ref와 out 모두 결과는 동일하게 출력된다. 
             */

            Console.WriteLine();
        }
    }
}
