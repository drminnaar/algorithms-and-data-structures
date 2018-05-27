# Algorithms and Data Structures

This project is a compilation of various algorithms and data structures that have been implemented using different programming lanaguages.

---

## Overview

The whole idea of list project is to re-visit the fundamentals of computer programming. However, what makes list project perhaps a little different is that these fundamentals will be explored using different programming languages. By exploring the funamentals using different programming languages (and paradigms), the aim is to develop an aptitude to think differently about solving problems.

---

## Projects By Programming Language

* [C# Algorithms and Data Structures]
* [Javascript algorithms and data structures]

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

public void Sort(int[] list)
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

function sort(list) {
    for (
        let lastUnsortedIndex = list.length - 1;
        lastUnsortedIndex > 0;
        lastUnsortedIndex--
    ) {
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
}
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

public void Sort(int[] list)
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

#### Insertion Sort

An _Insertion Sort_ algorithm is a comparison based sorting algorithm where a list is divided into two parts (sorted and unsorted). The list is repeatedly sorted by growing the sorted partition from the left until only the sorted parition remains. It's sort of like being dealt a card from a randomly arranged deck of cards. For each card that is dealt, you take that card and insert it into a sorted position in the cards that you hold. The deck of randomly arranged cards represents the unsorted partition whereas the cards that are held by you represent the sorted partition.

The way _Insertion Sort_ works is as follows:

* It starts out with position 0 representing the sorted partition
* Position 1 represents the first element of the unsorted partition
* For each pass of the algorithm, the first unsorted element of the unsorted partition is compared with each element in the sorted parition until it can be inserted into it's sorted position. This process continues until there are no more elements left in the unsorted partition and all that is left is the sorted parition.

For example:

We start off with an unsorted list of characters ([d, c, b, a]) as follows:

position | 0 | 1 | 2 | 3
--- | --- | --- | --- | ---
elements | d | c | b | a

```javascript
First pass:

Sorted Parition = [ d ]
Unsorted Partition = [ c, b, a ]
key = element at position 1 = c

k <= d  then  list[1] = d  and  list[0] = c
```

After the first pass, our list looks as follows:

position |0 | 1 | 2 | 3
--- |--- | --- | --- | ---
elements |c | d | b | a

```javascript
Second pass:

Sorted Parition = [ c, d ]
Unsorted Partition = [ b, a ]
key = element at position 2 = b

k <= d  then  list[2] = d  and  list[1] = b
k <= c  then  list[1] = c  and  list[0] = b
```

After the second pass, our list looks as follows:

position |0 | 1 | 2 | 3
--- |--- | --- | --- | ---
elements |b | c | d | a

```javascript
Third pass:

Sorted Parition = [ b, c, d ]
Unsorted Partition = [ a ]
key = element at position 3 = a

k <= d  then  list[3] = d  and  list[2] = a
k <= c  then  list[2] = c  and  list[1] = a
k <= b  then  list[1] = b  and  list[0] = a
```

After the third pass, our list looks as follows:

position |0 | 1 | 2 | 3
--- |--- | --- | --- | ---
elements |a |b | c | d

##### Time and Complexity

* Worst Case Time Complexity [ Big-O ]: O(n<sup>2</sup>)
* Best Case Time Complexity [Big-omega]: O(n)
* Average Time Complexity [Big-theta]: O(n<sup>2</sup>)
* Space Complexity: O(1)

##### Code

[C# Example](https://github.com/drminnaar/algorithms-and-data-structures/blob/master/csharp-ads/src/ADS.Algorithms/Sorting/InsertionSort.cs)

```csharp
public void Sort(int[] list)
{
    var k = 0;
    var i = 0;

    for (var firstUnsortedIndex = 1; firstUnsortedIndex < list.Length; firstUnsortedIndex++)
    {
        k = list[firstUnsortedIndex];
        i = firstUnsortedIndex - 1;

        while (i >= 0 && k < list[i])
        {
            // swap
            var temp = list[i + 1];
            list[i + 1] = list[i];
            list[i] = temp;

            i--;
        }
    }

}
```

---

## Authors

* **Douglas Minnaar** - _Initial work_ - [drminnaar](https://github.com/drminnaar)

---

[C# algorithms and data structures]: https://github.com/drminnaar/algorithms-and-data-structures/tree/master/csharp-ads
[Javascript algorithms and data structures]: https://github.com/drminnaar/algorithms-and-data-structures/tree/master/javascript-ads