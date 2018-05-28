Array.prototype.swap = function(lhs, rhs) {
    if (lhs === rhs) {
        return;
    }

    const temp = this[rhs];
    this[rhs] = this[lhs];
    this[lhs] = temp;
};
