using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/***********************************************
 * 
 *          명명된매개변수
 *      1. 일반 매개변수 전달
 *      2. 명명된 매개변수 전달
 *      3. 명명된 매개변수의 사용이유
 * 
 * *********************************************/
namespace 명명된매개변수
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 1. 일반 매개변수 전달 */
            Console.WriteLine("=== 일반적으로 매개변수를 전달 ===");
            new Program().ShowProfile("성명훈", 27, "남성"); //함수에 선언되어있는 순서로 전달
            Console.WriteLine();

            /* 2. 명명된 매개변수 전달 */
            Console.WriteLine("=== 명시하여 매개변수를 전달 ===");
            new Program().ShowProfile(name: "성명훈", gender: "남성", age: 27); //선언된 순서와 상관없이 전달
                                                                                //매개변수 이름 : 매개변수 값 형태를 띔     
            Console.WriteLine();

            /* 3. 명명된 매개변수의 사용이유 */
             // 가독성을 높여주고 어떤 매개변수를 사용하는지 함수의 원형없이 확인할 수 있다.
        }

        private void ShowProfile(string name, int age, string gender)
        {
            Console.WriteLine("name = " + name + "\n" + "age = " + age + "\n" + "gender = " + gender);
        }
    }
}
