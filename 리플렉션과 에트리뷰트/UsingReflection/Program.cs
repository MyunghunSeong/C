using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;

/***********************************************
* 
*           리플렉션의 사용
*          
*        1. 리플렉션의 사용
*        2. 리플렉션의 이점
* 
* *********************************************/
namespace UsingReflection.cs
{
    class Reflection<T> //리플렉션 클래스 선언(일반화 클래스)
    {
        private List<T> list; 

        public Reflection()
        {
            list = new List<T>(); //리스트 초기화
        }

        public void PrintListElements() //리스트의 요소를 출력하는 메소드
        {
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine("list{0} = {1}", i, list[i]);
            }
        }

        public T SetReflection { set { list.Add(value); } } //리스트에 값을 셋팅하는 프로퍼티 
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<string> value_list = new List<string>(); //사용자가 입력받는 값을 저장하는 공간
            string method_name = string.Empty; //메소드 이름 --- 2. 런타임시 사용자가 메소드를 입력하여 실행할 수 있다. 
            string property_name = string.Empty; //프로퍼티 이름
   
            /* 1. 리플렉션의 선언 */
            Type type = typeof(Reflection<string>); //Reflection 클래스의 형식을 가져옴
            Reflection<string> reflection = (Reflection<string>)Activator.CreateInstance(type); //인스턴스 생성

            Console.Write("실행할 메소드 이름을 입력하세요 : ");
            method_name = Console.ReadLine();
            MethodInfo method = type.GetMethod(method_name); //메소드를 가져옴

            Console.Write("프로퍼티 이름을 입력하세요 : ");
            property_name = Console.ReadLine();
            PropertyInfo setlist = type.GetProperty(property_name); //프로퍼티를 가져옴

            Console.Write("반복 횟수 입력 : ");
            string loop = Console.ReadLine();

            try
            {
                for (int i = 0; i < Convert.ToInt32(loop); i++)
                {
                    Console.Write(setlist.PropertyType + "형식의 값을 입력하세요 : ");
                    string value = Console.ReadLine();
                    value_list.Add(value);
                    setlist.SetValue(reflection, value, null); //프로퍼티에 값을 입력
                }

               
                method.Invoke(reflection, null); //메소드 실행
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
                      
        }
    }
}
