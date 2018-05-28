require('../../common/array-extensions');
const { isEmpty, isFunction } = require('../../common/utils');

const insertionSort = function(list) {
    if (isEmpty(list)) {
        return list;
    }

    if (list.length < 2) {
        return list;
    }

    const allItemsComparable = list.reduce(
        (acc, item) => (acc &= isFunction(item.compareTo)),
        true
    );

    let key = 0;
    let i = 0;

    for (let firstUnsortedIndex = 1; firstUnsortedIndex < list.length; firstUnsortedIndex++) {
        key = list[firstUnsortedIndex];
        i = firstUnsortedIndex - 1;

        if (allItemsComparable) {
            while (i >= 0 && key.compareTo(list[i]) < 0) {
                list.swap(i, i + 1);
                i--;
            }
        } else {
            while (i >= 0 && key < list[i]) {
                list.swap(i, i + 1);
                i--;
            }
        }
    }

    return list;
};

module.exports = { insertionSort };
