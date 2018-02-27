using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

/***********************************************
* 
*                   직렬화
*          
*              1. 직렬화 선언
*              2. 직렬화 & 역직렬화
* 
* *********************************************/
namespace Serializer.cs
{
    [Serializable] // --- 1. 직렬화를 할 부분에 [Serializable]의 에트리뷰트 형태로 선언한다.(Serializer class형식을 직렬화)
    class Serializer
    {
        public char[] alphabat;
        public int[] number;
        [NonSerialized] // --- 1. List<string>배열에 대해서는 직렬화를 하지않음
        public List<string> list;

        public Serializer(int count)
        {
            list = new List<string>();
            alphabat = new char[count];
            number = new int[10];
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Stream sw = new FileStream("serializer.txt", FileMode.Create); //serializer.txt파일을 생성
            BinaryFormatter serializer = new BinaryFormatter(); //직렬화를 하기위해 BinaryFormatter형식 객체 선언
            int count = 0;

            for (int i = 'a'; i < 'z'; i++)
            {
                count++; //알파벳 갯수
            }

            Serializer serial = new Serializer(count+1); //클래스 객체 생성

            for (int i = 0; i < count + 1; i++)
            {
                int alpha = 'a';
                serial.alphabat[i] = Convert.ToChar(alpha + i);
            }

            for (int i = 0; i < 10; i++)
            {
                serial.number[i] = i+1;
            }

            serializer.Serialize(sw, serial); //직렬화(serialize)진행
            sw.Close(); //스트림 객체 닫기

            Stream sr = new FileStream("serializer.txt", FileMode.Open); //역직렬화를 위해 파일을 염
            BinaryFormatter deserializer = new BinaryFormatter();

            Serializer serial2;
            serial2 = (Serializer)deserializer.Deserialize(sr); //파일에 쓴 내용을 Serial객체에 저장
            sr.Close();

            Console.WriteLine("=== 알파벳 순서 ===");
            for (int i = 0; i < serial2.alphabat.Length - 1; i++)
            {
                Console.Write("{0}, ", Convert.ToString(serial2.alphabat[i]));
            }
            Console.Write("{0}", Convert.ToString(serial2.alphabat[serial2.alphabat.Length - 1]));
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("=== 1~10까지의 수 ===");
            for (int i = 0; i < serial2.number.Length; i++)
            {
                Console.Write("{0}, ", serial2.number[i]);
            }
        }
    }
}
