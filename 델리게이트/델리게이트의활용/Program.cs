using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/***********************************************
 * 
 *          델리게이트의 활용
 *          
 *        1. 델리게이트의 활용
 * 
 * *********************************************/
namespace 델리게이트의활용
{
    class Program
    {
        private delegate List<string> SetArray(List<string> arr); //델리게이트 선언

        static List<string> SettingValue(List<string> arr) //리스트의 요소를 입력하는 메서드
        {         
            Console.Write("배열의 요소를 입력하세요 : ");
            string val = Console.ReadLine();

            arr.Add(val);
            Console.WriteLine();

            return arr;
        }

        static void PrintArray(List<string> arr, SetArray deleFunc) //리스트의 요소를 출력하는 메서드
        {
            Console.WriteLine("=== 요소 출력 ===");
            for (int i = 0; i < deleFunc(arr).Count; i++) //delegate를 활용해서 리스트에 요소를 입력
            {
                Console.WriteLine("Array({0}) = {1}", i, arr[i]); //입력된 요소를 출력
            }
            
        }

        static void Main(string[] args)
        {
            List<string> array = new List<string>();

            PrintArray(array, new SetArray(SettingValue));
        }
    }
}
