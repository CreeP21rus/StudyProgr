namespace ConsoleApp1
{
    public class School
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
}
