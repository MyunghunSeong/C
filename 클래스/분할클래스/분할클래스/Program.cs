using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;

/**********************************************************
 * 
 *                  분할 클래스
 *               
 *              *Partial Class 참조
 * 
 * ********************************************************/
namespace 분할클래스
{
    class Program
    {
        static void Main(string[] args)
        {
            string num1 = string.Empty;
            string num2 = string.Empty;
            double result = 0;
            string method_name = string.Empty;            

            Partial2 partial = new Partial2(); //클래스 객체를 선언하고 partial로 분할 된 메소드에 접근이 가능하다.

            partial.Initial();
            partial.InputNumber(ref num1, ref num2);

            partial.Add(Int32.Parse(num1), Int32.Parse(num2), ref result, ref method_name);
            partial.ShowResult(result, method_name);
            partial.Sub(Int32.Parse(num1), Int32.Parse(num2), ref result, ref method_name);
            partial.ShowResult(result, method_name);
            partial.Mul(Convert.ToInt32(num1), Convert.ToInt32(num2), ref result, ref method_name);
            partial.ShowResult(result, method_name);
            partial.Div(Convert.ToInt32(num1), Convert.ToInt32(num2), ref result, ref method_name);
            partial.ShowResult(result, method_name);
        }
    }
}
