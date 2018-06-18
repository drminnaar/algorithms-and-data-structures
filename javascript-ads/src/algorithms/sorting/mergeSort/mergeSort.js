require('../../../common/array-extensions');
const { isEmpty, isFunction } = require('../../../common/utils');

const mergeSort = function(list) {
    if (isEmpty(list)) {
        return list;
    }

    if (list.length < 2) {
        return list;
    }

    sort(list, [], 0, list.length - 1);

    return list;
};

function sort(list, tempList, leftStart, rightEnd) {
    // this check is a small optimization that returns
    // early to prevent unecessary processing
    if (leftStart >= rightEnd) {
        return;
    }

    // calculate the middle of array so as to determine
    // the left and right arrays
    var middle = Math.floor((leftStart + rightEnd) / 2);

    // sort left array
    sort(list, tempList, leftStart, middle);

    // sort right array
    sort(list, tempList, middle + 1, rightEnd);

    // merge halves (left and right)
    merge(list, tempList, leftStart, rightEnd);
}

function merge(list, tempList, leftStart, rightEnd) {
    var leftEnd = Math.floor((leftStart + rightEnd) / 2);
    var rightStart = leftEnd + 1;
    var size = rightEnd - leftStart + 1;

    var leftIndex = leftStart;
    var rightIndex = rightStart;
    var tempIndex = leftStart;

    // check of all elements in the list support the 'compareTo' function
    // this value is used to determine the appropriate comparison strategy
    const allItemsComparable = list.reduce(
        (acc, item) => (acc &= isFunction(item.compareTo)),
        true
    );

    while (leftIndex <= leftEnd && rightIndex <= rightEnd) {
        if (allItemsComparable) {
            // this is used to compare complex types that
            // have a 'compareTo' function
            tempList[tempIndex++] =
                list[leftIndex].compareTo(list[rightIndex]) < 0
                    ? list[leftIndex++]
                    : list[rightIndex++];
        } else {
            // this is the default comparison that is acceptable for value types
            tempList[tempIndex++] =
                list[leftIndex] < list[rightIndex] ? list[leftIndex++] : list[rightIndex++];
        }
    }

    // copy remaining elements from left array into temp array
    list.copy(leftIndex, tempList, tempIndex, leftEnd - leftIndex + 1);

    // copy remaining elements from right array into temp array
    list.copy(rightIndex, tempList, tempIndex, rightEnd - rightIndex + 1);

    // copy temporary list to original list
    tempList.copy(leftStart, list, leftStart, size);
}

module.exports = { mergeSort };
