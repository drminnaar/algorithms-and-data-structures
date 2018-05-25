const { Card, Suit } = require('./Card');

const getUnsortedNumbers = function() {
    return [3, 8, 13, 1, 5, 2];
};

const getSortedNumbers = function() {
    return [1, 2, 3, 5, 8, 13];
};

const getUnsortedStrings = function() {
    return ['c', 'f', 'a', 'e', 'b', 'd'];
};

const getSortedStrings = function() {
    return ['a', 'b', 'c', 'd', 'e', 'f'];
};

const getUnsortedCards = function() {
    return [
        new Card(7, Suit.Diamonds),
        new Card(3, Suit.Diamonds),
        new Card(12, Suit.Diamonds),
        new Card(8, Suit.Diamonds),
        new Card(10, Suit.Diamonds),
        new Card(4, Suit.Diamonds),
        new Card(13, Suit.Diamonds),
        new Card(1, Suit.Diamonds),
        new Card(5, Suit.Diamonds),
        new Card(9, Suit.Diamonds),
        new Card(2, Suit.Diamonds),
        new Card(6, Suit.Diamonds),
        new Card(11, Suit.Diamonds)
    ];
};

const getSortedCards = function() {
    return [
        new Card(1, Suit.Diamonds),
        new Card(2, Suit.Diamonds),
        new Card(3, Suit.Diamonds),
        new Card(4, Suit.Diamonds),
        new Card(5, Suit.Diamonds),
        new Card(6, Suit.Diamonds),
        new Card(7, Suit.Diamonds),
        new Card(8, Suit.Diamonds),
        new Card(9, Suit.Diamonds),
        new Card(10, Suit.Diamonds),
        new Card(11, Suit.Diamonds),
        new Card(12, Suit.Diamonds),
        new Card(13, Suit.Diamonds)
    ];
};

module.exports = {
    getUnsortedNumbers,
    getSortedNumbers,
    getUnsortedStrings,
    getSortedStrings,
    getSortedCards,
    getUnsortedCards
};
