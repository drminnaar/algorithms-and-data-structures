using System;

namespace ADS.AlgorithmsTests.Data
{
    internal enum Suit
    {
        Clubs = 1,
        Diamonds = 2,
        Hearts = 3,
        Spades = 4
    }

    internal sealed class Card : IComparable<Card>
    {
        public Card(Suit suit, int rank)
        {
            Suit = suit;
            Rank = rank;
        }

        public Suit Suit { get; private set; }

        public int Rank { get; private set; }

        public int CompareTo(Card other)
        {
            if (other == null)
                return -1;

            var comparison = this.Rank.CompareTo(other.Rank);

            return comparison == 0 ? this.Suit.CompareTo(other.Suit) : comparison;
        }

        public override string ToString()
        {
            return $"( {Rank} : {Suit} )";
        }

        public override int GetHashCode()
        {
            return Rank.GetHashCode() ^ Suit.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            var otherCard = obj as Card;

            return this.Rank == otherCard?.Rank && this.Suit == otherCard?.Suit;
        }

        public static bool operator ==(Card lhs, Card rhs)
        {
            return lhs?.Rank == rhs?.Rank && lhs?.Suit == rhs?.Suit;
        }

        public static bool operator !=(Card lhs, Card rhs)
        {
            return !(lhs == rhs);
        }
    }
}