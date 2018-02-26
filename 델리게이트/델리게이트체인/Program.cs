using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/***********************************************
* 
*           델리게이트 체인
*          
*        1. 델리게이트 체인 등록
*        2. 델리게이트 체인 활용
* 
* *********************************************/
namespace 델리게이트체인
{
    class Program
    {
        public delegate void Arithmetic(int a, int b); //델리게이트 선언

        static void Add(int a, int b) //덧셈
        {
            Console.WriteLine("add = " + (a + b));
        }

        static void Sub(int a, int b) //뺄셈
        {
            Console.WriteLine("sub = " + (a - b));
        }

        static void Mul(int a, int b) //곱셈
        {
            Console.WriteLine("mul = " + (a * b));
        }

        static void Div(int a, int b) //나눗셈
        {
            if (b != 0)
            {
                double result = (double)a / b;
                Console.WriteLine("div = {0:F2}", result);
            }
            else
                throw new DivideByZeroException();
        }
        

        static void Main(string[] args)
        {
            int num1 = 0;
            int num2 = 0;

            Console.Write("정수1을 입력하세요 : ");
            string str_num1 = Console.ReadLine();
            num1 = Convert.ToInt32(str_num1);
            Console.WriteLine();

            Console.Write("정수2를 입력하세요 : ");
            string str_num2 = Console.ReadLine();
            num2 = Convert.ToInt32(str_num2);
            Console.WriteLine();

            /* 1. 델리게이트 체인 등록 */
            Arithmetic ari = new Arithmetic(Add);
            ari += new Arithmetic(Sub); //델리게이트 체인(+=연산자 이용)으로 메서드 중복 등록
            ari += new Arithmetic(Mul); 
            ari -= new Arithmetic(Sub); //-=연산자를 이용해 델리게이트 해제
            ari += new Arithmetic(Div);

            try
            {
                ari(num1, num2); // --- 2. 델리게이트 체인 사용(등록된 함수읙 결과가 모두 출력)
            }
            catch(DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
            }
       }
    }
}
