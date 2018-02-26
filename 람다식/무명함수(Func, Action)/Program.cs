using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


/***********************************************
* 
*           무명함수(Func, Action)
*          
*        1. Func 델리게이트
*        2. Action 델리게이트
* 
* *********************************************/
namespace 무명함수_Func__Action_
{
    class Program
    {      
        static void InputNumber(ref string str1, ref string str2) //정수 입력 함수
        {
            Console.Write("정수1을 입력하세요 : ");
            str1 = Console.ReadLine();
            Console.Write("정수2를 입력하세요 : ");
            str2 = Console.ReadLine();
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            // --- 1. Func 델리게이트
            Console.WriteLine("=== Func() ==="); //Func 델리게이트 : 매개변수와 반환형으로 이루어짐(반환 값이 있음) 
                                                 //Func<매개변수1, 매개변수2.... 반환형> 함수이름 = (매개변수) => 식

            Func<string> func1 = () => "안녕하세요"; //매개변수가 없는 Func 델리게이트 
            Console.WriteLine(func1());

            Func<char, int> func2 = (ch) => Convert.ToInt32(ch);  //매개변수가 1인 Func
            Console.WriteLine("'a' = > int형 : " + func2('a'));
            Console.WriteLine();
        
            string str_num1 = string.Empty;
            string str_num2 = string.Empty;

            InputNumber(ref str_num1, ref str_num2);

            Func<int, int, double> func3 = (num1, num2) =>
                            {
                                if (num2 != 0)
                                    return (double)num1 / num2; //블럭으로 구분해서 코드를 작성할 수도 있다.
                                else
                                    throw new DivideByZeroException();
                            };
            try
            {
                Console.WriteLine("{0} / {1} = {2:F2}", 
                    Convert.ToInt32(str_num1), Convert.ToInt32(str_num2), 
                    func3(Convert.ToInt32(str_num1), Convert.ToInt32(str_num2)));
            }
            catch
            {
                Console.WriteLine("0으로 나눌 수 없습니다.");
            }
            Console.WriteLine();

            // --- 1. Action 델리게이트
            Console.WriteLine("=== Action() ==="); //Action 델리게이트 : 매개변수와 반환형으로 이루어짐(반환 값이 없음) 
                                                   //Func 델리게이트와 형식은 같으며 차이점은 Action은 반환 값이 없다.

            Action act1 = () => Console.WriteLine("안녕하세요"); //매개변수가 1인 Action 델리게이트
            act1();

            int result = 0;
            Action<char> act2 = (cha) => result = Convert.ToInt32(cha); //매개변수가 2인 Action (반환 값이 없으므로 result를 선언해 결과를 저장)
            act2('a');
            Console.WriteLine("'a' = > int형 : " + result);
            Console.WriteLine();

            InputNumber(ref str_num1, ref str_num2);

            double div = 0;           
            Action<int, int> act3 = (num1, num2) =>
                    {
                        try
                        {
                            div = (double)num1 / num2;  //매개변수가 3개인 Action
                        }
                        catch (DivideByZeroException e)
                        {
                            Console.WriteLine(e.Message);
                        }
                    };
            act3(Convert.ToInt32(str_num1), Convert.ToInt32(str_num2));
            Console.WriteLine("{0} / {1} = {2:F2}",
                    Convert.ToInt32(str_num1), Convert.ToInt32(str_num2), div);
        }
    }
}
