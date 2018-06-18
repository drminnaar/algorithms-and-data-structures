require('../../../common/array-extensions');
const { isEmpty, isFunction } = require('../../../common/utils');

const selectionSort = function(list) {
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

    let maxValueIndex = 0;

    for (let lastUnsortedIndex = list.length - 1; lastUnsortedIndex > 0; lastUnsortedIndex--) {
        maxValueIndex = lastUnsortedIndex;

        for (let i = 0; i <= lastUnsortedIndex; i++) {
            if (allItemsComparable) {
                if (list[i].compareTo(list[maxValueIndex]) > 0) {
                    maxValueIndex = i;
                }
            } else {
                if (list[i] > list[maxValueIndex]) {
                    maxValueIndex = i;
                }
            }
        }

        list.swap(maxValueIndex, lastUnsortedIndex);
    }

    return list;
};

module.exports = { selectionSort };
