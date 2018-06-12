using ADS.Data;

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
                Card.Diamonds(7),
                Card.Diamonds(3),
                Card.Diamonds(12),
                Card.Diamonds(8),
                Card.Diamonds(10),
                Card.Diamonds(4),
                Card.Diamonds(13),
                Card.Diamonds(1),
                Card.Diamonds(5),
                Card.Diamonds(9),
                Card.Diamonds(2),
                Card.Diamonds(6),
                Card.Diamonds(11),
            };
        }

        internal static Card[] SortedCards
        {
            get => new Card[13] {
                Card.Diamonds(1),
                Card.Diamonds(2),
                Card.Diamonds(3),
                Card.Diamonds(4),
                Card.Diamonds(5),
                Card.Diamonds(6),
                Card.Diamonds(7),
                Card.Diamonds(8),
                Card.Diamonds(9),
                Card.Diamonds(10),
                Card.Diamonds(11),
                Card.Diamonds(12),
                Card.Diamonds(13),
            };
        }
    }
}