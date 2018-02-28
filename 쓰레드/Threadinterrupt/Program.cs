using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Runtime.InteropServices;
using System.IO;

/***********************************************
* 
*               쓰레드(인터럽트)
*          
*           1. 인터럽트 발생
*           2. 인터럽트 처리
* 
* *********************************************/
namespace Threadinterrupt
{
    class InterruptedThread
    {
        private string m_msg;
        public bool m_isUpdate = false;
        public bool m_b = true;
        StreamWriter m_sw = new StreamWriter(new FileStream("thread.txt", FileMode.Create, FileAccess.Write));

        public InterruptedThread()
        {
            m_msg = string.Empty;
        }

        public void DoThread()
        {
            try
            {
                while (true)
                {
                    if (m_isUpdate) //메세지가 입력된 경우
                    {
                        Console.WriteLine("Thread : " + m_msg);
                        if (m_msg != "")
                            m_sw.WriteLine(m_msg);
                        Thread.Sleep(100);
                        m_isUpdate = false;
                        m_b = false; 
                    }

                    if (!m_b) //새로운 메세지가 입력되지 않음
                    {
                        Console.WriteLine("Waiting Input Message...");
                        m_b = true;
                    }
                }
            }
            catch (ThreadInterruptedException e) // --- 1. 쓰레드 인터럽트가 발생한 경우 처리할 부분
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("Thread Finish!!"); //쓰레드 종료 메세지 출력
                m_msg = string.Empty;
                m_sw.Close(); //파일 객체 닫기             
            }
        }

        public string MSG { set { m_msg = value; } }
    }

    class Program
    {
        static void Main(string[] args)
        {
            string message = string.Empty; //메시지 입력 변수
            InterruptedThread interrupt = new InterruptedThread(); //실행할 쓰레드의 클래스 객체 생성
            Thread inter_thread = new Thread(new ThreadStart(interrupt.DoThread)); //쓰레드 생성
            inter_thread.Start(); //쓰레드 시작
            inter_thread.IsBackground = false; //true인 경우 프로세스가 종료하면 쓰레드도 같이 종료

            while(true)
            {
                Console.Write("Input Message : ");
                message = Console.ReadLine();
                Console.WriteLine("Main : {0}", message);
                interrupt.MSG = message; //입력한 메시지를 쓰레드가 있는 클래스의 메시지 변수에 저장
                interrupt.m_isUpdate = true; //새로운 메시지 입력 확인
                Thread.Sleep(100); //0.1초 쉬고 => 쓰레드는 wait상태로 들어간다.

                if (message == "") //엔터키를 누를 경우
                {
                    interrupt.m_isUpdate = true;
                    inter_thread.Interrupt(); // --- 2. 인터럽트 발생 => 쓰레드가 종료된다.
                    inter_thread.Join(); //쓰레드 종료까지 대기
                    break; //루프문 탈출
                }
            }
            Console.WriteLine();

            StreamReader sr = new StreamReader(new FileStream("thread.txt", FileMode.Open, FileAccess.Read));

            Console.WriteLine("=== thread.txt 내용 출력 ===");
            while (sr.EndOfStream == false)
            {
                    Console.WriteLine(sr.ReadLine());
            }
        }
    }
}
