const { bubbleSort } = require('./bubbleSort');

const {
    getUnsortedNumbers,
    getSortedNumbers,
    getUnsortedStrings,
    getSortedStrings,
    getSortedCards,
    getUnsortedCards
} = require('../../common/test-data');

describe('Bubble sort list of numbers', () => {
    test('sorts a list of numbers', () => {
        expect(bubbleSort(getUnsortedNumbers())).toEqual(getSortedNumbers());
    });
});

describe('Bubble sort list of strings', () => {
    test('sorts a list of strings', () => {
        expect(bubbleSort(getUnsortedStrings())).toEqual(getSortedStrings());
    });
});

describe('Bubble sort list of cards', () => {
    test('sorts a list of cards', () => {
        expect(bubbleSort(getUnsortedCards())).toEqual(getSortedCards());
    });
});
