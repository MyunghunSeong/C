using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

/***********************************************
* 
*           델리게이트와 이벤트
*          
*        1. 객체에게 이벤트 알리기 순서
*        2. 이벤트 발생
* 
* *********************************************/
namespace 델리게이트와이벤트
{
    public delegate void MyDelegate(string str); // --- 1. 델리게이트 선언(1번)

    class MyEvent //event를 처리할 메소드와 이벤트핸들러를 담고있는 클래스
    {
        public event MyDelegate IsAlpha; // --- 1. 델리게이트를 이벤트 한정자를 사용하여 선언(2번)

        public void Alphabet(string str)
        {
            Regex regex = new Regex(@"[a-zA-z]");
            int count = 0;
            bool isalpha = regex.IsMatch(str); //알파벳인지 확인

            for (int i = 'a'; i < 'z'; i++)
            {
                count++; //알파벳의 갯수를 구함
            }

            int[] alpha_count = new int[count]; //알파벳의 갯수만큼 배열의 크기를 지정

            if (isalpha) //입력된 문자가 알파벳인 경우
            {
                for (int i = 0; i < str.Length; i++)
                {
                    for (int j = 'a'; j < 'z'; j++) //'a'부터 'z'까지 반복
                    {
                        if (str[i] == Convert.ToChar(j))
                            alpha_count[j - 'a']++; //알파벳 갯수를 증가
                    }
                }

                for (int k = 0; k < alpha_count.Length; k++)
                {
                    IsAlpha(string.Format("{0} = {1}", Convert.ToChar('a' + k), alpha_count[k])); //알파벳 갯수 출력
                }
            }  
        }
    }

    class Program
    {
        static void EventHandler(string str) // --- 1. 이벤트 핸들러 선언(델리게이트 함수와 형식이 같아야함)(3번)
        {
            Console.WriteLine(str);
        }
        
        static void Main(string[] args)
        {
            MyEvent myevent = new MyEvent();
            myevent.IsAlpha += new MyDelegate(EventHandler); // --- 1. 이벤트가 발생할 클래스의 객체를 생성하고 이벤트에 선언한 이벤트핸들러를 등록(4번)

            string str = string.Empty;

            Console.Write("문자를 입력하세요 : ");
            str = Console.ReadLine();
            Console.WriteLine();

            myevent.Alphabet(str); // --- 1. 입력한 문자열이 알파벳일 경우 이벤트가 발생(5번)
        }
    }
}
