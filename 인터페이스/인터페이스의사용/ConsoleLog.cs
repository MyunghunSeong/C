using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 인터페이스의사용
{
    class ConsoleLog : ILog //인터페이스를 상속받은 클래스
    {
        public void DoLog(string msg) //인터페이스에서 선언한 메소드 구현(무조건 구현이 되어야 한다.)
        {
            Console.WriteLine("{0}, {1}", DateTime.Now, msg);
        }
    }
}
