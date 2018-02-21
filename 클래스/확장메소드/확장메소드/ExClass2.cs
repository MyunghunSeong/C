using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using 확장메소드_ExClass;

namespace 확장메소드_ex
{
    public static class ExClass2 //ExClass의 확장 메서드를 사용하기 위해 ExClass2를 선언
    { 
        public static string ShowName(this ExClass myClass, string name)
        {
            myClass.name = name; 
            return myClass.name; //ExClass의 이름을 반환
        }
    }
}
