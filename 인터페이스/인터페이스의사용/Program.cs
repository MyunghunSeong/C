using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/***********************************************
 * 
 *              인터페이스의 사용
 *              
 *                 1. 콘솔 
 *                 2. 파일
 * 
 * *********************************************/
namespace 인터페이스의사용
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLogClass console = new WriteLogClass(new ConsoleLog()); //콘솔에 로그를 남기는 객체

            //console.WriteLog();

            WriteLogClass file = new WriteLogClass(new FIleLog("logfile.txt")); //파일에 로그를 남기는 객체

            file.WriteLog(); //로그 작성(WriteLogClass의 WriteLog에서 메시지를 입력하고 console or file객체에 따라서 file or console에 로그를 남김)
        }
    }
}
