using System;

namespace ConsoleAppLinkedList
{
    class Node<T>
    {
        public T Data;
        public Node<T> NextNode;
        public Node()
        {
            this.Data = default(T);
            this.NextNode = null;
        }
        public Node(T Data)
        {
            this.Data = Data;
            this.NextNode = null;
        }
        public Node(T Data, Node<T> NextNode)
        {
            this.Data = Data;
            this.NextNode = NextNode;
        }
        public Node(Node<T> NextNode)
        {
            this.NextNode = NextNode;
        }
        public Node<T> GetNext()
        {
            return NextNode;
        }
        public Node<T> GetNext(int index)
        {
            if (index >= 0)
            {
                Node<T> Result = index == 0 ? this : NextNode;
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
