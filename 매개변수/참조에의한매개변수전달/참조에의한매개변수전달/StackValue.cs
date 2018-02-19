using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 참조에의한매개변수전달
{
    class StackValue
    {
        public void stacked(int a, int b)
        {
            a += b;
        }

        public void stacked_ref(ref int a, ref int b)
        {
            a += b;
        }
    }
}
