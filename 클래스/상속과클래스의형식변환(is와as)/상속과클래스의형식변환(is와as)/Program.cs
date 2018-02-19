using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/***********************************************
 * 
 *      상속과오버라이딩그리고is와as
 *        
 *       1. 상속의 예시(Parents클래스 참조)
 *       2. 오버라이딩의 구현(Parents클래스 참조)
 *       2. is와  as
 * 
 * *********************************************/
namespace 상속과클래스
{
    class Program
    {
        static void Main(string[] args)
        {
            Pirate luffy = new Competent("루피");
            luffy.EatFruit("고무고무");
            luffy.RideShip(); //부모 클래스 형식의 luffy객체는 부모클래스의 RideShip()이 출력
            luffy.LearnAmbition("패왕", "견문", "무장");
            luffy.UseAmbition();
            luffy.Attack();

            Console.WriteLine();

            Competent ace = new Competent("에이스"); //Competent클래스 형식으로 생성
            ace.EatFruit("이글이글");
            ace.RideShip(); //Competent 형식의 에이스는 new 키워드를 사용해 새로 정의한 RideShip()이 호출
            ace.LearnAmbition("패왕", "견문", "무장");
            ace.UseAmbition();
            ace.Attack();

            Competent aokizi;

            if (ace is Competent) //ace객체가 Competent형식이면 true, 아니면 false를 반환
                                  //형변환 실패 : 예외를 발생시킴
            {
                aokizi = (Competent)luffy;
                aokizi.SetName = "아오키지";
                aokizi.RideShip();
                aokizi.EatFruit("얼음얼음");
                aokizi.UseAmbition();
                aokizi.Attack();
            }

            Competent akainu = ace as Competent; //ace객체를 Competent객체 형식으로 변환해서 Competent형식의 akainu객체에 대입
                                                 //성공하면 객체를 반환, 아니면 null값을 반환
                                                 //형변환 실패 : 객체 참조를 null로 만듬

            if (akainu != null)
            {
                akainu.SetName = "아카이누";
                akainu.EatFruit("마그마그");
                akainu.RideShip();
                akainu.LearnAmbition("견문");
                akainu.UseAmbition();
                akainu.Attack();
            }
            
        }
    }
}
