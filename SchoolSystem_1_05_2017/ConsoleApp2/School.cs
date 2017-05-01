using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    public class School
    {
        private string name;
        private Canteen canteen;
        private List<Class> clasList;
        public School()
        {
            this.name = null;
            this.canteen = null;
            this.clasList = new List<Class>();
        }
        public School(string name)
        {
            this.name = name;
            this.clasList = new List<Class>();
        }
        public School(string name, Canteen canteen, List<Class> clasList)
        {
            this.name = name;
            this.canteen = canteen;
            this.clasList = clasList;
        }
        public string Name
        {
            set { if (this.name == null) this.name = value; }
            get { return this.name; }
        }
        public Canteen Canteen
        {
            set { if (this.canteen == null) this.canteen = value; }
            get { return this.canteen; }
        }
        public List<Class> ClasList
        {
            set { if (this.clasList == null) this.clasList = value; }
            get { return this.clasList; }
        }
        public void AcceptPeople(Class Class, params People[] PeopleMass)
        {
            for (int i = 0; i < this.clasList.Count; i++)
                if (Class == this.clasList[i])
                {
                    for (int j=0;j<PeopleMass.Length;j++)
                    {
                        this.clasList[i].PeopleList.Add(PeopleMass[j]);
                    }
                    break;
                }
        }
    }
}
