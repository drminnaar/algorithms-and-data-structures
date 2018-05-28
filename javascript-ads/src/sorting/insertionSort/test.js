const { insertionSort } = require('./insertionSort');

const {
    getUnsortedNumbers,
    getSortedNumbers,
    getUnsortedStrings,
    getSortedStrings,
    getSortedCards,
    getUnsortedCards
} = require('../../common/test-data');

describe('Insertion sort list of numbers', () => {
    test('sorts a list of numbers', () => {
        expect(insertionSort(getUnsortedNumbers())).toEqual(getSortedNumbers());
    });
});

describe('Insertion sort list of strings', () => {
    test('sorts a list of strings', () => {
        expect(insertionSort(getUnsortedStrings())).toEqual(getSortedStrings());
    });
});

describe('Insertion sort list of cards', () => {
    test('sorts a list of cards', () => {
        expect(insertionSort(getUnsortedCards())).toEqual(getSortedCards());
    });
});
