using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/***********************************************
* 
*               Task<TResult>
*          
*         1. 쓰레드의 실행결과 취합
* 
* *********************************************/
namespace Task_Result
{
    class Program
    {
        static bool IsPrime(Int64 number) //소수판별 함수
        {
            if (number < 2)
                return false;

            if (number % 2 == 0 && number != 2)
                return false;

            for (Int64 i = 2; i < number; i++)
            {
                if (number % i == 0)
                    return false;
            }

            return true;
        }

        static void TokenRange(ref string from, ref string to, int idx, string range)
        {
            for (int i = 0; i < idx; i++)
            {
                from += range[i];
            }

            for (int i = idx + 1; i < range.Length; i++)
            {
                to += range[i];
            }
        }

        static void Main(string[] args)
        {
            /*Int64 from = Convert.ToInt64(args[0]); //범위 시작 숫자
            Int64 to = Convert.ToInt64(args[1]); //범위 끝 숫자
            int length = Convert.ToInt32(args[2]); //쓰레드 갯수*/

            Int64 from = 0;
            Int64 to = 0;
            Int32 length = 0;

            string str_from = string.Empty;
            string str_to = string.Empty;

            Console.Write("숫자 범위를 입력하세요(ex 0 ~ 1000) : ");
            string rangeNum = Console.ReadLine();
            Console.Write("실행할 스레드의 갯수를 입력하세요 : ");
            string len = Console.ReadLine();
            length = Convert.ToInt32(len);

            int idx = rangeNum.IndexOf('~', 0, rangeNum.Length);

            TokenRange(ref str_from, ref str_to, idx, rangeNum);

            from = Convert.ToInt64(str_from);

            to = Convert.ToInt64(str_to);          

            Func<object, List<Int64>> FindPrimeNum = (ObjRange) => //Func무명함수 선언
                {
                    Int64[] range = (Int64[])ObjRange;
                    List<Int64> find = new List<Int64>();

                    for (Int64 i = range[0]; i < range[1]; i++) //from부터to까지 
                    {
                        if (IsPrime(i)) //소수이면
                            find.Add(i); //리스트에 저장
                    }

                    return find; //리스트 반환
                };

            Task<List<Int64>>[] tasks = new Task<List<Int64>>[length]; //Task형식의 long형식의 List배열 선언(지정한 쓰레드의 갯수만큼)
            Int64 currentFrom = from;
            Int64 currentTo = to / tasks.Length;

            for (int i = 0; i < tasks.Length; i++)
            {
                Console.WriteLine("Task[{0}] : {1} ~ {2}", i, currentFrom, currentTo);

                tasks[i] = new Task<List<Int64>>(FindPrimeNum, new Int64[] {currentFrom, currentTo});

                currentFrom = currentTo + 1;

                if (i == tasks.Length - 2)
                    currentTo = to;
                else
                    currentTo = currentTo + (to / tasks.Length);
            }

            Console.WriteLine("Press Enter to Start...");
            Console.ReadLine();
            Console.WriteLine("Started...");

            foreach (Task<List<Int64>> task in tasks)
                task.Start(); //쓰레드의 갯수만큼 반복하면서 쓰레드 시작

            DateTime starTime = DateTime.Now; //쓰레드 시작 시간

            List<Int64> total = new List<Int64>();

            foreach (Task<List<Int64>> task in tasks)
            {
                task.Wait();
                total.AddRange(task.Result.ToArray()); //결과 취합
            }

            DateTime endTime = DateTime.Now; //쓰레드 종료 시간

            TimeSpan lapTime = endTime - starTime; //쓰레드 실행 시간

            Console.WriteLine("Prime Number Count between {0} and {1} : {2}", from, to, total.Count);
            Console.WriteLine("LapTime = {0}", lapTime);
        }
    }
}
