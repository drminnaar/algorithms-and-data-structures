require('../../../common/array-extensions');
const { isEmpty, isFunction } = require('../../../common/utils');

const shellSort = function(list) {
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

    let i = 0;
    let j = 0;
    let key = 0;

    for (let gap = Math.floor(list.length / 2); gap > 0; gap = Math.floor(gap / 2)) {
        for (i = gap; i < list.length; i++) {
            key = list[i];
            j = i;

            if (allItemsComparable) {
                while (j >= gap && key.compareTo(list[j - gap]) < 0) {
                    list.swap(j, j - gap);
                    j -= gap;
                }
            } else {
                while (j >= gap && key < list[j - gap]) {
                    list.swap(j, j - gap);
                    j -= gap;
                }
            }
        }
    }

    return list;
};

module.exports = { shellSort };
