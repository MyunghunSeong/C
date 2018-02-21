using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 확장메소드_ExClass
{
    public class ExClass //ExClass 선언
    {       
        public string name = string.Empty;

        public void ShowMessage(string msg) //ExClass가 가지고 있는 디폴트 메서드
        {
            Console.WriteLine(msg);
        }
    }
}

