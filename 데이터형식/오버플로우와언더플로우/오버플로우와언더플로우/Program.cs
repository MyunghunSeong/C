using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/***********************************************************
 * 
 *              오버플로우와 언더플로우 
 *  1. 오버플로우
 *   - 데이터가 가질 수 있는 최대범위를 넘은 현상 
 *  2. 언더플로우
 *   - 데이터가 가질 수 있는 최소범위를 넘은 현상 
 * 
 * *********************************************************/
namespace 오버플로우와언더플로우
{
    class Program
    {
        public static void Main(String[] args)
        {
            /*** 1. 오버플로우 ***/
            int max_num = int.MaxValue; //int형이 가질수 있는 최대 값(2147483647)
            Console.WriteLine("int.MaxValue = " + max_num);
            Console.WriteLine();

            max_num++; //1증가

            Console.WriteLine("=== max_num + 1 ===");
            Console.WriteLine("int.MaxValue =" + max_num); //오버플로우 발생(2147483647 -> -2147483648)
            Console.WriteLine();

            /*** 2. 언더플로우 ***/
            int min_num = int.MinValue; //int형이 가질수 있는 최소 값(-2147483648)
            Console.WriteLine("int.MinValue = " + min_num);
            Console.WriteLine();

            min_num -= 1; //1증가

            Console.WriteLine("=== min_num - 1 ===");
            Console.WriteLine("int.MinValue = " + min_num); //언더플로우 발생(-2147483648 -> 2147483647)
            Console.WriteLine();
        }
    }
}
