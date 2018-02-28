using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

/***********************************************
* 
*              쓰레드 동기화(lock)
*          
*           1. 멀티 쓰레드 실행
*           2. lock의 사용
* 
* *********************************************/
namespace ThreadSyncronize_lock_.cs
{
    class SyncThreadClass
    {
        private int m_test;
        private readonly object thisLock = new object();

        public SyncThreadClass()
        {
            m_test = 0;
        }

        public void PrintValue_One()
        {
            try
            {
                lock (thisLock) // --- 2. lock을 쓰면 쓰레드가 자원을 사용하는 동안 다른 쓰레드가 접근하지 못한다.(충돌 방지) - 동기화                  
                {
                    for (int i = 0; i < 5; i++)
                    {
                        m_test++;
                        Console.WriteLine("Thread_one : {0}", m_test);
                        Thread.Sleep(1000); //1초 슬립
                    }
                }
            }
            catch (ThreadInterruptedException e)
            {
                Console.WriteLine("쓰레드1이 인터럽트 되었습니다.");
            }
            finally
            {
                Console.WriteLine("Thread_one is finished!!");
            }
        }

        public void PrintValue_Two()
        {
            try
            {
                lock (thisLock)
                {
                    for (int i = 0; i < 5; i++)
                    {
                        m_test++;
                        Console.WriteLine("Thread_two : {0}", m_test);
                        Thread.Sleep(1000);
                    }
                }
            }
            catch (ThreadInterruptedException e)
            {
                Console.WriteLine("쓰레드2가 인터럽트 되었습니다.");
            }
            finally
            {
                Console.WriteLine("Thread_two is finished!!");
            }
        }

        public void PrintValue_Three()
        {
            try
            {
                lock (thisLock)
                {
                    for (int i = 0; i < 5; i++)
                    {
                        m_test++;
                        Console.WriteLine("Thread_three : {0}", m_test);
                        Thread.Sleep(1000);
                    }
                }
            }
            catch (ThreadInterruptedException e)
            {
                Console.WriteLine("쓰레드3이 인터럽트 되었습니다.");
            }
            finally
            {
                Console.WriteLine("Thread_three is finished!!");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            SyncThreadClass CSync = new SyncThreadClass();

            Thread thread1 = new Thread(new ThreadStart(CSync.PrintValue_One));
            Thread thread2 = new Thread(new ThreadStart(CSync.PrintValue_Two));
            Thread thread3 = new Thread(new ThreadStart(CSync.PrintValue_Three));

            thread1.Start(); //쓰레드 3개를 실행
            thread2.Start();
            thread3.Start();

            Action act1 = () =>
                {
                    string key = Console.ReadLine();

                    if (key == "1")
                    {
                        thread1.Interrupt();
                        thread1.Join();
                    }
                    else if (key == "3")
                    {
                        thread2.Interrupt();
                        thread2.Join();
                    }
                    else if (key == "3")
                    {
                        thread3.Interrupt();
                        thread3.Join();
                    }
                };

            Task keyAvailable = Task.Factory.StartNew(act1);

            keyAvailable.Wait();            

            /*
             * test(초기값 0)인 변수를 증가하면서 출력하는 프로그램에서
             * 3개의 쓰레드를 실행하게 되면 3개의 쓰레드가 동시에 자원에 접근하게 되고 
             * lock을 하지 않으면 쓰레드들은 랜덤한 test의 값을 가지게 됨
             */
        }
    }
}
