const { SinglyLinkedList } = require('./SinglyLinkedList');
const { Card, Suit } = require('../../common/Card');
const { getRandomCard } = require('../../common/test-data');

describe('A singly linked list of numbers', () => {
    const num1 = Math.ceil(1000 * Math.random());
    const num2 = Math.ceil(1000 * Math.random());
    const num3 = Math.ceil(1000 * Math.random());

    const list = new SinglyLinkedList();

    test('adds 3 nodes', () => {
        list.addFront(num1);
        list.addFront(num2);
        list.addFront(num3);

        expect(list.count).toEqual(3);
    });

    test('has correct head value', () => {
        expect(list.head.value).toEqual(num3);
    });

    test('removes one node', () => {
        const removedNode = list.removeFront();
        expect(removedNode.value).toEqual(num3);
        expect(list.head.value).toEqual(num2);
    });

    test('returns valid array', () => {
        const arr = [num2, num1];
        expect(list.toArray()).toEqual(arr);
    });
});

describe('A singly linked list of cards', () => {
    const card1 = getRandomCard();
    const card2 = getRandomCard();
    const card3 = getRandomCard();

    const list = new SinglyLinkedList();

    test('adds 3 nodes', () => {
        list.addFront(card1);
        list.addFront(card2);
        list.addFront(card3);

        expect(list.count).toEqual(3);
    });

    test('has correct head value', () => {
        expect(list.head.value).toEqual(card3);
    });

    test('removes one node', () => {
        const removedNode = list.removeFront();
        expect(removedNode.value).toEqual(card3);
        expect(list.head.value).toEqual(card2);
    });

    test('returns valid array', () => {
        const arr = [card2, card1];

        expect(list.toArray()).toEqual(arr);
    });
});
