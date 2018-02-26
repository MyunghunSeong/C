using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Attribute_Example.cs
{
    [System.AttributeUsage(System.AttributeTargets.Class, AllowMultiple = true)]
    class Information :System.Attribute
    {
        private string program;
        private string author;
        private double version;
        private DateTime date;

        public Information(string program)
        {
            this.program = program;
            author = string.Empty;
            version = 0;
            date = DateTime.Now;
        }

        public string Program 
        {
            get { return program;}
            set { program = value;} 
        }

        public string Author
        {
            get { return author; }
            set { author = value; }
        }

        public double Version
        {
            get { return version; }
            set { version = value; }
        }          
    }
}
