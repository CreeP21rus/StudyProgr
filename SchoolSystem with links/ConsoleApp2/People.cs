using System;

namespace ConsoleApp1
{
    public class People
    {
        public void Delete(ref Class clas)
        {
            int i = 0;
            while (clas.PeopleList[i] != this)
            {
                i++;
            }
            for (; i < clas.Length-1; i++)
            {
                clas.PeopleList[i] = clas.PeopleList[i + 1];
            }
            clas.changeLength(clas.Length - 1);
        }
        private string name;
        private Class clas;
        private School school;
        public People()
        {
            name = null;
        }
        public People(string name, ref Class clas, ref School school)
        {
            this.name = name;
            this.clas = clas;
            this.school = school;
        }
        public string Name
        {
            set { this.name = value; }
            get { return this.name; }
        }
        public Class Class
        {
            get { return this.Class; }
            set
            {
                this.clas = value;
            }
        }
        public School School
        {
            get { return this.school; }
            set
            {
                this.school = value;
            }
        }

        public void ChangeClass(ref Class clas )
        {
            Delete(ref this.clas);
            clas.changeLength(clas.Length + 1);
            clas[clas.Length-1] = this;
            this.clas = clas;
        }
        public void ChangeSchool(ref School school, int number)
        {
            Delete(ref this.clas);
            school.ChangeLength(school.Length + 1);
            school[number][school[number].Length] = this;
            this.school = school;
        }
    }
}
