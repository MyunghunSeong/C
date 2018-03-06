using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

/***********************************************
* 
*         쓰레드 동기화(Advanced_Monitor)
*          
*           1. Monitor Wait()
*           2. Monitor Pulse()
* 
* *********************************************/
namespace ThreadSyncronize_Advanced_Monitor_.cs
{
    class MyThreadClass
    {
        public const int LOOP = 10; //반복횟수
        bool bLockEnd = false; //lock해제를 확인할 부울변수
        private int num;
        readonly object thisLock; //동기화 객체

        public MyThreadClass()
        {
            thisLock = new object();
            num = 0;
        }

        public void AddNum() //숫자 더하는 함수
        {
            for (int i = 0; i < LOOP; i++) //10번 반복
            {
                lock (thisLock) //자원 접근 불가
                {
                    while(bLockEnd == true) //다른 쓰레드에서 자원을 사용하고 있는 중이면 
                        Monitor.Wait(thisLock); // --- 1. WaitQueue로 이동하고 자원해제

                    bLockEnd = true;
                    num = num+(i+1);
                    bLockEnd = false;

                    Monitor.Pulse(thisLock); // --- 2. WaitQueue에 있는 쓰레드를 다시 동작(자원 점유)
                }
            }
        }

        public void MulNum()
        {
            for (int i = 0; i < LOOP; i++)
            {
                lock (thisLock)
                {
                    while (bLockEnd == true)
                        Monitor.Wait(thisLock);

                    bLockEnd = true;
                    num = num * (i+1);
                    bLockEnd = false;

                    Monitor.Pulse(thisLock);
                }
            }
        }

        public int Num { get { return num; } }

    }

    class Program
    {
        static void Main(string[] args)
        {
            MyThreadClass th_class = new MyThreadClass();

            Thread thread1 = new Thread(() => th_class.AddNum());
            Thread thread2 = new Thread(() => th_class.MulNum());

            thread1.Start();
            thread1.Join();
            Console.WriteLine("Num(Add) =  {0}", th_class.Num);

            thread2.Start();
            thread2.Join();
            Console.WriteLine("Num(Mul) =  {0}", th_class.Num);
        }
    }
}
