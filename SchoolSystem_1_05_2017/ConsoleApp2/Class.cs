using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    public class Class
    {
        private string name;
        private List<People> peopleList;
        public Class()
        {
            this.name = null;
            this.peopleList = new List<People>();
        }
        public Class(string name)
        {
            this.name = name;
            this.peopleList = new List<People>();
        }
        public Class(string name, List<People> peopleList)
        {
            this.name = name;
            this.peopleList = peopleList;
        }

        public string Name
        {
            set { if (this.name == null) this.name = value; }
            get { return this.name; }
        }
        public List<People> PeopleList
        {
            get { return this.peopleList; }
            set { this.peopleList = value; }
        }
        public void ChangeClass(Class NewClass, People People)
        {
            this.PeopleList.Remove(People);
            NewClass.PeopleList.Add(People);
        }
    }
}
