const { DoublyLinkedList } = require('./DoublyLinkedList');
const { getRandomCard } = require('../../common/test-data');

describe('A doubly linked list of numbers', () => {
    const num1 = Math.ceil(1000 * Math.random());
    const num2 = Math.ceil(1000 * Math.random());
    const num3 = Math.ceil(1000 * Math.random());

    const list = new DoublyLinkedList();

    test('adds 3 nodes', () => {
        list.addFront(num1);
        list.addFront(num2);
        list.addFront(num3);

        expect(list.count).toEqual(3);
    });

    test('has correct head value', () => {
        expect(list.head.value).toEqual(num3);
    });

    test('has correct tail value', () => {
        expect(list.tail.value).toEqual(num1);
    });

    test('returns valid array after additions', () => {
        const arr = [num3, num2, num1];
        expect(list.toArray()).toEqual(arr);
    });

    test('removes one node from front', () => {
        const removedNode = list.removeFront();
        expect(removedNode.value).toEqual(num3);
        expect(list.head.value).toEqual(num2);
        expect(list.count).toEqual(2);
    });

    test('removes one node from end', () => {
        const removedNode = list.removeEnd();
        expect(removedNode.value).toEqual(num1);
        expect(list.tail.value).toEqual(num2);
        expect(list.count).toEqual(1);
    });

    test('returns valid array after removals', () => {
        const arr = [num2];
        expect(list.toArray()).toEqual(arr);
    });
});

describe('A doubly linked list of cards', () => {
    const card1 = getRandomCard();
    const card2 = getRandomCard();
    const card3 = getRandomCard();

    const list = new DoublyLinkedList();

    test('adds 3 nodes', () => {
        list.addFront(card1);
        list.addFront(card2);
        list.addFront(card3);

        expect(list.count).toEqual(3);
    });

    test('has correct head value', () => {
        expect(list.head.value).toEqual(card3);
    });

    test('has correct tail value', () => {
        expect(list.tail.value).toEqual(card1);
    });

    test('returns valid array after additions', () => {
        const arr = [card3, card2, card1];

        expect(list.toArray()).toEqual(arr);
    });

    test('removes one node from front', () => {
        const removedNode = list.removeFront();
        expect(removedNode.value).toEqual(card3);
        expect(list.head.value).toEqual(card2);
        expect(list.count).toEqual(2);
    });

    test('removes one node from end', () => {
        const removedNode = list.removeEnd();
        expect(removedNode.value).toEqual(card1);
        expect(list.tail.value).toEqual(card2);
        expect(list.count).toEqual(1);
    });

    test('returns valid array after removals', () => {
        const arr = [card2];
        expect(list.toArray()).toEqual(arr);
    });
});
