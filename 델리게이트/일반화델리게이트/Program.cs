using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/***********************************************
* 
*           일반화 델리게이트
*          
*        1. 델리게이트의 일반화 활용
* 
* *********************************************/
namespace 일반화델리게이트
{
    class Program
    {
        public delegate int Compare<T>(T a, T b); //일반화로 델리게이트를 선언

        static int AscendingFunc<T>(T a, T b) where T : IComparable<T> //올림차순으로 정렬하는 함수 => IComparable인터페이스를 상속받은 형식만 가능
        {
            return a.CompareTo(b); //a가 b보다 크면 1, 같으면 0, 작으면 -1을 리턴
        }

        static int DescendingFunc<T>(T a, T b) where T : IComparable<T> //내림차순으로 정렬하는 함수
        {
            return a.CompareTo(b) * -1; //결과에 -1을 곱함 => 크면 -1, 같으면 0, 작으면 1(올림차순과 반대의 결과)
        }

        static void BubbleSort<T>(T[] arr, Compare<T> compare) //배열 요소를 정렬하는 함수
        {
            T temp;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = 0; j < arr.Length - i - 1; j++)
                {
                    if (compare(arr[j], arr[j + 1]) > 0) //델리게이트 함수 호출
                    {
                        temp = arr[j + 1];
                        arr[j + 1] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
        }

        static void Main(string[] args)
        {
            int[] arr_int = { 20, 1, 4, 89, 28 }; //정수 타입
            string[] arr_str = { "abc", "def", "ghi", "jkl", "mno" }; //스트링 타입

            Console.WriteLine("========== Integer Type ==========");
            Console.WriteLine();

            Console.WriteLine("=== Ascending Array ===");
            BubbleSort<int>(arr_int, new Compare<int>(AscendingFunc<int>));

            for (int i = 0; i < arr_int.Length; i++)
                Console.WriteLine("Ascending Array Result = " + arr_int[i]);

            Console.WriteLine();

            Console.WriteLine("=== Descending Array ===");
            BubbleSort<int>(arr_int, new Compare<int>(DescendingFunc<int>));

            for (int i = 0; i < arr_int.Length; i++)
                Console.WriteLine("Descending Array Result = " + arr_int[i]);

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("========== String Type ==========");
            Console.WriteLine();

            Console.WriteLine("=== Ascending Array ===");
            BubbleSort<string>(arr_str, new Compare<string>(AscendingFunc<string>));

            for (int i = 0; i < arr_str.Length; i++)
                Console.WriteLine("Ascending Array Result = " + arr_str[i]);

            Console.WriteLine();

            Console.WriteLine("=== Descending Array ===");
            BubbleSort<string>(arr_str, new Compare<string>(DescendingFunc<string>));

            for (int i = 0; i < arr_str.Length; i++)
                Console.WriteLine("Descending Array Result = " + arr_str[i]);

        }
    }
}
