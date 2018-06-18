const { quickSort } = require('./quickSort');

const {
    getUnsortedNumbers,
    getSortedNumbers,
    getUnsortedStrings,
    getSortedStrings,
    getSortedCards,
    getUnsortedCards
} = require('../../../common/test-data');

describe('Quick sort list of numbers', () => {
    test('sorts a list of numbers', () => {
        expect(quickSort(getUnsortedNumbers())).toEqual(getSortedNumbers());
    });
});

describe('Quick sort list of strings', () => {
    test('sorts a list of strings', () => {
        expect(quickSort(getUnsortedStrings())).toEqual(getSortedStrings());
    });
});

describe('Quick sort list of cards', () => {
    test('sorts a list of cards', () => {
        expect(quickSort(getUnsortedCards())).toEqual(getSortedCards());
    });
});
