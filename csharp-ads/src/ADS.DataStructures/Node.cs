namespace ADS.DataStructures
{
    public sealed class Node<T> where T : class
    {
        public Node(T value)
        {
            Value = value;
        }

        public T Value { get; private set; }

        public Node<T> Next { get; set; }

        public override string ToString()
        {
            return $"Node (Value: {Value}, Next: {Next?.Value}";
        }

        public override bool Equals(object obj)
        {
            var otherNode = obj as Node<T>;

            return Value == otherNode?.Value && Next?.Value == otherNode?.Value;
        }

        public override int GetHashCode()
        {
            return Value.GetHashCode() ^ Next.Value.GetHashCode();
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