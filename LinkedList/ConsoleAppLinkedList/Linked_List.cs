using System;
using System.Collections;
using System.Collections.Generic;

namespace ConsoleAppLinkedList
{
    class Linked_List<T> : ICollection<Node<T>>
    {
        private Node<T> FirstNode;
        private int count;
        public int Count
        {
            get { return this.count; }
        }
        public Linked_List()
        {
            FirstNode = null;
            this.count = 0;
        }
        public Linked_List(IEnumerable<Node<T>> collection)
        {
            foreach (Node<T> element in collection)
            {
                Add(element);
            }
        }
        public Node<T> this[int i]
        {
            get
            {
                if ((i < count) && (i >= 0))
                {
                    if (i == 0) { return FirstNode; }
                    else return FirstNode.GetNext(i);
                }
                else throw new InvalidOperationException();
            }
            set
            {
                if ((i < count) && (i >= 0))
                {
                    if (i == 0) { FirstNode = value; }
                    else
                    {
                        value.NextNode = FirstNode.GetNext(i).NextNode;
                        FirstNode.GetNext(i-1).NextNode = value;
                    }
                }
                else throw new InvalidOperationException();
            }
        }
        
        public bool IsReadOnly => throw new NotImplementedException();
        public void Add(Node<T> Node)
        {
            if (FirstNode != null)
            {
                Node<T> SomeNode = this[count - 1];
                SomeNode.NextNode = Node;
                count++;
            }
            else { FirstNode = Node; count++; }
        }
        public void Add(IEnumerable<Node<T>> collection)
        {
            foreach (Node<T> Node in collection)
            {
                Add(Node);
            }
        }
        public void Add(int index, Node<T> Node)
        {
            if ((index < count) && (index >= 0))
            {
                Node<T> NodeIndex = this[index];
                if (NodeIndex.NextNode != null)
                {
                    Node.NextNode = NodeIndex.NextNode;
                }
                NodeIndex.NextNode = Node;
                count++;
            }
            else throw new InvalidOperationException();
        }
        public void Add(int index, IEnumerable<Node<T>> collection)
        {
            foreach (Node<T> Node in collection)
            {
                Add(index, Node);index++;
            }
        }

        public void Remove(int index)
        {
            if ((index < count) && (index >= 0))
            {
                if (index > 0)
                {
                    if (this[index].NextNode != null)
                    {
                        this[index - 1].NextNode = this[index].NextNode;
                    }
                    else
                    {
                        this[index - 1].NextNode = null;
                    }
                }
                else
                {
                    FirstNode = FirstNode.NextNode;
                }
                count--;
            }
            else throw new InvalidOperationException();
        }
        public void Clear()
        {
            FirstNode = null;
            count = 0;
        }
        
        public bool Contains(Node<T> Node)
        {
            bool Result = false;
            Node<T> SomeNode = FirstNode;
            for (int i = 0; i < count; i++)
            {
                if (Node == SomeNode)
                {
                    Result = true;
                    break;
                }
                else SomeNode = SomeNode.GetNext();
            }
            return Result;
        }
        public void CopyTo(Node<T>[] NodeList, int itemIndex)
        {
            if ((itemIndex < count) && (itemIndex >= 0))
            {
                for (int i = 0; i < NodeList.Length; i++)
                {
                    Add(itemIndex + i, NodeList[i]);
                }
            }
            else throw new InvalidOperationException();
        }

        public IEnumerator<Node<T>> GetEnumerator()
        {
            if (count > 0)
            {
                Node<T> SomeNode = FirstNode;
                yield return SomeNode;
                for (int i = 0; i < count - 1; i++)
                {
                    SomeNode = SomeNode.GetNext();
                    yield return SomeNode;
                }
            }else Console.WriteLine("Ошибка:\"Список пуст\"");
        }
        public bool Remove(Node<T> Node)
        {
            bool Result = false;
            for (int i = 0; i < count; i++)
            {
                if (this[i] == Node)
                {
                    if (i > 0)
                    {
                        this[i - 1].NextNode = (i < count - 1) ? this[i].NextNode : null;
                    }
                    else
                    {
                        FirstNode = this[1];
                    }
                    Result = true;
                    break;
                }
            }
            return Result;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            Node<T> SomeNode = FirstNode;
            yield return SomeNode;
            for (int i = 0; i < count - 1; i++)
            {
                SomeNode = SomeNode.GetNext();
                yield return SomeNode;
            }

        }
    }
}
