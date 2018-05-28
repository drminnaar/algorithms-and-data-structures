const { selectionSort } = require('./selectionSort');

const {
    getUnsortedNumbers,
    getSortedNumbers,
    getUnsortedStrings,
    getSortedStrings,
    getSortedCards,
    getUnsortedCards
} = require('../../common/test-data');

describe('Selection sort list of numbers', () => {
    test('sorts a list of numbers', () => {
        expect(selectionSort(getUnsortedNumbers())).toEqual(getSortedNumbers());
    });
});

describe('Selection sort list of strings', () => {
    test('sorts a list of strings', () => {
        expect(selectionSort(getUnsortedStrings())).toEqual(getSortedStrings());
    });
});

describe('Selection sort list of cards', () => {
    test('sorts a list of cards', () => {
        expect(selectionSort(getUnsortedCards())).toEqual(getSortedCards());
    });
});
