using System;

namespace ConsoleAppLinkedList
{
    class Element
    {
        public int Number;
        public Element NextElement;
        public Element PreviousElement;
        public Element()
        {
            this.Number = 0;
            this.NextElement = null;
            this.PreviousElement = null;
        }
        public Element(int number)
        {
            this.Number = number;
            this.NextElement = null;
            this.PreviousElement = null;
        }
        public Element(int number, Element PreviousElement)
        {
            this.Number = number;
            this.PreviousElement = PreviousElement;
            this.NextElement = null;
        }
        public Element(int number, Element PreviousElement, Element NextElement)
        {
            this.Number = number;
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
        public Element GetNext(int number)
        {
            Element Result = NextElement;
            for (int i=2;i<=number;i++)
            {
                Result = Result.GetNext();
            }
            return Result;
        }
        public Element GetPrevious()
        {
            return PreviousElement;
        }
        public Element GetPrevious(int number)
        {
            Element Result = NextElement;
            for (int i = 2; i <= number; i++)
            {
                Result = Result.GetNext();
            }
            return Result;
        }

    }
}
