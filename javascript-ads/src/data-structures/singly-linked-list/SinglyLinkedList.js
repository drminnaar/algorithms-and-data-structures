const { Node } = require('./Node');

class SinglyLinkedList {
    constructor() {
        this.head = null;
        this.count = 0;
    }

    any() {
        return this.head !== null;
    }

    addFront(value) {
        const node = new Node(value);
        node.next = this.head;

        this.head = node;

        this.count++;
    }

    removeFront() {
        if (!this.any()) {
            return null;
        }

        const removedNode = this.head;
        this.head = removedNode.next;
        removedNode.next = null;

        this.count--;

        return removedNode;
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
        return `SinglyLinkedList [ ${nodes.join(' -> ')} ]`;
    }
}

module.exports = { SinglyLinkedList };
