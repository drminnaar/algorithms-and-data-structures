namespace ADS.DataStructures.DoublyLinkedList
{
    public sealed class Node<T> where T : class
    {
        public Node(T value)
        {
            Value = value;
        }

        public Node<T> Next { get; set; }

        public Node<T> Previous { get; set; }

        public T Value { get; set; }

        public override bool Equals(object obj)
        {
            var otherNode = obj as Node<T>;

            return Value == otherNode?.Value && Next?.Value == otherNode?.Value;
        }

        public override int GetHashCode()
        {
            return Value?.GetHashCode() ?? 1
                ^ Next?.Value?.GetHashCode() ?? 0
                ^ Previous?.Value?.GetHashCode() ?? 0;
        }

        public static bool operator ==(Node<T> lhs, Node<T> rhs)
        {
            return lhs?.Value == rhs?.Value && lhs?.Next?.Value == rhs?.Next?.Value;
        }

        public static bool operator !=(Node<T> lhs, Node<T> rhs)
        {
            return !(lhs == rhs);
        }
    }
}