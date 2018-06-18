class Node {
    constructor(value) {
        this.value = value;
        this.next = null;
    }

    toString() {
        return this.value.toString();
    }
}

module.exports = { Node };
