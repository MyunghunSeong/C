using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/***********************************************
 * 
 *              추상 클래스
 * 
 * *********************************************/
namespace 추상클래스
{
    class Program
    {
        static void Main(string[] args)
        {
            string selectFruit = string.Empty;
            AbstractClass person = new OnePiece("루피"); // 추상메소드는 인스턴스를 만들수 없다. => 추상클래스를 상속받은 클래스로 인스턴스를 생성

            selectFruit = person.SetFruit();

            person.EatFruit(selectFruit);

            person.Attack();            
        }
    }
}
