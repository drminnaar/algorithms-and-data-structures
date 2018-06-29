using System;
using System.Collections.Generic;
using System.Linq;

namespace ADS.DataStructures.SinglyLinkedList
{
    public sealed class SinglyLinkedList<T> where T : class
    {
        public long Count { get; private set; }

        public Node<T> Head { get; private set; }

        public bool Any()
        {
            return Head != null;
        }

        public void AddFront(T value)
        {
            var node = new Node<T>(value);
            node.Next = Head;

            Head = node;

            Count++;
        }

        public Node<T> RemoveFront()
        {
            if (!Any())
            {
                return null;
            }

            var removedNode = Head;
            Head = removedNode.Next;
            removedNode.Next = null;
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
            return this.ToEnumerable().ToList();
        }

        public override string ToString()
        {
            var nodes = string.Join(" -> ", ToList());
            var className = nameof(SinglyLinkedList<T>);

            return $"{className} [ {nodes} ]";
        }
    }
}
