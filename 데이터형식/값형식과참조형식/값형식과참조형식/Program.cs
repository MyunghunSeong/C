using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


/************************************************
 * 
 *           ValueType & ReferenceType 
 *  1. ValueType
 *  2. ReferenceType
 *  3. 차이점
 * 
 * **********************************************/
namespace 값형식과참조형식
{
    class Reference
    {
        public int val1 = 10;
        public int val2 = 20;
    }
    class Program
    {
        public static void Main(String[] args)
        {
            /*** 1. ValueType ***/
            //값 형식은 값 그대로 메모리에 저장하는 형식으로 스택 메모리에 저장됨
            int original = 20;

            /*** 2. ReferenceType ***/
            Reference refer = new Reference();
            refer.val1 = 10;
            refer.val2 = 20;
            //참조 형식은 값이 저장되어있는 주소값을 참조하는 형식으로 주소 값은 스택 메모리에 값은 힙 메모리에 저장됨


            /*** 3. 차이점 ***/
            Console.WriteLine("=== original의 값 ===");
            Console.WriteLine("original = " + original);
            Console.WriteLine();

            int copy = original; //b의 값을 a에 복사
            Console.WriteLine("=== 복사 후 ===");
            Console.WriteLine("copy = " + copy + ", " + "original = " + original);
            Console.WriteLine();

            copy = 15; //copy의 값을 변경
            Console.WriteLine("=== a의 값 변경 후 ===");
            Console.WriteLine("copy = " + copy + ", " + "original = " + original);
            Console.WriteLine();            //복사 후에 복사본(copy) 값을 변경해도 원본(original)값은 변경되지 않는다.

            Console.WriteLine("=== refer객체의 val값 ===");
            Console.WriteLine("refer.val = " + refer.val1 + ", " + "refer.val2 = " + refer.val2); //객체 refer가 가지고있는 멤버변수 출력
            Console.WriteLine();

            Reference refer_copy = refer; //refer객체를 refer2에 복사

            Console.WriteLine("=== 복사 후 ===");
            Console.WriteLine("refer.val = " + refer.val1 + ", " + "refer.val2 = " + refer.val2);
            Console.WriteLine("refer_copy.val = " + refer_copy.val1 + ", " + "refer_copy.val2 = " + refer_copy.val2); //refer의 멤버변수 값과 동일한 값을 가짐
            Console.WriteLine();

            refer_copy.val2 = 30; //val2값 변경(20 -> 30)

            Console.WriteLine("=== refer2.val값 변경 후 ===");
            Console.WriteLine("refer.val = " + refer.val1 + ", " + "refer.val2 = " + refer.val2);
            Console.WriteLine("refer_copy.val = " + refer_copy.val1 + ", " + "refer_copy.val2 = " + refer_copy.val2);
            Console.WriteLine();             //복사 후에 복사본(refer_copy)값을 변경했을 때 원본(refer)의 값도 같이 변하게 된다.

            /* 
             * => 참조형은 주소 값을 참조해 데이터를 얻기 때문
             * => refer_copy는 refer와 같은 주소를 참조하게 됨(복사 했기 때문에)
             * => 결론적으로 refer_copy의 값을 변경하게 되면 refer의 값도 변경된다.
             */


        }
    }
}
