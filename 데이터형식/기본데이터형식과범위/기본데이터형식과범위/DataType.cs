using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 기본데이터형식과범위
{
    class DataType
    {
        private int select = 0;

        public DataType()
        {

            UI();
        }

        public void UI()
        {
            while (true)
            {
                Console.WriteLine("\t\t\t  " + "================================================");
                Console.WriteLine("\t\t\t  " + "================================================");
                Console.WriteLine("\t\t\t  " + "==         1. 데이터 형식 목록 보기           ==");
                Console.WriteLine("\t\t\t  " + "==         2. 데이터 범위 보기                ==");
                Console.WriteLine("\t\t\t  " + "==         0. 종료                            ==");
                Console.WriteLine("\t\t\t  " + "================================================");
                Console.WriteLine("\t\t\t  " + "================================================");
                Console.WriteLine();
                Console.WriteLine();

                Console.Write("숫자를 입력하세요 : ");
                string str_sel = Console.ReadLine();
                select = Convert.ToInt32(str_sel);

                SwitchFunc(select);

                if (select == 0)
                {
                    Console.WriteLine("종료합니다.");
                    break;
                }
            }
        }

        public void SeeDataType()
        {
            Console.WriteLine("1. 기본 데이터 타입 목록");
            Console.WriteLine("=========================");
            Console.WriteLine();

            Console.WriteLine(" 바이트형 ");
            Console.WriteLine("byte = 데이터의 기본형으로 1byte의 메모리 공간이 생성");
            Console.WriteLine("sbyte = 부호있는 byte형 ");
            Console.WriteLine();

            Console.WriteLine(" 정수형 ");
            Console.WriteLine("short = 2byte의 메모리 공간이 생성");
            Console.WriteLine("ushort = 부호있는 short형 ");
            Console.WriteLine("int = 4byte의 메모리 공간이 생성");
            Console.WriteLine("uint = 부호있는 int형 ");
            Console.WriteLine("long = 8byte의 메모리 공간이 생성");
            Console.WriteLine("ulong = 부호있는 long형 ");
            Console.WriteLine();

            Console.WriteLine(" 실수형 ");
            Console.WriteLine("float = 4byte의 메모리 공간이 생성");
            Console.WriteLine("double = 8byte의 메모리 공간이 생성 ");
            Console.WriteLine("decimal = 16byte의 메모리 공간이 생성");
            Console.WriteLine();

            Console.WriteLine(" 문자형 ");
            Console.WriteLine("char = 1byte의 메모리 공간이 생성");
            Console.WriteLine("string = 참조형으로 문자열의 갯수만큼 힘영역에 메모리 공간 생성");
            Console.WriteLine();

            Console.WriteLine(" 오브젝트형 ");
            Console.WriteLine("object = 모든 데이터 형식을 포함할 수 있음 string과 같은 참조형");
            Console.WriteLine();

            Console.WriteLine(" 부울형 ");
            Console.WriteLine("bool / Boolean = 참 또는 거짓을 판별하기 위한 데이터 형식으로 1byte의 메모리 공간 생성");
            Console.WriteLine();
        }

        public void SeeDataRange()
        {
            Console.WriteLine("2. 데이터 범위 목록");
            Console.WriteLine("=========================");
            Console.WriteLine();

            Console.WriteLine("====== byte형 ======");
            Console.WriteLine("byte형 범위 : " + byte.MinValue + " ~ " + byte.MaxValue);
            Console.WriteLine("sbyte형 범위 : " + sbyte.MinValue + " ~ " + byte.MaxValue);
            Console.WriteLine();

            Console.WriteLine("====== 정수형 ======");
            Console.WriteLine("short형 범위 : " + short.MinValue + " ~ " + short.MaxValue);
            Console.WriteLine("ushort형 범위 : " + ushort.MinValue + " ~ " + ushort.MaxValue);
            Console.WriteLine("int형 범위 : " + int.MinValue + " ~ " + int.MaxValue);
            Console.WriteLine("uint형 범위 : " + uint.MinValue + " ~ " + uint.MaxValue);
            Console.WriteLine("long형 범위 : " + long.MinValue + " ~ " + long.MaxValue);
            Console.WriteLine("ulong형 범위 : " + ulong.MinValue + " ~ " + ulong.MaxValue);
            Console.WriteLine();

            Console.WriteLine("====== 실수형 ======");
            Console.WriteLine("float형 범위 : " + float.MinValue + " ~ " + float.MaxValue);
            Console.WriteLine("double형 범위 : " + double.MinValue + " ~ " + double.MaxValue);
            Console.WriteLine("int형 범위 : " + decimal.MinValue + " ~ " + decimal.MaxValue);
            Console.WriteLine();

            Console.WriteLine("====== 부울형 ======");
            Console.WriteLine("float형 범위 : " + float.MinValue + " ~ " + float.MaxValue);
        }

        public void SwitchFunc(int select)
        {
            switch (select)
            {
                case 0:
                    break;
                case 1:
                    Console.Clear();
                    SeeDataType();
                    break;
                case 2:
                    Console.Clear();
                    SeeDataRange();
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("해당하는 번호가 없습니다. 다시 입력해주세요");
                    break;
            }
        }
    }
}
