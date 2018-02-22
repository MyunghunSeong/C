using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace 인터페이스의사용
{
    class FIleLog : ILog
    {
        private StreamWriter sw;

        public FIleLog(string path)
        {
            sw = File.CreateText(path);
            sw.AutoFlush = true;
        }

        public void DoLog(string msg)
        {
            sw.WriteLine(msg);
        }
    }
}
