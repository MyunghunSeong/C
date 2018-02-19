using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*********************************************************
 * 
 *           Nullable형식 
 *  1. Nullable형식 변수 선언
 *   - Nullable형식의 변수는 자료형 끝에 ?를 붙여서 선언
 *   - 메모리를 비워둘 때 사용(원래 쓰레기값이 들어감)
 *  2. HasValue와 Value
 *   - Nullable변수가 가지고 있는 속성
 *   - HasValue : 변수가 값을 가지고있는지 여부
 *   - Value : 변수가 가지고 있는 값
 * 
 * *******************************************************/
namespace Nullable형식
{
    class Program
    {
        public static void Main(String[] args)
        {
            /*** 1. Nullable형식 변수 선언 ***/
            int integer = 0; //일반 변수 널 값으로 초기화 불가능(Memory값 : 0)
            int? nullable = null; //Nullable 변수 선언 널 값으로 초기화 가능(Memory값 : 없음)

            /*** 2. HasValue와 Value ***/
            Console.WriteLine(" ===  HasValue와 Value ===");
            Console.WriteLine("nullable.HasValue = " + nullable.HasValue); //값이 있으면 true, 없으면 false를 반환
            nullable = 10; //값을 대입
            Console.WriteLine();
            Console.WriteLine(" ===  값 대입 후 ===");
            Console.WriteLine("nullable.Value = " + nullable.Value);  //nullable = 10이므로 10이 출력
            Console.WriteLine("nullable.HasValue = " + nullable.HasValue); //값이 있으면 true, 없으면 false를 반환
            Console.WriteLine();
        }
    }
}
