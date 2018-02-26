using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/***********************************************
* 
*               익명메소드 
*          
*           1. 익명 메소드 선언
*           2. 익명 메소드 사용
* 
* *********************************************/
namespace 익명메소드
{
    class Program
    {
        private delegate int CompareString(string str1, string str2);

        static void PrintResult(CompareString compare)
        {
            string str1 = string.Empty;
            string str2 = string.Empty;

            Console.Write("문자열1을 입력하세요 : ");
            str1 = Console.ReadLine();
            Console.Write("문자열2를 입력하세요 : ");
            str2 = Console.ReadLine();

            if (compare(str1, str2) == 0) // --- 2. 익명메소드를 호출
                Console.WriteLine("두 문자열이 같습니다.");          
            else
                Console.WriteLine("두 문자열이 같지 않습니다.");
        }

        static void Main(string[] args)
        {
            PrintResult(delegate(string source, string target) // --- 1. 익명메소드 선언(선언된 델리게이트 함수와 같은 형식으로 사용)
                                                               //        delgate(메개변수) { 코드 }의 형식으로 선언한다.(* 델리게이트와 반환형, 매개변수 형식은 같아야함)
                                {
                                    return source.CompareTo(target); //문자열이 같으면 0을 source가 더 크면(문자의 경우 알파벳 순서) 1, 작으면 -1을 리턴
                                });
        }
    }
}
