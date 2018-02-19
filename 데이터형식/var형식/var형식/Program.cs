using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/***********************************************************
 * 
 *                  var형식
 *       1. var형식의 자료형 사용
 *        - 컴파일러가 알아서 데이터에 맞는 자료형으로 변환
 *        - 지역변수로만 사용가능
 * 
 * *********************************************************/
namespace var형식
{
    class Program
    {
        public static void Main(String[] args)
        {
            /*** 1. var형식의 자료형 사용 ***/
            var item = 10; //정수 데이터 대입
            Console.WriteLine("item.Type = " + item.GetType());
            Console.WriteLine("item.value = " + item);
            Console.WriteLine();

            var item2 = "안녕하세요"; //문자열 데이터 대입
            Console.WriteLine("itme2.Type = " + item2.GetType());
            Console.WriteLine("item2.value = " + item2);
            Console.WriteLine();

            var item3 = 3.14f; //실수 데이터 대입
            Console.WriteLine("item3.Type = " + item3.GetType());
            Console.WriteLine("item3.value = " + item3);
            Console.WriteLine();

            var item4 = 'a'; //문자 데이터 대입
            Console.WriteLine("item4.Type = " + item4.GetType());
            Console.WriteLine("item4.value = " + item4);
            Console.WriteLine();
        }
    }
}
