using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/***********************************************
 * 
 *              얇은복사와깊은복사
 *                  1. 얇은 복사
 *                  2. 깊은 복사
 * 
 * *********************************************/
namespace 얇은복사와깊은복사
{
    class CopyClass : ICloneable
    {
        public int value1;
        public int value2;

        public CopyClass()
        {
            value1 = 10;
            value2 = 20;
        }

        public object Clone()
        {
            CopyClass newCopy = new CopyClass();
            newCopy.value1 = this.value1;
            newCopy.value2 = this.value2;

            return newCopy;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            /* 1. 얇은 복사 */
            Console.WriteLine("====================== 얇은 복사 ======================");
            Console.WriteLine();
            Console.WriteLine();

            CopyClass shallow = new CopyClass(); //source객체 생성
            CopyClass shallow_copy = new CopyClass(); //target객체 생성
            shallow_copy = shallow; //객체 복사

            Console.WriteLine("=== 값 변경 전 ===");
            Console.WriteLine("shallow.value1 = " + shallow.value1 + ", " + "shallow.value2 = " + shallow.value2);
            Console.WriteLine("shallow_copy.value1 = " + shallow_copy.value1 + ", " + "shallow_copy.value2 = " + shallow_copy.value2);
            Console.WriteLine();

            shallow_copy.value1 = 20; //복사본(target의 객체의 value1값을 변경(10 -> 20)

            Console.WriteLine("=== 값 변경 후 ===");
            Console.WriteLine("shallow.value1 = " + shallow.value1 + ", " + "shallow.value2 = " + shallow.value2);
            Console.WriteLine("shallow_copy.value1 = " + shallow_copy.value1 + ", " + "shallow_copy.value2 = " + shallow_copy.value2);
            Console.WriteLine(); //원본(source)객체의 값도 같이 변경
            Console.WriteLine();

            /* 2. 깊은 복사 */
            Console.WriteLine("====================== 깊은 복사 ======================");
            Console.WriteLine();
            Console.WriteLine();

            CopyClass deep = new CopyClass();
            CopyClass deep_copy = new CopyClass();
            deep_copy = (CopyClass)deep.Clone();

            Console.WriteLine("=== 값 변경 전 ===");
            Console.WriteLine("shallow.value1 = " + deep.value1 + ", " + "shallow.value2 = " + deep.value2);
            Console.WriteLine("shallow_copy.value1 = " + deep_copy.value1 + ", " + "shallow_copy.value2 = " + deep_copy.value2);
            Console.WriteLine();

            deep_copy.value1 = 30; //복사본(target의 객체의 value1값을 변경(10 -> 30)

            Console.WriteLine("=== 값 변경 후 ===");
            Console.WriteLine("shallow.value1 = " + deep.value1 + ", " + "shallow.value2 = " + deep.value2);
            Console.WriteLine("shallow_copy.value1 = " + deep_copy.value1 + ", " + "shallow_copy.value2 = " + deep_copy.value2);
            Console.WriteLine(); //원본(source)객체의 값은 영향을 주지 않는다.
            Console.WriteLine();
        }
    }
}
