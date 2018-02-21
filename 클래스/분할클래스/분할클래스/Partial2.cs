using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;

namespace 분할클래스
{
    partial class Partial2 // ----- 1. class 이름은 동일하게 작성해야한다.
    {
        public void Initial()
        {
            Console.Write("-------------------- 사칙연산 프로그램 --------------------");
            Console.WriteLine();
        }

        public void InputNumber(ref string num1, ref string num2)
        {
            Console.Write("숫자1을 입력하세요 : ");
            num1 = Console.ReadLine();
            Console.WriteLine();                                                                // 2. 두번째 클래스는 입/출력 기능의 메소드를 선언

            Console.Write("숫자2를 입력하세요 : ");
            num2 = Console.ReadLine();
            Console.WriteLine();
        }

        public void ShowResult(double result, string method_name)
        {
            Console.WriteLine(method_name + " Result = " + result);
        }
    }
}
