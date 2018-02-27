using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

/***********************************************
* 
*             File(Stream, Binary)
*          
*           1. StremaWriter, Reader
*           2. BinaryWriter, Reader
* 
* *********************************************/
namespace FileFunction.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;

            Console.WriteLine("=== Stream ===");
            StreamWriter sw = new StreamWriter(new FileStream("./Stream/a.dat", FileMode.Create)); //StreamWriter객체를 생성해서 a.dat파일을 생성

            sw.WriteLine("안녕"); //파일에 내용을 씀
            sw.WriteLine("hello");

            sw.Close(); //객체 해제

            StreamReader sr = new StreamReader(new FileStream("./Stream/a.dat", FileMode.Open)); //StreamReader객체 생성 후 a.dat파일 오픈

            while (sr.EndOfStream == false) //file이 EOF가 아닐 동안
            {
                count++;
                Console.WriteLine("{0} : {1}",count, sr.ReadLine()); //파일의 내용을 출력
            }

            sr.Close(); //객체 해제
            Console.WriteLine();

            Console.WriteLine("=== Binary ==="); 
            BinaryWriter bw = new BinaryWriter(new FileStream("./Binary/a.dat", FileMode.Create)); //BinaryWriter객체 생성 후 a.dat파일 생성

            bw.Write("hello"); 
            bw.Write("hi");

            bw.Close();

            BinaryReader br = new BinaryReader(new FileStream("./Binary/a.dat", FileMode.Open));

            Console.WriteLine("byte size = {0}", br.BaseStream.Length); //파일에 있는 바이트 수를 출력
            Console.WriteLine("{0}", br.ReadString()); //파일의 있는 내용 출력
            Console.WriteLine("{0}", br.ReadString());

            br.Close();
        }
    }
}
