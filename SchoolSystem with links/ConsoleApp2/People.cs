using System;

namespace ConsoleApp1
{
    public class People
    {
        private string name;
        private int id;
        private int idgroup;
        private int idschool;
        public People()
        {
            name = null;
            id = -1;
            idgroup = -1;
            idschool = -1;
        }
        public People(string name, int idgroup, int idschool)
        {
            this.name = name;
            this.idgroup = idgroup;
            this.idschool = idschool;

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
        public int Idgroup
        {
            get { return this.idgroup; }
            set { this.idgroup = value; }
        }
        public int Idschool
        {
            get { return this.idschool; }
            set { this.idschool = value; }
        }

        public void ChangeGroup(Class[] group, int idgroup)
        {
            if (group[idgroup].Number < 5)
            {
                Program.Delete(this.id, group[this.idgroup]);
                group[idgroup][group[idgroup].Number] = this.id;
                group[idgroup].Number = group[idgroup].Number + 1;
                this.idgroup = idgroup;
            }
            else Console.WriteLine("Sorry group is full");
        }
        public void ChangeSchool(School[] school, Class[] group, int idschool)
        {
            if ((school[idschool].Number>this.idgroup)&&(group[school[idschool][this.idgroup]].Number < 5))
            {
                Program.Delete(this.id, group[this.idgroup]);
                group[school[idschool][this.idgroup]][group[school[idschool][this.idgroup]].Number] = this.id;
                group[school[idschool][this.idgroup]].Number = group[school[idschool][this.idgroup]].Number + 1;
                this.idschool = idschool;
            }
            else Console.WriteLine("Sorry group is full");
        }
        public void ChangeSchool(School[] school, Class[] group, int idschool, int idgroup)
        {
            if ((school[idschool].Number > idgroup) && (group[school[idschool][idgroup]].Number < 5))
            {
                Program.Delete(this.id, group[this.idgroup]);
                group[school[idschool][idgroup]][group[school[idschool][idgroup]].Number] = this.id;
                group[school[idschool][idgroup]].Number = group[school[idschool][idgroup]].Number + 1;
                this.idschool = idschool;
                this.idgroup = idgroup;
            }
            else Console.WriteLine("Sorry group is full");
        }
    }
}
