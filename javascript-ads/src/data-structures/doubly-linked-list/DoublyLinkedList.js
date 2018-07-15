const { Node } = require('./Node');

class DoublyLinkedList {
    constructor() {
        this.head = null;
        this.tail = null;
        this.count = 0;
    }

    any() {
        return this.head !== null;
    }

    addFront(value) {
        const node = new Node(value);
        node.next = this.head;

        if (this.head === null) {
            this.tail = node;
        } else {
            this.head.previous = node;
        }

        this.head = node;
        this.count++;
    }

    addEnd(value) {
        const node = new Node(value);

        if (this.tail === null) {
            this.head = node;
        } else {
            this.tail.next = node;
            node.previous = this.tail;
        }

        this.tail = node;
        this.count++;
    }

    removeFront() {
        if (this.head === null) {
            return null;
        }

        const deletedNode = this.head;

        if (this.head.next == null) {
            this.tail = null;
        } else {
            this.head.next.previous = null;
        }

        this.head = this.head.next;
        deletedNode.next = null;
        this.count--;

        return deletedNode;
    }

    removeEnd() {
        if (this.tail === null) {
            return null;
        }

        const deletedNode = this.tail;

        if (this.tail.previous === null) {
            this.head = null;
        } else {
            this.tail.previous.next = null;
        }

        this.tail = this.tail.previous;
        deletedNode.previous = null;
        this.count--;

        return deletedNode;
    }

    toArray() {
        const nodes = [];

        let currentNode = this.head;

        while (currentNode != null) {
            nodes.push(currentNode.value);
            currentNode = currentNode.next;
        }

        return nodes;
    }

    toString() {
        const nodes = this.toArray();
        return `DoublyLinkedList [ ${nodes.join(' <-> ')} ]`;
    }
}

module.exports = { DoublyLinkedList };
