using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 인터페이스의사용
{
    interface ILog //인터페이스 선언
    {
        int m_a = 0;
        void DoLog(string msg); //메소드 정의
    }
}
