const { mergeSort } = require('./mergeSort');

const {
    getUnsortedNumbers,
    getSortedNumbers,
    getUnsortedStrings,
    getSortedStrings,
    getSortedCards,
    getUnsortedCards
} = require('../../../common/test-data');

describe('Merge sort list of numbers', () => {
    test('sorts a list of numbers', () => {
        expect(mergeSort(getUnsortedNumbers())).toEqual(getSortedNumbers());
    });
});

describe('Merge sort list of strings', () => {
    test('sorts a list of strings', () => {
        expect(mergeSort(getUnsortedStrings())).toEqual(getSortedStrings());
    });
});

describe('Merge sort list of cards', () => {
    test('sorts a list of cards', () => {
        expect(mergeSort(getUnsortedCards())).toEqual(getSortedCards());
    });
});
