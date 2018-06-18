require('../../../common/array-extensions');
const { isEmpty, isFunction } = require('../../../common/utils');

const bubbleSort = function(list) {
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

    for (let lastUnsortedIndex = list.length - 1; lastUnsortedIndex > 0; lastUnsortedIndex--) {
        for (let i = 0; i < lastUnsortedIndex; i++) {
            if (allItemsComparable) {
                if (list[i].compareTo(list[i + 1]) > 0) {
                    list.swap(i, i + 1);
                }
            } else {
                if (list[i] > list[i + 1]) {
                    list.swap(i, i + 1);
                }
            }
        }
    }

    return list;
};

module.exports = { bubbleSort };
