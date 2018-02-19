using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 상속과클래스
{
    class Pirate //부모 클래스(해적)
    {
        protected string name; //맴버 변수
        protected string fruit;

        public Pirate(string name) //생성자(부모)
        {
            Console.WriteLine(name + "이(가) 해적이 되었습니다.");
            this.name = name;
        }

        public virtual void EatFruit(string fruit) //virtual -> 상속받는 클래스(자식)에서 재정의(override)하도록 명시해놓은 것
        {
            Console.WriteLine(fruit + "열매를 발견하지 못했습니다.");
            this.fruit = fruit;
        }

        public virtual void LearnAmbition(params string[] ambitions)
        {
            foreach(string ability in ambitions)
            {
                Console.Write(ability);
                Console.WriteLine(" 패기를 배울 수 없습니다.");
            }
        }

        public virtual void UseAmbition()
        {
                Console.WriteLine(" 패기를 사용할 수 없습니다.");
        }

        public virtual void Attack()
        {
            Console.WriteLine(name + "이(가) 공격합니다!!");
        }

        public void RideShip()
        {
            Console.WriteLine("배틀 탑니다.(해적용)");
        }
    }

    class Competent : Pirate //자식 클래스(능력자)
    {
        private List<string> ambition_list;

        public Competent(string name) : base(name) //부모 생성자를 상속받는다.(base는 부모 클래스를 의미)
        {            
            Console.WriteLine(name + "이(가) 능력자가 되었습니다.");
            this.name = name;
            fruit = string.Empty;
            ambition_list = new List<string>();
        }

        public new void RideShip() //부모 클래스의 RideShip메소드를 숨김(자식 클래스만의 메소드를 정의)
        {
            Console.WriteLine("배를 탑니다.(능력자)");
            Console.WriteLine();
        }

        public override void EatFruit(string fruit)  // 부모 클래스의 EatFruit메소드 재정의(오버라이딩) 
                                                     // 오버라이딩의 조건 1. 부모클래스 : virtual이나 abstract 키워드로 선언되어야 한다.
                                                     //                   2. 자식클래스 : override의 키워드를 사용해서 부모클래스의 메소드를 재정의(오버라이딩)한다.  
        {
            Console.WriteLine(fruit + " 열매섭취!!");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine(name + "이(가) " + fruit + " 열매 능력자가 되었습니다!!");
            Console.WriteLine();

            this.fruit = fruit;
        }

        public override void LearnAmbition(params string[] ambitions)
        {
            for (int i = 0; i < ambitions.Length; i++)
            {
                ambition_list.Add(ambitions[i]);
            }
        }

        public override void UseAmbition()
        {
            foreach(string ability in ambition_list)
            {
                Console.Write(ability + " ");
                Console.WriteLine("패기를 사용했습니다.");
            }
        }

        public override void Attack()
        {
            Console.WriteLine(name + fruit + "공격개시!!");
            Console.WriteLine();
        }

        public string SetName { set { this.name = value; } }
    }
}
