using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/************************************************
 * 
 *                    변수 
 *  1. 선언
 *  2. 초기화
 *  3. 선언와 초기화
 * 
 * **********************************************/

namespace 변수
{
    class Program
    {
        public static void Main(String[] args)
        {
            /*** 1. 선언 ***/
            int i;
            int a, b, c; //여러 변수를 쉼표(,)로 구분해서 선언할 수 있다.

            /*** 2. 초기화 ***/
            i = 10; //10의 데이터를 할당

            /*** 3. 선언과 초기화 ***/
            int x = 10; //선언과 초기화를 동시에 진행
            int e = 20, f = 30, g = 40; //선언과 마찬가리고 쉼표(,)로 구분하여 선언과 같이 초기화를 진행       

            Console.WriteLine("변수 x = " + x);
            Console.WriteLine("변수 e = " + e);
            Console.WriteLine("변수 f = " + f);
            Console.WriteLine("변수 g = " + g);
        }
    }
}
