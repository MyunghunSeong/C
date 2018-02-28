using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.IO;

/***********************************************
* 
*               쓰레드시작
*          
*           1. 쓰레드 시작
* 
* *********************************************/
namespace Threadstart.cs
{
    class Program
    {
        public static readonly int COUNT = 5;

        static void ThreadFunc()
        {
            for (int i = 0; i < COUNT*2; i++)
            {
                Console.WriteLine("Thread : " + i);
                Thread.Sleep(100);
            }
        }

        static void Main(string[] args)
        {
            Thread file_thread = new Thread(new ThreadStart(ThreadFunc)); //쓰레드를 선언

            try
            {
                file_thread.Start(); //쓰레드 호출(시작)
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                if ((file_thread.ThreadState & ThreadState.Running) == ThreadState.Running)
                    Console.WriteLine("Thread Started....");
            }

            for (int i = 0; i < COUNT; i++)
            {
                Console.WriteLine("Main : {0}", i);
            }

            file_thread.Join();

            Console.WriteLine("Thread Finished....");
        }
    }
}
