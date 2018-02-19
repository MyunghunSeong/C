using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/***********************************************
 * 
 *          메소드 오버로딩
 *         1. 메소드의 오버로딩
 *         
 * *********************************************/
namespace 메소드오버로딩
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 10, num2 = 5;
            string str1 = "hello, ", str2 = "world!!";

            Console.WriteLine((new Program()).Add(num1, num2)); //int Add(int, int);
            Console.WriteLine((new Program()).Add(str1, str2)); //string Add(string, string);
        }

        /* 1. 메소드의 오버로딩 */
        private string Add(string a, string b) // 함수이름 : Add, 매개변수type : string, string, 반환타입 : string
        {
            return a + b;
        }

        private int Add(int a, int b) //함수이름 : Add, 매개변수type : int, int, 반환타입 : int
        {
            return a + b;
        }

        /*
         *  같은 이름의 메소드에 매개변수, 반환타입 등을 다르게 하여 메소드를 재정의하는 것을 말한다.
         */
    }
}
