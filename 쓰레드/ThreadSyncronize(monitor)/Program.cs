using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

/***********************************************
* 
*              쓰레드 동기화(monitor)
*          
*           1. 멀티 쓰레드 실행
*           2. monitor의 사용
* 
* *********************************************/
namespace ThreadSyncronize_monitor_.cs
{
    class SyncThreadClass
    {
        private int m_test;
        private readonly object thisLock = new object();

        public SyncThreadClass()
        {
            m_test = 0;
        }

        public void PrintIntValue()
        {
            try
            {
                Monitor.Enter(thisLock); //다른 프로세스 자원 접근 불가(점유, lock상태)
                for (int i = 0; i < 10; i++)
                {
                    m_test++;
                    Console.WriteLine("Thread_one : {0}", m_test);
                    Thread.Sleep(100);
                }
            }
            catch (ThreadInterruptedException e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("Thread(int) is finished!!");
                Monitor.Exit(thisLock); //lock해제 (자원 반납, 접근 가능)
            }
        }

        public void PrintStringValue()
        {
            try
            {
                Monitor.Enter(thisLock);
                for (int i = 0; i < 5; i++)
                {
                    m_test++;
                    Console.WriteLine("Thread_two : {0}", m_test);
                    Thread.Sleep(100);
                }
            }
            catch (ThreadInterruptedException e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("Thread(string) is finished!!");
                Monitor.Exit(thisLock);
            }
        }

        public void PrintCharValue()
        {
            try
            {
                Monitor.Enter(thisLock);
                for (int i = 0; i < 20; i++)
                {
                    m_test--;
                    Console.WriteLine("Thread_three : {0}", m_test);
                    Thread.Sleep(100);
                }
            }
            catch (ThreadInterruptedException e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("Thread(char) is finished!!");
                Monitor.Exit(thisLock);
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            SyncThreadClass CSync = new SyncThreadClass();

            Thread str_thread = new Thread(new ThreadStart(CSync.PrintStringValue));
            Thread int_thread = new Thread(new ThreadStart(CSync.PrintIntValue));
            Thread char_thread = new Thread(new ThreadStart(CSync.PrintCharValue));

            int_thread.Start(); //쓰레드 3개를 실행
            str_thread.Start();
            char_thread.Start();

            if (Console.KeyAvailable)
            {
                str_thread.Interrupt();
                str_thread.Join();
                int_thread.Interrupt();
                int_thread.Join();
                char_thread.Interrupt();
                char_thread.Join();
            }
        }
    }
}
