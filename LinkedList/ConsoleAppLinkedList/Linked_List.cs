using System;
using System.Collections;
using System.Collections.Generic;

namespace ConsoleAppLinkedList
{
    class Linked_List : ICollection<Element>
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
        public void Add(object item)
        {
            if (ElementLink != null)
            {
                Element Element = GetElement(count - 1);
                Element.NextElement = new Element(item, Element);
                count++;
            } else { ElementLink = new Element(item); count++; }
        }
        public void Add(Element item)
        {
            if (ElementLink != null)
            {
                Element Element = GetElement(count - 1);
                Element.NextElement = item;
                count++;
            }
            else { ElementLink = item; count++; }
        }
        public void Add(int index ,object item)
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
        public void Add(int index, Element item)
        {
            if ((index < count) && (index >= 0))
            {
                Element ElementIndex = GetElement(index);
                if (ElementIndex.NextElement != null)
                {
                    ElementIndex.NextElement.PreviousElement = item;
                    item.NextElement = ElementIndex.NextElement;
                }
                item.PreviousElement = ElementIndex;
                ElementIndex.NextElement = item;
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

        public bool Contains(object item)
        {
            bool Result = false;
            Element Element = ElementLink;
            for (int i=0;i<count;i++)
            {
                if (item == Element.Data)
                {
                    Result = true;
                    break;
                }
                else Element = Element.GetNext();
            }
            return Result;
        }
        public bool Contains(Element item)
        {
            bool Result = false;
            Element Element = ElementLink;
            for (int i = 0; i < count; i++)
            {
                if (item == Element)
                {
                    Result = true;
                    break;
                }
                else Element = Element.GetNext();
            }
            return Result;
        }

        public void CopyTo(object[] item, int itemIndex)
        {
            if ((itemIndex < count) && (itemIndex >= 0))
            {
                for (int i = 0; i < item.Length; i++)
                {
                    Add(itemIndex + i, item[i]);
                }
            }
            else throw new InvalidOperationException();
        }
        public void CopyTo(Element[] item, int itemIndex)
        {
            if ((itemIndex < count) && (itemIndex >= 0))
            {
                for (int i = 0; i < item.Length; i++)
                {
                    Add(itemIndex + i, item[i]);
                }
            }
            else throw new InvalidOperationException();
        }

        public IEnumerator<Element> GetEnumerator()
        {
            if (count > 0)
            {
                Element Element = ElementLink;
                yield return Element;
                for (int i = 0; i < count - 1; i++)
                {
                    Element = Element.GetNext();
                    yield return Element;
                }
            }else Console.WriteLine("Ошибка:\"Список пуст\"");
        }

        public bool Remove(object item)
        {
            bool Result = false;
            Element Element = ElementLink;
            for (int i = 0; i < count; i++)
            {
                if (item == Element.Data)
                {
                    Element.GetNext().NextElement = null;
                    Element.GetPrevious().PreviousElement = null;
                    Result = true;
                    break;
                }
            }
            return Result;
        }
        public bool Remove(Element item)
        {
            bool Result = false;
            Element Element = ElementLink;
            for (int i = 0; i < count; i++)
            {
                if (item == Element)
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
