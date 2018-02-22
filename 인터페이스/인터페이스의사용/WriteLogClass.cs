using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 인터페이스의사용
{
    class WriteLogClass
    {
        private ILog log; //인터페이스의 인스턴스 생성

        public WriteLogClass(ILog log)
        {
            this.log = log;
        }

        public void WriteLog()
        {
            while (true)
            {
                Console.Write("남길 로그 메세지를 입력하세요 : ");

                string msg = Console.ReadLine();  //로그 메세지 입력 받은 메소드

                if (msg == string.Empty)
                    break;

                log.DoLog(msg);
                log.m_a = 2;
            }
        }
    }
}
