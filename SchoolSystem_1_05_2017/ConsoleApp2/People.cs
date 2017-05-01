using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    public class People
    {
        private string name;
        public People()
        {
            this.name = null;
        }
        public People(string name)
        {
            this.name = name;
        }
        public string Name
        {
            set { if (this.name == null) this.name = value; }
            get { return this.name; }
        }
    }
}
