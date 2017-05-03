using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    public class Human
    {
        private string name;
        public Human()
        {
            this.name = null;
        }
        public Human(string name)
        {
            this.name = name;
        }
        public string Name
        {
            set { if (this.name == null) this.name = value; }
            get { return this.name; }
        }
        public void Eat(Canteen canteen)
        {
            canteen.Service(this, new List<string> { " FOOD!!! " });
        }
        public void Leave(School school)
        {
            school.Kick(this);
        }
    }
}
