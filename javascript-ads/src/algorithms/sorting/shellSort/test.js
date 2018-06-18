const { shellSort } = require('./shellSort');

const {
    getUnsortedNumbers,
    getSortedNumbers,
    getUnsortedStrings,
    getSortedStrings,
    getSortedCards,
    getUnsortedCards
} = require('../../../common/test-data');

describe('Shell sort list of numbers', () => {
    test('sorts a list of numbers', () => {
        expect(shellSort(getUnsortedNumbers())).toEqual(getSortedNumbers());
    });
});

describe('Shell sort list of strings', () => {
    test('sorts a list of strings', () => {
        expect(shellSort(getUnsortedStrings())).toEqual(getSortedStrings());
    });
});

describe('Shell sort list of cards', () => {
    test('sorts a list of cards', () => {
        expect(shellSort(getUnsortedCards())).toEqual(getSortedCards());
    });
});
