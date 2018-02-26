using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/***********************************************
* 
*               에트리뷰트
*          
*           1. 에트리뷰트 사용
*           2. 주석과 차이점
* 
* *********************************************/
namespace Attribute_Example.cs
{
    [Information("Attribut_Example_Program", Author="성명훈", Version=1.0)] // --- 1. 부가적인 정보를 나타낼 때 사용
    [Information("Attribute_Example_program", Author="성현아", Version=1.1)] // --- 2. 주석 : 사람이 쓰고 사람이 읽음                                                                         //        에트리뷰트 : 사람이 쓰고 컴퓨터가 읽음
    class Program
    {
        static void Main(string[] args) //Main Func()
        {
            Type type = typeof(Program);
            Attribute[] attributes = Attribute.GetCustomAttributes(type);

            Console.WriteLine("=== Main Information ===");

            foreach (Attribute att in attributes)
            {
                Information info = att as Information;
                if (info != null)
                    Console.WriteLine("Program : " + info.Program + "\n" +
                                      "Author : " + info.Author + "\n" +
                                      "Version : " + info.Version + "\n" +
                                      "Date : " + DateTime.Now);
                Console.WriteLine();
            }

           
        }
    }
}
