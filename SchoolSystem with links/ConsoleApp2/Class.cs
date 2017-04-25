using System;

namespace ConsoleApp1
{
    public class Class
    {
        private string name;
        private int id;
        private int number;
        private int[] peoplelist;
        private int idschool;
        public Class(int np1)
        {
            name = null;
            id = -1;
            number = 0;
            peoplelist = new int[np1];
            idschool = -1;
        }
        public Class(string name, int idschool, int[] peoplelist, int number)
        {
            this.name = name;
            this.idschool = idschool;
            this.peoplelist = peoplelist;
            this.number = number;
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
        public int Number
        {
            get { return this.number; }
            set { this.number = value; }
        }
        public int Idschool
        {
            get { return this.idschool; }
            set { this.idschool = value; }
        }
        public int this[int i]
        {
            get { return peoplelist[i]; }
            set { peoplelist[i] = value; }
        }
        public int[] Peoplelist
        {
            get { return this.peoplelist; }
            set { this.peoplelist = value; }
        }
        public int Length
        {
            get { return peoplelist.Length; }
        }
    }
}
