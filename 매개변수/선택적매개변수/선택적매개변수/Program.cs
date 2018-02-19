using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/***********************************************
 * 
 *              선택적매개변수
 *          1. 선택적 매개변수의 선언
 *          2. 선택적 매개변수의 전달
 * 
 * *********************************************/
namespace 선택적매개변수
{
    class Program
    {
        static void Main(string[] args)
        {
            new Program().ShowProfile(27); //지정하지 않은 age를 제외한 나머지 파라미터는 지정한 값으로 출력
            new Program().ShowProfile(30, "이도현"); //지정된 값 이외의 다른 값으로 바꿀 수도 있다.
            new Program().ShowProfile(22, "성현아", "여성");
        }

        /* 2. 선택적 매개변수의 전달*/
        private void ShowProfile(int age, string name = "성명훈", string gender = "남성") //매개변수의 값을 미리 지정할 수 있다.
        {
            Console.WriteLine(" name={0}\n age={1}\n gender={2}\n", name, age, gender);
        }
    }
}
