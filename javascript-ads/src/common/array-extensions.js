Array.prototype.swap = function(lhs, rhs) {
    const temp = this[rhs];
    this[rhs] = this[lhs];
    this[lhs] = temp;
};
