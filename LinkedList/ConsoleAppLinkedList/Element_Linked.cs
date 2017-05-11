using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppLinkedList
{
    class Element_Linked
    {
        int Number;
        private Element_Linked AfterElementLinked;
        private Element_Linked BeforeElementLinked;
        public int _Number { get; set; }
        public Element_Linked _AfterElementLinked { get; }
        public Element_Linked _BeforeElementLinked { get; }
        public Element_Linked(int number)
        {
            this.Number = number;
            this.AfterElementLinked = null;
            this.BeforeElementLinked = null;
        }
        public Element_Linked(int number, Element_Linked BeforeElementLinked)
        {
            this.Number = number;
            this.BeforeElementLinked = BeforeElementLinked;
            this.AfterElementLinked = null;
        }
        public Element_Linked(int number, Element_Linked BeforeElementLinked, Element_Linked AfterElementLinked)
        {
            this.Number = number;
            this.BeforeElementLinked = BeforeElementLinked;
            this.AfterElementLinked = AfterElementLinked;
        }
        public Element_Linked(Element_Linked AfterElementLinked)
        {
            this.BeforeElementLinked = null;
            this.AfterElementLinked = AfterElementLinked;
        }
    }
}
