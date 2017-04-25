using System;

namespace ConsoleApp1
{
    public class Canteen
    {
        private string name;
        private int id;
        private int idschool;
        private string[] menu;
        public Canteen()
        {
            name = null;
            id = -1;
            idschool = -1;
            menu = null;
        }
        public Canteen(string name, int idschool)
        {
            this.name = name;
            this.idschool = idschool;
        }
        public Canteen(string name, int idschool, string[] menu)
        {
            this.name = name;
            this.idschool = idschool;
            this.menu = menu;
        }
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }
        public int Id
        {
            get { return this.id; }
            set { this.id = value; }
        }
        public int Idschool
        {
            get { return this.idschool; }
            set { this.idschool = value; }
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
