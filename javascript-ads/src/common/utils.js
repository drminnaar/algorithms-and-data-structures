const isEmpty = function(value) {
    value === undefined ||
        value === null ||
        (typeof value === 'object' && Object.keys(value).length === 0) ||
        (typeof value === 'string' && value.length === 0);
};

const isFunction = function(fn) {
    if (typeof fn === 'undefined') {
        return false;
    }

    if (typeof fn !== 'function') {
        return false;
    }

    return true;
};

module.exports = { isEmpty, isFunction };
