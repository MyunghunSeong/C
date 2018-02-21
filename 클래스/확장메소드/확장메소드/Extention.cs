using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/**********************************************************
 * 
 *                      확장메소드
 *                      
 *               1. 확장 메소드 선언 방법
 * 
 * ********************************************************/
namespace 확장메소드_extention // --- 1. 확장메소드 namespace 정의
{
    public static class Extention // --- 1. class 앞에 static 키워드를 붙여줘야 한다.
    {
        public static string ToReverse(this string str, int length) // --- 1. 메소드를 정의 할 때도 static을 붙여주고 반환형은 메소드를 확장할 데이터형식을 적어준다.
                                                                    //        이번 메소드는 string의 확장메소드 이므로 반환형은 string
        {
            String result = String.Empty;

            for (int i = 0; i < length; i++)
            {
                result += str[length - (i+1)];
            }

            return result;
        }

        public static int ToFactorial(this int num)
        {
            int result = num;

            for (int i = 1; i < num; i++)
            {
                result *= num - i;
            }

            return result;
        }
    }
}
