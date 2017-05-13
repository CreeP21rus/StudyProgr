using System;
using System.Collections;
using System.Collections.Generic;

namespace ConsoleAppLinkedList
{
    class Linked_List : ICollection<int>
    {
        private Element ElementLink;
        private int count;
        public int Count
        {
            get { return this.count; }
        }
        public Linked_List()
        {
            ElementLink = null;
            this.count = 0;
        }
        public Linked_List(Element ElementLink)
        {
            this.ElementLink = ElementLink;
        }
        public Element GetElement(int index)
        {
            if ((index <= count) && (index >= 0))
            {
                Element Element;
                if (index == 0) { Element = ElementLink; }
                else Element = ElementLink.GetNext(index);
                return Element;
            }
            else throw new InvalidOperationException();
        }
        
        public bool IsReadOnly => throw new NotImplementedException();
        public void Add(int item)
        {
            if (ElementLink != null)
            {
                Element Element = GetElement(count - 1);
                Element.NextElement = new Element(item, Element);
                count++;
            } else { ElementLink = new Element(item); count++; }
        }
        public void AddFirst(int item)
        {
            Element Element = new Element(item);
            ElementLink.PreviousElement = Element;
            Element.NextElement = ElementLink;
            ElementLink = Element;
        }
        public void Add(int index ,int item)
        {
            if ((index < count) && (index >= 0))
            {
                Element Element = new Element(item);
                Element ElementIndex = GetElement(index);
                if (ElementIndex.NextElement != null)
                {
                    ElementIndex.NextElement.PreviousElement = Element;
                    Element.NextElement = ElementIndex.NextElement;
                }
                Element.PreviousElement = ElementIndex;
                ElementIndex.NextElement = Element;
                count++;
            }
            else throw new InvalidOperationException();
        }

        public void Delete(int index)
        {
            if ((index < count) && (index >= 0))
            {
                Element Element = GetElement(index);
                if (Element.PreviousElement != null)
                {
                    Element.PreviousElement.NextElement = Element.NextElement;
                }
                if (Element.NextElement != null)
                {
                    Element.NextElement.PreviousElement = Element.PreviousElement;
                }
                count--;
            }
            else throw new InvalidOperationException();
        }
        public void Clear()
        {
            Element Element = GetElement(count - 2);
            for (int i=count-1;i>0;i--)
            {
                Element.NextElement = null;
                Element = Element.PreviousElement;
            }
            ElementLink = null;
            count = 0;
        }

        public bool Contains(int item)
        {
            bool Result = false;
            Element Element = ElementLink;
            for (int i=0;i<count;i++)
            {
                if (item == Element.Number)
                {
                    Result = true;
                    break;
                }
                else Element = Element.GetNext();
            }
            return Result;
        }

        public void CopyTo(int[] array, int arrayIndex)
        {
            if ((arrayIndex < count) && (arrayIndex >= 0))
            {
                for (int i = 0; i < array.Length; i++)
                {
                    Add(array[i], arrayIndex + i);
                }
            }
            else throw new InvalidOperationException();
        }

        public IEnumerator<int> GetEnumerator()
        {
            if (count > 0)
            {
                Element Element = ElementLink;
                yield return Element.Number;
                for (int i = 0; i < count - 1; i++)
                {
                    Element = Element.GetNext();
                    yield return Element.Number;
                }
            }else Console.WriteLine("Ошибка:\"Список пуст\"");
        }

        public bool Remove(int item)
        {
            bool Result = false;
            Element Element = ElementLink;
            for (int i = 0; i < count; i++)
            {
                if (item == Element.Number)
                {
                    Element.GetNext().NextElement = null;
                    Element.GetPrevious().PreviousElement = null;
                    Result = true;
                    break;
                }
            }
            return Result;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            Element Element = ElementLink;
            yield return Element;
            for (int i = 0; i < count - 1; i++)
            {
                Element = Element.GetNext();
                yield return Element;
            }

        }
    }
}
