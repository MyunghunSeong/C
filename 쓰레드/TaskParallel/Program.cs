using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/***********************************************
* 
*               TaskParallel
*          
*           1. Parallel.For()
* 
* *********************************************/
namespace TaskParallel
{
    class Program
    {
        static bool IsPrime(long number) //소수인지 판별하는 함수
        {
            if (number < 2)
                return false;

            if (number % 2 == 0 && number != 2)
                return false;

            for (long i = 2; i < number; i++)
            {
                if (number % i == 0)
                    return false;
            }

            return true;
        }

        static void Main(string[] args)
        {
            long from = Convert.ToInt64(args[0]); //시작 숫자
            long to = Convert.ToInt64(args[1]); //종료 숫자

            List<long> total = new List<long>();

            Console.WriteLine("Please Press Enter to Start...");
            Console.ReadLine();
            Console.WriteLine("Started...");

            DateTime startTime = DateTime.Now; //시작 시간

            Parallel.For(from, to, (long i) => //쓰레드를 병렬로 실행하기 쉽게 Parallel 메소드를 이용
                                               //from부터 to까지 랜덤한 정수가 i로 들어감
                                               //쓰레드의 개수는 함수가 최적화해서 자동으로 판단
                {
                    if (IsPrime(i)) //해당 정수가 소수이면
                        total.Add(i); //리스트에 저장
                });

            DateTime endTime = DateTime.Now; //끝 시간

            TimeSpan LapTime = endTime - startTime; //쓰레드 실행 시간 측정

            Console.WriteLine("Prime Number Count between {0} and {1} : {2}", from, to, total.Count);
            Console.WriteLine("LapTime = {0}", LapTime);
        }
    }
}
