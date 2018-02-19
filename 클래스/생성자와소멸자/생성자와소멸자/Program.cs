using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/***********************************************
 * 
 *              생성자와 소멸자
 *          1. 생성자 
 *          2. 소멸자
 * *********************************************/
namespace 생성자와소멸자
{
    class Producer
    {
        private string name = string.Empty;
        private string gender = string.Empty;
        private int age = 0;

        /* 1. 생성자(한정자 + 클래스이름) */
        public Producer() //매개변수가 없는 생성자 => 기본(디폴트) 생성자
        {
            Console.WriteLine("디폴트 생성자 호출 됨");
            name = "성명훈"; //멤버변수를 초기화 한다.
            gender = "남성";
            age = 27;
        }

        public Producer(string name, int age, string gender) //매개변수가 있는 생성자 => 사용자 정의 생성자
        {
            Console.WriteLine("매개변수 생성자 호출 됨");
            this.name = name; //맴버변수에 매개변수를 넣어준다.
            this.age = age;
            this.gender = gender;
        }

        public void ShowProfile()
        {
            Console.WriteLine("name = " + name + "\n" +
                              "age = " + age + "\n" +
                              "gender = " + gender + "\n");
            Console.WriteLine();
        }

        ~Producer() //소멸자 ~(클래스 이름)형식으로 선언
        {
            Console.WriteLine(name + " " + "소멸자 호출됨");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Producer producer = new Producer(); //객체가 생성될 때 생성자는 자동으로 호출(매개변수가 없으므로 디폴트 생성자 호출)
            producer.ShowProfile();
            Producer producer2 = new Producer("성현아", 22, "여성"); //매개변수가 있는 생성자 호출
            producer2.ShowProfile();

            //객체가 생성될 때 생성자 자동 호출 => 스택 메모리에 저장(1. producer 2. producer2)
            //프로그램이 종료되는 시점에서 소멸자는 스택 메모리에서 차례로 자동으로 호출됨(3. producer2 4. producer)
        }
    }
}
