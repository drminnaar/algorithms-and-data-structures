# Algorithms and Data Structures

list project is a compilation of various algorithms and data structures that have been implemented using different programming lanaguages.

---

## Overview

The whole idea of list project is to re-visit the fundamentals of computer programming. However, what makes list project perhaps a little different is that these fundamentals will be explored using different programming languages. By exploring the funamentals using different programming languages (and paradigms), the aim is to develop an aptitude to think differently about solving problems.

---

## Projects By Programming Language

*   [C# Algorithms and Data Structures]

---

## Algorithms

### Sorting

#### Bubble Sort

A _Bubble Sort_ algorithm is a comparison based sorting algorithm that sorts a list of items by repeatedly comparing and swapping adjacent elements until all elements in the list are sorted in ascending order. Because the elements with the largest values are "bubbled" to the end of the list (from left to right), the sorted partition is growing from right to left.

It is Big-O (n<sup>2</sup>) in terms of time complexity, where n is the number of items.

Example:

```javascript
First Pass:

[5, 1, 4, 3, 2] -> [1, 5, 4, 3, 2] | 5 > 1 ? swap
[1, 5, 4, 3, 2] -> [1, 4, 5, 3, 2] | 5 > 4 ? swap
[1, 4, 5, 3, 2] -> [1, 4, 3, 5, 2] | 5 > 3 ? swap
[1, 4, 3, 5, 2] -> [1, 4, 3, 2, 5] | 5 > 2 ? swap
```

```javascript
Second Pass:

[1, 4, 3, 2, 5] -> [1, 4, 3, 2, 5] | 1 < 4 ? continue
[1, 4, 3, 2, 5] -> [1, 3, 4, 2, 5] | 4 > 3 ? swap
[1, 3, 4, 2, 5] -> [1, 3, 2, 4, 5] | 4 > 2 ? swap
[1, 3, 2, 4, 5] -> [1, 3, 2, 4, 5] | 4 < 5 ? continue
```

```javascript
Third Pass:

[1, 3, 2, 4, 5] -> [1, 3, 2, 4, 5] | 1 < 3 ? continue
[1, 3, 2, 4, 5] -> [1, 2, 3, 4, 5] | 3 > 2 ? swap
[1, 2, 3, 4, 5] -> [1, 2, 3, 4, 5] | 3 < 4 ? continue
[1, 2, 3, 4, 5] -> [1, 2, 3, 4, 5] | 4 < 5 ? continue
```

##### Code

[C# Example](https://github.com/drminnaar/algorithms-and-data-structures/blob/master/csharp-ads/src/ADS.Algorithms/Sorting/BubbleSort.cs)

```csharp
C#

private void Sort(int[] list)
{
    for (int lastUnsortedIndex = list.Length - 1; lastUnsortedIndex > 0; lastUnsortedIndex--)
    {
        for(int i = 0; i < lastUnsortedIndex; i++)
        {
            if (list[i] > list[i + 1])
            {
                // swap
                var temp = list[i + 1];
                list[i + 1] = list[i];
                list[i] = temp;
            }
        }
    }
}
```

[Javascript Example](https://github.com/drminnaar/algorithms-and-data-structures/blob/master/javascript-ads/src/sorting/bubbleSort/bubbleSort.js)

```javascript
Javascript

function(list) {

    for (let lastUnsortedIndex = list.length - 1; lastUnsortedIndex > 0; lastUnsortedIndex--) {
        for (let i = 0; i < lastUnsortedIndex; i++) {
            if (list[i] > list[i + 1]) {
                // swap
                const temp = list[rhs];
                list[rhs] = list[lhs];
                list[lhs] = temp;
            }
        }
    }

    return list;
};
```

#### Selection Sort

A _Selection Sort_ algorithm is a comparison based sorting algorithm where a list is divided into two parts (sorted and unsorted). It sorts a list of items by repeatedly finding the element with the largest value in the unsorted part of list, and placing it at the end in the sorted part of the list through the process of repeatedly swapping. Initially, the entire list is unsorted. However, with each iteration, the sorted part of the list grows whilst the unsorted part of the list shrinks until all that is left is a sorted partition, and hence a sorted list. In other words, the sorted partition grows from right to left with each iteration of the algorithm.

It is Big-O (n<sup>2</sup>) in terms of time complexity, where n is the number of items.

```javascript
First Pass:

- Find index with highest value (5) in unsorted parition, and move to last unsorted index (4)

[5, 1, 4, 3, 2] -> [2, 1, 4, 3, 5]

- Decrement last unsorted index to 3
```

```javascript
Second Pass:

- Find index with highest value (4) in unsorted partition, and move to last unsorted index (3)

[2, 1, 4, 3, 5] -> [2, 1, 3, 4, 5]

- Decrement last unsorted index to 2
```

```javascript
Third Pass:

- Find index with highest value (3) in unsorted partition, and move to last unsorted index (2)

[2, 1, 3, 4, 5] -> [2, 1, 3, 4, 5]

- Decrement last unsorted index to 1
```

```javascript
Fourth Pass:

- Find index with highest value (2) in unsorted partition, and move to last unsorted index (1)

[2, 1, 3, 4, 5] -> [1, 2, 3, 4, 5]

- Decrement last unsorted index to 0
```

##### Code

[C# Example](https://github.com/drminnaar/algorithms-and-data-structures/blob/master/csharp-ads/src/ADS.Algorithms/Sorting/SelectionSort.cs)

```csharp
C#

private void Sort(int[] list)
{
    var maxValueIndex = 0;

    for (int lastUnsortedIndex = (list.Length - 1); lastUnsortedIndex > 0; lastUnsortedIndex--)
    {
        maxValueIndex = lastUnsortedIndex;

        for (int i = 0; i <= lastUnsortedIndex; i++)
        {
            if (list[i] > list[maxValueIndex])
            {
                maxValueIndex = i;
            }
        }

        // swap
        var temp = list[lastUnsortedIndex];
        list[lastUnsortedIndex] = list[maxValueIndex];
        list[maxValueIndex] = temp;
    }
}
```

---

## Authors

*   **Douglas Minnaar** - _Initial work_ - [drminnaar](https://github.com/drminnaar)

---

[c# algorithms and data structures]: https://github.com/drminnaar/algorithms-and-data-structures/tree/master/csharp-ads
