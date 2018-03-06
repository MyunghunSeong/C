using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

/***********************************************
* 
*           Task의 선언 및 사용
*          
*           1. Task 선언
*           2. Task 사용
* 
* *********************************************/
namespace UsingTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Action<object> Add = (num) => //Action 무명함수 선언(매개변수 o)
                {
                    int[] arr_num = (int[])num;

                    int result = arr_num[0] + arr_num[1];

                    Console.Write("TaskID = {0}, ThreadID = {1}, Add Result = {2}", Task.CurrentId, Thread.CurrentThread.ManagedThreadId, result);
                    Console.WriteLine();
                };

            Task add_task = new Task(Add, new int[] {10, 5}); //Task선언(파라미터로 Action무명함수와 오브젝트형 변수를 받는다.)

            Action<object> Sub = (num) =>
                {
                    int[] arr_num = (int[])num;

                    int result = arr_num[0] - arr_num[1];

                    Console.Write("TaskID = {0}, ThreadID = {1}, Sub Result = {2}", Task.CurrentId, Thread.CurrentThread.ManagedThreadId, result);
                    Console.WriteLine();
                };

            Task sub_task = Task.Factory.StartNew(Sub, new int[] { 10, 5 }); //TaskFactory를 이용한 선언과 동시에 실행하기

            Action<object> Mul = (num) =>
                {
                    int[] arr_num = (int[])num;

                    int result = arr_num[0] * arr_num[1];

                    Console.Write("TaskID = {0}, ThreadID = {1}, Mul Result = {2}", Task.CurrentId, Thread.CurrentThread.ManagedThreadId, result);
                    Console.WriteLine();
                };

            Task mul_task = Task.Factory.StartNew(Mul, new int[] { 10, 5 }); //Task를 비동기적으로 실행

            /*
             * Task는 쓰레드를 비동기적 혹은 병행적으로 실행하기 위해서 사용한다.
             */

            add_task.RunSynchronously(); //add_task에 대해 동기적으로 실행

            add_task.Wait();
            sub_task.Wait();
            mul_task.Wait();
        }
    }
}
