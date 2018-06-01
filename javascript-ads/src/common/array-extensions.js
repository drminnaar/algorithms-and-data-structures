Array.prototype.swap = function(lhs, rhs) {
    if (lhs === rhs) {
        return;
    }

    const temp = this[rhs];
    this[rhs] = this[lhs];
    this[lhs] = temp;
};

Array.prototype.copy = function(sourceIndex, destination, destinationIndex, length) {
    while (length !== 0) {
        destination[destinationIndex++] = this[sourceIndex++];
        length--;
    }
};
