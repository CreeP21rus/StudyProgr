using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppLinkedList
{
    class Linked_List
    {
        private List<Element_Linked> List;
        Linked_List()
        {
            List = new List<Element_Linked>();
        }
        public void AddFirst(int number)
        {
            List.Add(new Element_Linked(number));
        }
        public void AddBefore(int number, Element_Linked ElementLinked)
        {
            int index = List.IndexOf(ElementLinked);
            List.Insert(index, new Element_Linked(number, ElementLinked._BeforeElementLinked, ElementLinked));
            ElementLinked = new Element_Linked(ElementLinked._Number, List[index], ElementLinked._AfterElementLinked);
        }
        public void AddAfter(int number, Element_Linked ElementLinkedList)
        {
            int index = List.IndexOf(ElementLinkedList)+1;
            List.Insert(index, new Element_Linked(number, ElementLinkedList, ElementLinkedList._AfterElementLinked));
            ElementLinkedList = new Element_Linked(ElementLinkedList._Number, ElementLinkedList._BeforeElementLinked, List[index]);
        }
        public void AddLast(int number)
        {
            List.Add(new Element_Linked(number, List[List.Count - 1]));
            List[List.Count - 2] = new Element_Linked(List[List.Count - 2]._Number, List[List.Count - 2]._BeforeElementLinked, List[List.Count - 1]);
        }
        public void RemoveFirst()
        {
            List[1] = new Element_Linked(List[1]._Number, null , List[1]._AfterElementLinked);
            List.Remove(List[0]);
        }
        public void Remove(int index)
        {
            List[index - 1] = new Element_Linked(List[index - 1]._Number, List[index - 1]._BeforeElementLinked, List[index]._AfterElementLinked);
            List[index + 1] = new Element_Linked(List[index + 1]._Number, List[index]._BeforeElementLinked, List[index + 1]._AfterElementLinked);
            List.Remove(List[index]);
        }
        public void RemoveLast()
        {
            List[List.Count - 2] = new Element_Linked(List[List.Count - 2]._Number, List[List.Count - 2]._BeforeElementLinked, null);
            List.Remove(List[List.Count - 1]);
        }
        public void Clear()
        {
            for(int i=0;i<List.Count;i++)
            {
                Remove(i);
            }
        }
        public bool Contains(int number)
        {
            bool rez=false;
            foreach (Element_Linked element in List)
            {
                if (element._Number==number)
                {
                    rez = true;
                    break;
                }
            }
            return rez;
        }
        public int Count()
        {
            return List.Count;
        }
        public void CopyTo(int[] array,int index)
        {
            for (int i=index;i<List.Count;i++)
            {
                array[i - index] = List[i]._Number;
            }
        }
        public Element_Linked Find(int number)
        {
            Element_Linked rez=null;
            foreach (Element_Linked element in List)
            {
                if (element._Number == number)
                {
                    rez = element;
                    break;
                }
            }
            return rez;
        }
        public Element_Linked FindLast(int number)
        {
            Element_Linked rez = null;
            for (int i=List.Count-1;i>=0;i--)
            {
                if (List[i]._Number == number)
                {
                    rez = List[i];
                    break;
                }
            }
            return rez;
        }
        public Element_Linked First()
        {
            return List[0];
        }
        public Element_Linked Last()
        {
            return List[List.Count - 1];
        }
    }
}
