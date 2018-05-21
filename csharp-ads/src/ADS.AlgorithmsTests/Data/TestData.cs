namespace ADS.AlgorithmsTests.Data
{
    internal static class TestData
    {
        internal static int[] UnsortedIntegers
        {
            get => new int[6] { 3, 8, 13, 1, 5, 2 };
        }

        internal static int[] SortedIntegers
        {
            get => new int[6] { 1, 2, 3, 5, 8, 13 };
        }

        internal static string[] UnsortedStrings
        {
            get => new string[6] { "c", "f", "a", "e", "b", "d" };
        }

        internal static string[] SortedStrings
        {
            get => new string[6] { "a", "b", "c", "d", "e", "f" };
        }

        internal static Card[] UnsortedCards
        {
            get => new Card[13] {
                new Card(Suit.Diamonds, 7),
                new Card(Suit.Diamonds, 3),
                new Card(Suit.Diamonds, 12),
                new Card(Suit.Diamonds, 8),
                new Card(Suit.Diamonds, 10),
                new Card(Suit.Diamonds, 4),
                new Card(Suit.Diamonds, 13),
                new Card(Suit.Diamonds, 1),
                new Card(Suit.Diamonds, 5),
                new Card(Suit.Diamonds, 9),
                new Card(Suit.Diamonds, 2),
                new Card(Suit.Diamonds, 6),
                new Card(Suit.Diamonds, 11),
            };
        }

        internal static Card[] SortedCards
        {
            get => new Card[13] {
                new Card(Suit.Diamonds, 1),
                new Card(Suit.Diamonds, 2),
                new Card(Suit.Diamonds, 3),
                new Card(Suit.Diamonds, 4),
                new Card(Suit.Diamonds, 5),
                new Card(Suit.Diamonds, 6),
                new Card(Suit.Diamonds, 7),
                new Card(Suit.Diamonds, 8),
                new Card(Suit.Diamonds, 9),
                new Card(Suit.Diamonds, 10),
                new Card(Suit.Diamonds, 11),
                new Card(Suit.Diamonds, 12),
                new Card(Suit.Diamonds, 13),
            };
        }
    }
}