using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/***********************************************
 * 
 *          예외처리(try~catch)
 *          
 *        1. try~catch문 사용
 *        2. 예외 발생 상황
 * 
 * *********************************************/
namespace 예외처리_try_catch_
{
    class DivideException
    {
        public void Div(ref int num1, ref int num2, ref double result)
        {
            try // --- 1. try문 안에 해당 작업을 작성한다.
            {
                result = num1 / num2; 
            }
            catch (DivideByZeroException e) // --- 1. 나누는 수(num2)가 0일 때 발생하는 예외에 대해서 catch문에서 처리한다.
            {
                Console.WriteLine("0으로 나눌 수 없습니다."); //메시지 출력
            }
        }
    }
}
