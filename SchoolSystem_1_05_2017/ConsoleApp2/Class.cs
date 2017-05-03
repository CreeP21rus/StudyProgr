using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    public class Class
    {
        private string name;
        private List<Human> ListOfHuman;
        public Class()
        {
            this.name = null;
            this.ListOfHuman = new List<Human>();
        }
        public Class(string name)
        {
            this.name = name;
            this.ListOfHuman = new List<Human>();
        }
        public Class(string name, List<Human> ListOfHuman)
        {
            this.name = name;
            this.ListOfHuman = ListOfHuman;
        }

        public string Name
        {
            set { if (this.name == null) this.name = value; }
            get { return this.name; }
        }
        public List<Human> ListofHuman
        {
            get { return this.ListOfHuman; }
            set { this.ListOfHuman = value; }
        }
    }
}
