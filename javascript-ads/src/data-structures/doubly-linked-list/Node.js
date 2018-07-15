class Node {
    constructor(value) {
        this.value = value;
        this.next = null;
        this.previous = null;
    }

    toString() {
        return this.value.toString();
    }
}

module.exports = { Node };
