require('../../../common/array-extensions');
const { isEmpty, isFunction } = require('../../../common/utils');

const quickSort = function(list) {
    if (isEmpty(list)) {
        return list;
    }

    if (list.length < 2) {
        return list;
    }

    // check of all elements in the list support the 'compareTo' function
    // this value is used to determine the appropriate comparison strategy
    const allItemsComparable = list.reduce(
        (acc, item) => (acc &= isFunction(item.compareTo)),
        true
    );

    sort(list, 0, list.length, allItemsComparable);

    return list;
};

const sort = (list, start, end, allItemsComparable) => {
    if (end - start < 2) {
        return;
    }

    let pivot = partition(list, start, end, allItemsComparable);
    sort(list, start, pivot, allItemsComparable);
    sort(list, pivot + 1, end, allItemsComparable);
};

const partition = (list, start, end, allItemsComparable) => {
    let pivot = list[start];
    let left = start;
    let right = end;

    while (left < right) {
        if (allItemsComparable) {
            while (left < right && list[--right].compareTo(pivot) >= 0) {}
        } else {
            while (left < right && list[--right] >= pivot) {}
        }

        if (left < right) {
            list[left] = list[right];
        }

        if (allItemsComparable) {
            while (left < right && list[++left].compareTo(pivot) <= 0) {}
        } else {
            while (left < right && list[++left] <= pivot) {}
        }

        if (left < right) {
            list[right] = list[left];
        }
    }

    list[right] = pivot;

    return right;
};

module.exports = { quickSort };
