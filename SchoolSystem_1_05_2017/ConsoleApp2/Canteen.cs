using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    public class Canteen
    {
        private string name;
        private List<string> menu;
        public Canteen()
        {
            this.name = null;
            this.menu = new List<string>() ;
        }
        public Canteen(string name)
        {
            this.name = name;
            this.menu = new List<string>();
        }
        public Canteen(string name, List<string> menu)
        {
            this.name = name;
            this.menu = menu;
        }
        public string Name
        {
            set { if (this.name == null) this.name = value; }
            get { return this.name; }
        }
        public List<string> Menu
        {
            get { return this.menu; }
            set { this.menu = value; }
        }
        public void Service(Human human, List<string> Order)
        {
            string s = "Младой человек вы что не видите, у нас обед!";
        }
    }
}
