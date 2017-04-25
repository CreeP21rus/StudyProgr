using System;

namespace ConsoleApp1
{
    public class Class
    {
        private string name;
        private People[] peopleList;
        private School school;
        public Class()
        {
            name = null;
            peopleList = new People[0];
        }
        public Class(string name, ref School school, People[] peopleList)
        {
            this.name = name;
            this.school = school;
            this.peopleList = peopleList;
        }

        public string Name
        {
            set { this.name = value; }
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
        public People this[int i]
        {
            get { return peopleList[i]; }
            set
            {
                peopleList[i] = value;
            }
        }
        public People[] PeopleList
        {
            get { return this.peopleList; }
        }
        public int Length
        {
            get { return peopleList.Length; }
        }
        public void changeLength(int length)
        {
            Array.Resize(ref peopleList, length);
        }
    }
}
