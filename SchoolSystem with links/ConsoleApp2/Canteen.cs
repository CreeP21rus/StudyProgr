using System;

namespace ConsoleApp1
{
    public class Canteen
    {
        private string name;
        private School school;
        private string[] menu;
        public Canteen()
        {
            name = null;
            menu = null;
        }
        public Canteen(string name,ref School school)
        {
            this.name = name;
            this.school = school;
        }
        public Canteen(string name,ref School school, string[] menu)
        {
            this.name = name;
            this.school = school;
            this.menu = menu;
        }
        public string Name
        {
            get { return this.name; }
        }
        public School School
        {
            get { return this.school; }
            set
            {
                this.school = value;
            }
        }
        public string[] Menu
        {
            get { return this.menu; }
            set { this.menu = value; }
        }
        public int Length
        {
            get { return menu.Length; }
        }
        public string this[int i]
        {
            get { return menu[i]; }
            set { menu[i] = value; }
        }
    }
}
