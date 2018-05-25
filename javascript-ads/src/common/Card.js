const Suit = {
    Clubs: 'Clubs',
    Diamonds: 'Diamonds',
    Hearts: 'Hearts',
    Spades: 'Spades'
};

const Card = function(rank, suit) {
    this.rank = rank;
    this.suit = suit;
};

Card.prototype = {
    compareTo: function(card) {
        if (this.rank === card.rank) {
            return 0;
        }

        return this.rank > card.rank ? 1 : -1;
    },

    toString: function() {
        return `Rank: ${this.rank} Suit: ${this.suit}`;
    }
};

module.exports = { Card, Suit };
