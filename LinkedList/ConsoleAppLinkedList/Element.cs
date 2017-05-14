using System;

namespace ConsoleAppLinkedList
{
    class Element
    {
        public object Data;
        public Element NextElement;
        public Element PreviousElement;
        public Element()
        {
            this.Data = 0;
            this.NextElement = null;
            this.PreviousElement = null;
        }
        public Element(object Data)
        {
            this.Data = Data;
            this.NextElement = null;
            this.PreviousElement = null;
        }
        public Element(object Data, Element PreviousElement)
        {
            this.Data = Data;
            this.PreviousElement = PreviousElement;
            this.NextElement = null;
        }
        public Element(object Data, Element PreviousElement, Element NextElement)
        {
            this.Data = Data;
            this.PreviousElement = PreviousElement;
            this.NextElement = NextElement;
        }
        public Element(Element NextElement)
        {
            this.PreviousElement = null;
            this.NextElement = NextElement;
        }
        public ref Element GetNext()
        {
            return ref NextElement;
        }
        public Element GetNext(int index)
        {
            if (index >= 0)
            {
                Element Result = index == 0 ? this : NextElement;
                for (int i = 2; i <= index; i++)
                {
                    Result = Result.GetNext();
                }
                return Result;
            }
            else throw new InvalidOperationException();
        }
        public Element GetPrevious()
        {
            return PreviousElement;
        }
        public Element GetPrevious(int index)
        {
            if (index >= 0)
            {
                Element Result = index == 0 ? this : NextElement;
                for (int i = 2; i <= index; i++)
                {
                    Result = Result.GetNext();
                }
                return Result;
            }
            else throw new InvalidOperationException();
        }

    }
}
