using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;

/**********************************************************
 * 
 *                  분할 클래스
 *               
 *              1. 분할 클래스 선언
 *              2. 분할 클래스 역활
 * 
 * ********************************************************/
namespace 분할클래스
{
    partial class Partial2 // ----- 1. 분할 클래스 선언(calss 앞에 partial 키워드를 붙여주면 된다.)
    {
        public void Add(int num1, int num2, ref double result, ref string method_name)
        {
            MethodBase method = MethodBase.GetCurrentMethod();
            result = (double)num1 + num2;
            method_name = method.Name;
        }

        public void Sub(int num1, int num2, ref double result, ref string method_name)
        {
            MethodBase method = MethodBase.GetCurrentMethod(); //햔재 실행되는 메소드를 가지고 온다.
            result = (double)num1 - num2;
            method_name = method.Name; //현재 메소드(Sub)의 이름을 저장
        }

        public void Mul(int num1, int num2, ref double result, ref string method_name)
        {
            MethodBase method = MethodBase.GetCurrentMethod();
            result = (double)num1 * num2;                                                           // 2. 첫번째 클래스는 사칙연산을 하는 메소드를 선언
            method_name = method.Name;
        }

        public void Div(int num1, int num2, ref double result, ref string method_name)
        {
            MethodBase method = MethodBase.GetCurrentMethod();
            if (num2 != 0)
                result = (double)num1 / num2;
            else
                Console.WriteLine("0으로 나눌 수 없습니다.");
            method_name = method.Name;
        }
    }

}
