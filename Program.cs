using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class People
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

        public void ChangeGroup(Group[] group, int idg)
        {
            if (group[idg].Number < 5)
            {
                Program.Delete(this.id, group[this.idgroup]);
                group[idg][group[idg].Number] = this.id;
                group[idg].Number = group[idg].Number + 1;
                idgroup = idg;
            }
            else Console.WriteLine("Sorry group is full");
        }
        public void ChangeSchool(School[] school, Group[] group, int ids)
        {
            if ((school[ids].Number>this.idgroup)&&(group[school[ids][this.idgroup]].Number < 5))
            {
                Program.Delete(this.id, group[this.idgroup]);
                group[school[ids][this.idgroup]][group[school[ids][this.idgroup]].Number] = this.id;
                group[school[ids][this.idgroup]].Number = group[school[ids][this.idgroup]].Number + 1;
                idschool = ids;
            }
            else Console.WriteLine("Sorry group is full");
        }
        public void ChangeSchool(School[] school, Group[] group, int ids, int idg)
        {
            if ((school[ids].Number > idg) && (group[school[ids][idg]].Number < 5))
            {
                Program.Delete(this.id, group[this.idgroup]);
                group[school[ids][idg]][group[school[ids][idg]].Number] = this.id;
                group[school[ids][idg]].Number = group[school[ids][idg]].Number + 1;
                idschool = ids;
                idgroup = idg;
            }
            else Console.WriteLine("Sorry group is full");
        }
        public void ShowInfo()
        {
            Console.WriteLine("Name=" + name + " ID=" + id + " GroupID=" + idgroup + " SchoolID=" + idschool);
        }
    }
    class Group
    {
        private string name;
        private int id;
        private int number;
        private int[] peoplelist;
        private int idschool;
        public Group(int np1)
        {
            name = null;
            id = -1;
            number = 0;
            peoplelist = new int[np1];
            idschool = -1;
        }
        public Group(string name, int idschool, int[] peoplelist, int number)
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

        public void ShowList(People[] people)
        {
            for (int i = 0; i < number; i++)
            {
                Console.Write(people[peoplelist[i]].Name+" ");
            }
        }
    }
    class School
    {
        private string name;
        private int id;
        private int idcanteen;
        private int[] grouplist;
        private int number;
        public School(int ng1)
        {
            name = "";
            id = -1;
            number = 0;
            grouplist = new int[ng1];
            idcanteen = -1;
        }
        public School(string name, int idcanteen, int[] grouplist, int number)
        {
            this.name = name;
            this.idcanteen = idcanteen;
            this.grouplist = grouplist;
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
        public int Idcanteer
        {
            get { return this.idcanteen; }
            set { this.idcanteen = value; }
        }
        public int Number
        {
            get { return this.number; }
            set { this.number = value; }
        }
        public int[] Grouplist
        {
            get { return this.grouplist; }
            set { this.grouplist = value; }
        }
        public int Length
        {
            get { return grouplist.Length; }
        }
        public int this[int i]
        {
            get { return grouplist[i]; }
            set { grouplist[i] = value; }
        }

        public void ChangeCanteen(int idcanteen)
        {
            this.idcanteen = idcanteen;
        }
    }
    class Canteen
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
        public void ShowMenu()
        {
            foreach(string x in this.menu)
            {
                Console.WriteLine(x);
            }
        }
    }
    class Program
    {
        public static void Delete(int id, Group group)
        {
            int[] list = group.Peoplelist;
            int number = group.Number;
            int i = 0;
            while (list[i] != id)
            {
                i++;
            }
            group.Number = group.Number - 1;
            for (; i < number - 1; i++)
            {
                list[i] = list[i + 1];
            }

            group.Peoplelist = list;
        }
        static void Main(string[] args)
        {
            int ns = 1, ng1 = 11, ng = ns * ng1, np1 = 5, np = ng * np1;
            //int ns = 5, ng = ns * 55, np = ng * 30;
            School[] School = new School[ns];//в каждой школе 55груп, на каждый класс по 5
            Group[] Group = new Group[ng];//в каждой группе максимум 30 человек
            Canteen[] Canteen = new Canteen[ns];
            People[] People = new People[np];
            int i;
            {
                for (i = 0; i < ns; i++)
                {
                    School[i] = new School(ng1);
                    School[i].Id = i;
                }
                for (i = 0; i < np; i++)
                {
                    People[i] = new People();
                    People[i].Id = i;
                }
                for (i = 0; i < ns; i++)
                {
                    Canteen[i] = new Canteen();
                    Canteen[i].Id = i;
                }
                for (i = 0; i < ng; i++)
                {
                    Group[i] = new Group(np1);
                    Group[i].Id = i+1;
                }
            }
            /*{
                School[0] = new School("S#0", 0, new int[11] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 }, 10);
                Canteen[0] = new Canteen("C#0", 0, new string[2] { "Soup","Meat" });
                Group[1] = new Group("#1", 0, new int[5] { 0, 1, 2, -1, -1 }, 3);
                Group[2] = new Group("#2", 0, new int[5] { 3, 4, 2, -1, -1 }, 2);
                Group[3] = new Group("#3", 0, new int[5] { 5, -1, 2, -1, -1 }, 1);
                Group[4] = new Group("#4", 0, new int[5] { 6, 7, 8, 9, 10 }, 5);
                Group[5] = new Group("#5", 0, new int[5] { 11, 12, 13, 14, -1 }, 4);
                Group[6] = new Group("#6", 0, new int[5] { 15, 16, 17, -1, -1 }, 3);
                Group[7] = new Group("#7", 0, new int[5] { 18, 19, 20, -1, -1 }, 3);
                Group[8] = new Group("#8", 0, new int[5] { 21, 22, 2, -1, -1 }, 2);
                Group[9] = new Group("#9", 0, new int[5] { 23, 24, 25, -1, -1 }, 3);
                Group[10] = new Group("#10", 0, new int[5] { 26, 1, 2, -1, -1 }, 1);
                People[0] = new People("A", 0, 0);
                People[1] = new People("B", 0, 0);
                People[2] = new People("C", 0, 0);
                People[3] = new People("D", 1, 0);
                People[4] = new People("E", 1, 0);
                People[5] = new People("F", 2, 0);
                People[6] = new People("G", 3, 0);
                People[7] = new People("H", 3, 0);
                People[8] = new People("I", 3, 0);
                People[9] = new People("J", 3, 0);
                People[10] = new People("K", 3, 0);
                People[11] = new People("L", 4, 0);
                People[12] = new People("M", 4, 0);
                People[13] = new People("N", 4, 0);
                People[14] = new People("O", 4, 0);
                People[15] = new People("P", 5, 0);
                People[16] = new People("Q", 5, 0);
                People[17] = new People("R", 5, 0);
                People[18] = new People("S", 6, 0);
                People[19] = new People("T", 6, 0);
                People[20] = new People("U", 6, 0);
                People[21] = new People("V", 7, 0);
                People[22] = new People("W", 7, 0);
                People[23] = new People("X", 8, 0);
                People[24] = new People("Y", 8, 0);
                People[25] = new People("Z", 8, 0);
                People[26] = new People("A", 9, 0);
            }
            for (i = 0; i < School[0].Number; i++)
            {
                Console.Write(School[0][i] + " ");
            }Console.WriteLine();
            People[3].ShowInfo();
            Group[1].ShowList(People);Console.WriteLine();
            Group[3].ShowList(People); Console.WriteLine();
            Canteen[0].ShowMenu();
            People[3].ChangeGroup(Group,3);
            People[3].ShowInfo();
            Group[1].ShowList(People); Console.WriteLine();
            Group[3].ShowList(People); Console.WriteLine();
            */

            Console.ReadKey();
        }
    }
}
