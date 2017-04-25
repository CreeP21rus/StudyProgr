using System;

namespace ConsoleApp1
{
    public class School
    {
        private string name;
        private Canteen canteen;
        private Class[] clasList;
        public School()
        {
            name = null;
            clasList = new Class[0];
        }
        public School(string name, ref Canteen canteen, Class[] clasList)
        {
            this.name = name;
            this.canteen = canteen;
            this.clasList = clasList;
        }
        public string Name
        {
            get { return this.name; }
        }
        public Canteen Canteen
        {
            get { return this.canteen; }
            set
            {
                this.canteen = value;
            }
        }
        public Class[] ClasList
        {
            get { return this.clasList; }
        }
        public int Length
        {
            get { return clasList.Length; }
        }
        public Class this[int i]
        {
            get { return clasList[i]; }
            set
            {
                clasList[i] = value;
            }
        }
        public void ChangeLength(int length)
        {
            Array.Resize(ref clasList, length);
        }

        public void ChangeCanteen(ref Canteen canteen)
        {
            this.canteen = canteen;
        }
    }
}
