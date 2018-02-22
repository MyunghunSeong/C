using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

/***********************************
 * 
 *          배열의컬렉션
 *          
 *      1. ArrayList
 *      2. Queue
 *      3. Stack
 * 
 * *********************************/
namespace 배열의컬렉션
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList arrayList = new ArrayList(); // --- 1. ArrayList 선언 

            arrayList.Add("성명훈");  // --- 1. 파라미터를 object형식으로 받기 때문에 모든 데이터를 저장할 수 있다.
            arrayList.Add(27);

            Console.WriteLine(" === arrayList Elements ===");
            for (int i = 0; i < arrayList.Count; i++)
            {
                Console.WriteLine("arrayList[" + i + "] = " + arrayList[i]); //ArrayList항목 출력             
            }
            Console.WriteLine();


            Queue queue = new Queue(); // --- 2. 큐 선언(First-In-First-Out의 구조를 가지고 있다.)

            Console.WriteLine("=== EnQueue ===");
            for (int i = 0; i < 5; i++)
            {
                queue.Enqueue(i+1); // 1부터 5까지 큐에 저장.

                object[] queueArray = new object[5];
                queueArray = queue.ToArray();

                Console.WriteLine("{0}번째 queue = {1}", i+1, queueArray[i]); //0~5번째 까지 요소 출력(순차적으로 출력됨)
            }
            Console.WriteLine();


            Console.WriteLine("=== DeQueue ===");
            int count = 0;

            while(queue.Count > 0)
            {              
                count++;
                Console.WriteLine("{0}번째 queue({1}) 삭제!", count, queue.Dequeue()); //순차적으로 삭제(처음 들어온 것부터 삭제)
            }
            Console.WriteLine();

            Stack stack = new Stack(); // --- 3. 스택 선언(First-In-Last-Out의 구조를 가지고 있다.)

            Console.WriteLine("=== push ===");
            for (int i = 0; i < 5; i++)
            {
                stack.Push(i+1); //1부터 5까지 스택에 저장.

                object[] stackArray = new object[5];
                stackArray = stack.ToArray();

                Console.WriteLine("{0}번째 stack = {1}", i + 1, stackArray[i-i]); //첫 번째 위치에 새로운 값이 들어가고 기존 값은 한칸 이동
                                                                                  //첫 번째가 가장 나중에 삭제되기 때문
            }
            Console.WriteLine();

            count = 0;

            Console.WriteLine("=== pop ===");

            while(stack.Count > 0)
            {
                count++;
                Console.WriteLine("{0}번째 queue({1}) 삭제!", count, stack.Pop()); //마지막 요소부터 차례대로 삭제(큐의 반대)
            }
        }
    }
}
