using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


/**********************************************************
 * 
 *               참조에의한매개변수전달
 *          1. 값에의한 매개변수 전달
 *          2. 참조에의한 매개변수 전달 
 * 
 * ********************************************************/
namespace 참조에의한매개변수전달
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 값에의한 매개변수 전달 */
            StackValue sv = new StackValue(); //값을 축적시키는 클래스

            int a = 0, b = 0;

            Console.WriteLine("=== 값에 의한 매개변수 ===");
            while (b < 10) //값을 10번 축적
            {
                sv.stacked(a, b); //메소드 호출(a += b의 식으로 값이 축적)
                b++; 
                Console.WriteLine("stacked value : " + a); //축적된 값 출력
            }
            Console.WriteLine();

            /*
             * 함수(메소드)에 매개변수를 전달할 때 값 그대로를 전달 => 함수 내에서 값 변경 => 함수 종료시점에서 값이 사라짐.
             */


            /* 참조에의한 매개변수 전달 */
            int ref_a = 0, ref_b = 0;

            Console.WriteLine("=== 참조에 의한 매개변수 ===");
            while (ref_b < 10)
            {
                sv.stacked_ref(ref ref_a, ref ref_b); //참조에의한 매개변수 전달(값의 주소 전달)
                ref_b++;
                Console.WriteLine("stacked_ref value : " + ref_a);
            }
            Console.WriteLine();

            /*
             * 함수(메소드)에 매개변수를 전달할 때 값의 주소(참조)를 보내고 ref 키워드를 붙여서 전달
             * => 함수 내에서 전달된 주소를 참조하여 원본 값을 변경 
             * => 종료 시점에서 값이 사라지지 않음(값이 가지고 있는 주소를 참조했기 때문에)
             */
            
        }
    }
}
