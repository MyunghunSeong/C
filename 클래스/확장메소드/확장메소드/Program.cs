using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using 확장메소드_extention; //확장메소드를 사용하기 위해 namespace 사용
using 확장메소드_ExClass;
using 확장메소드_ex;

/**********************************************************
 * 
 *                      확장메소드
 *               1. ToReverse() 함수 정의
 *               2. ToFactorial() 함수 정의
 * 
 * ********************************************************/
namespace 확장메소드
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = string.Empty;
            string str2 = "hello";

            Console.Write("문자열을 입력하세요 : ");
            str = Console.ReadLine();

            Console.WriteLine(str.ToReverse(str.Length)); //1. string형식의 내장메소드를 확장해서 ToReverse()함수를 정의했으며 매개변수는 뒤집을 문자열의 길이
            Console.WriteLine(str2.ToReverse(str2.Length));

            string num = string.Empty;

            Console.Write("숫자를 입력하세요 : ");
            num = Console.ReadLine();

            Console.WriteLine(Convert.ToInt32(num).ToFactorial()); //2. int형식의 메소드 확장(ToFactorial()을 정의) => 입력 숫자.메소드명() : 팩토리얼 결과 출력

            ExClass ex = new ExClass();

            Console.WriteLine();
            Console.WriteLine(ex.ShowName("성명훈"));
        }
    }
}
