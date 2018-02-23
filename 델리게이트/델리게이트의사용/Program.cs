using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/***********************************************
* 
*          델리게이트의 사용
*          
*        1. 델리게이트 선언
*        2. 델리게이트의 사용
* 
* *********************************************/
namespace 델리게이트의사용
{
    class Program
    {
        private delegate void MyDelegate(int num); // --- 1. 한정자 delegate 반환형 이름(매개변수)형식으로 선언한다.

        static void Gugudan(int num) // --- 1. 선언된 델리게이트 함수와 반환형, 매개변수 형식이 같아야한다.
        {
            for (int i = 1; i < 10; i++)
            {
                Console.WriteLine("{0} * {1} = {2}", num, i, num * i);
            }
        }

        static void Main(string[] args)
        {
            string number = string.Empty;

            MyDelegate callback = new MyDelegate(Gugudan); // --- 2. delegate의 인스턴스를 생성하고 호출할 메소드입력
                                                           //        => delgate함수가 대신해서 Gugudan함수를 호출하고 실행한다.

            while (true)
            {
                Console.Write("출력할 단의 숫자를 입력(종료하실려면 0을 입력) : ");
                number = Console.ReadLine();

                if(Convert.ToInt32(number) != 0)
                    callback(Convert.ToInt32(number)); // --- 2. 위에서 등록한 Gugudan 함수를 호출 및 실행
                else
                    break;
            }
        }
    }
}
