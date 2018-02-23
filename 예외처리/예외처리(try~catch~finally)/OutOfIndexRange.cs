using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/***********************************************
 * 
 *           예외처리(try~catch~finally)
 *          
 *        1. try~catch~finally의 사용
 * 
 * *********************************************/
namespace 예외처리_try_catch_finally_
{
    class OutOfIndexRange
    {
        private int size = 10;

        public void PrintValue(ref string[] arr) //arr size : 5
        {
            while (true)
            {
                try
                {
                    for (int i = 0; i < size; i++) //size = 10
                    {
                        Console.WriteLine("arr{0} = {1}", i, arr[i]); //arr의 배열요소를 size만큼 출력
                    }
                }
                catch (IndexOutOfRangeException e)
                {
                    Console.WriteLine(e.Message); //arr의 배열 크기보다 size가 더 크기 때문에 예외가 발생
                }
                finally
                {
                    Array.Resize<string>(ref arr, arr.Length + 1); //배열 요소를 하나 증가
                    arr[arr.Length-1] = "arr" + (arr.Length-1); //증가된 배열 요소에 새로운 값을 저장
                    Console.WriteLine("Print Range {0} -> {1}", arr.Length-1, arr.Length); 
                }
                if (arr.Length == size) //배열의 크기가 size와 같아지면 루프문 탈출
                    break;
            }       
        }
    }
}
