using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/***********************************************************
 * 
 *              박싱과 언박싱 
 *  1. 박싱
 *   - object자료형에 값을 넣을 때 힙 메모리에 저장하는 방식 
 *  2. 언박싱
 *   - object형식 데이터를 다른 자료형으로 저장할 때 사용
 * 
 * *********************************************************/
namespace 박싱과언박싱
{
    class Program
    {
        public static void Main(String[] args)
        {
            /*** 1. 박싱 ***/
            object obj1 = 10; //박싱해서 힙 메모리에 저장 => obj1은 10이 담긴 주소를 가지고 있음
            object obj2 = 'a';
            Console.WriteLine("obj1.Type = " + obj1.GetType()); //int타입
            Console.WriteLine("obj2.Type = " + obj2.GetType()); //char타입
            Console.WriteLine("obj1.value = " + obj1);
            Console.WriteLine("obj2.value = " + obj2);
            Console.WriteLine();

            /*** 2. 언박싱 ***/
            int integer = (int)obj1; //(int)와 같은 형식으로 언박싱
            char c = (char)obj2;
            Console.WriteLine("integer.value = " + integer);
            Console.WriteLine("c.value = " + c);
        }
    }
}
