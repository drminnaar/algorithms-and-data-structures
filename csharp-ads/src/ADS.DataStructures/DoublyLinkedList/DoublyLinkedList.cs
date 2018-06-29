using System.Collections.Generic;
using System.Linq;

namespace ADS.DataStructures.DoublyLinkedList
{
    public sealed class DoublyLinkedList<T> where T : class
    {
        public long Count { get; private set; }

        public Node<T> Head { get; private set; }

        public Node<T> Tail { get; private set; }

        public bool Any()
        {
            return Head != null;
        }

        public void AddFront(T value)
        {
            var node = new Node<T>(value);
            node.Next = Head;

            if (Head == null)
            {
                Tail = node;
            }
            else
            {
                Head.Previous = node;
            }

            Head = node;
            Count++;
        }

        public void AddEnd(T value)
        {
            var node = new Node<T>(value);

            if (Tail == null)
            {
                Head = node;
            }
            else
            {
                Tail.Next = node;
                node.Previous = Tail;
            }

            Tail = node;
            Count++;
        }

        public Node<T> RemoveFront()
        {
            if (Head == null) return null;

            var removedNode = Head;

            if (Head.Next == null)
                Tail = null;
            else
                Head.Next.Previous = null;

            Head = Head.Next;
            removedNode.Next = null;
            Count--;

            return removedNode;
        }

        public Node<T> RemoveEnd()
        {
            if (Head == null) return null;

            var removedNode = Tail;

            if (Tail.Previous == null)
                Head = null;
            else
                Tail.Previous.Next = null;

            Tail = Tail.Previous;
            removedNode.Previous = null;
            Count--;

            return removedNode;
        }

        public IEnumerable<T> ToEnumerable()
        {
            var node = Head;

            while (node != null)
            {
                yield return node.Value;
                node = node.Next;
            }
        }

        public List<T> ToList()
        {
            return ToEnumerable().ToList();
        }

        public override string ToString()
        {
            var nodes = string.Join(" <-> ", ToList());
            var className = nameof(DoublyLinkedList<T>);

            return $"{className} [ {nodes} ]";
        }
    }
}