using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

/***********************************************
 * 
 *              추상 클래스
 *              
 *          1. 추상클래스의 선언
 *          2. 추상클래스의 특징
 *          3. 추상클래스의 사용
 * 
 * *********************************************/
namespace 추상클래스
{
    abstract class AbstractClass  // --- 1. 추상클래스는 abstract 키워드를 붙여서 class를 선언한다.
    {
        public abstract void EatFruit(string fruit); // --- 2. 추상클래스는 추상메소드(구현은 없고 정의만 있음)는 가질수 있고 abstract키워드를 붙인다.
                                                     //        추상메소드는 상속받은 클래스에서 무조건적으로 구현해야한다.

        public abstract string SetFruit();

        public virtual void Attack()     // --- 2. 추상클래스는 인터페이스와 다르게 구현을 할 수 있다.(추상메소드는 아님)
        {
            Console.WriteLine("공격!!");
        }
    }

    class OnePiece : AbstractClass  // --- 3. 하위 클래스가 추상메소드를 상속받음
    {
        private string name;
        private string fruit;
        List<string> fruit_list;

        public OnePiece(string name)
        {
            this.name = string.Empty;
            fruit = string.Empty;
            fruit_list = new List<string>();

            Console.WriteLine(name + "이(가) 해적이 되었습니다.");
            Console.WriteLine();

            this.name = name;
        }

        public override void Attack()  // --- 3. 상속받은 클래스에서는 
        {
            Console.WriteLine(name + " - " + fruit + "공격!!");
            Console.WriteLine();
        }

        public override void EatFruit(string fruit)  // --- 3. 상속받은 클래스에서는 override 키워드를 사용하여 추상메소드를 구현
        {
            Console.WriteLine(name + "이(가) " + fruit + "열매를 먹었습니다.");
            Console.WriteLine(name + "이(가) " + fruit + "열매 능력자가 되었습니다.");
            Console.WriteLine();

            this.fruit = fruit;
        }

        public override string SetFruit()
        {
            Random r = new Random();

            int maxidx = 0;
            string fruit = string.Empty;

            StreamReader sr = new StreamReader(@"C:/Users/gns91/Documents/Visual Studio 2010/Projects/인터페이스의사용/bin/Debug/fruitlist.txt");

            while ((fruit = sr.ReadLine()) != null)
            {
                fruit_list.Add(fruit);
            }           

            maxidx = r.Next(0, fruit_list.Count);

            return fruit_list[maxidx];
        }
    }
}
