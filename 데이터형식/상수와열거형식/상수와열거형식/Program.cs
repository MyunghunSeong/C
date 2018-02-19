using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/************************************************
 * 
 *           상수와 열거형식 
 *  1. 상수선언 및 출력
 *   - 상수는 const키워드를 사용하여 선언
 *   - 상수 값은 변경할 수 없음
 *  2. 열거형식 enum
 *   - 여러개의 상수를 열거할 때 사용
 *   - 첫번째 요소부터 0부터 1씩 증가
 *   - 항목에 값을 넣어주면 그 이후 값부터 1증가
 * 
 * **********************************************/
namespace 상수와열거형식
{
    class Program
    {
        enum NUMBER { ONE = 1, TWO, THREE, FOUR, FIVE } //enum으로 열거형식 선언
        enum ALPHA { A, B = 3, C, D = 7, E }

        public static void Main(String[] args)
        {
            Console.WriteLine("/*** 1. 상수선언 및 출력 ***/");
            const int ARR_SIZE = 100; //const키워드 사용(상수)
            Console.WriteLine("ARR_SIZE = " + ARR_SIZE);

            int[] arr = new int[ARR_SIZE]; //ARR_SIZE만큼 배열의 크기를 지정
            Console.WriteLine("Size of array= " + arr.Length); //배열의 크기를 출력
            Console.WriteLine();

            Console.WriteLine("/*** 2. 열거형식 enum ***/");
            Console.WriteLine("NUMBER(enum).ONE = " + (int)NUMBER.ONE); //ONE = 1
            Console.WriteLine("NUMBER(enum).TWO = " + (int)NUMBER.TWO);
            Console.WriteLine("NUMBER(enum).THREE = " + (int)NUMBER.THREE);   //enum 항목 출력
            Console.WriteLine("NUMBER(enum).FOUR = " + (int)NUMBER.FOUR);
            Console.WriteLine("NUMBER(enum).FIVE = " + (int)NUMBER.FIVE);
            Console.WriteLine();

            Console.WriteLine("ALPHA(enum).A = " + (int)ALPHA.A); //A는 디폴트값으로 0
            Console.WriteLine("ALPHA(enum).B = " + (int)ALPHA.B);  //B = 3
            Console.WriteLine("ALPHA(enum).C = " + (int)ALPHA.C); //C는 1증가한 4
            Console.WriteLine("ALPHA(enum).D = " + (int)ALPHA.D); //D=7
            Console.WriteLine("ALPHA(enum).E = " + (int)ALPHA.E); //E는 1증가한 8
            Console.WriteLine();
        }
    }
}
