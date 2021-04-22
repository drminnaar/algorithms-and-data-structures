![cover](https://repository-images.githubusercontent.com/134303710/eb049280-a362-11eb-86d1-bb0c08ef19e4)

# Algorithms and Data Structures

This project is a compilation of various algorithms and data structures that have been implemented using *C#* and *Javascript*.

---

## Overview

The idea behind this project is to re-visit the fundamentals of computer programming. These fundamentals will be explored using 2 of my favourite programming languages, namely *C#* and *Javascript*. The primary aim is to develop an aptitude to think differently about solving problems. Also, by understanding these fundamentals, one can begin to think about solving problems more efficiently.

---

## Projects By Programming Language

* [C# Algorithms and Data Structures]

* [Javascript algorithms and data structures]

---

## Contents

* [Algorithms](#algorithms)
  * [Sorting Algorithms](#sorting-algorithms)
    * [Bubble Sort](#bubble-sort)
    * [Selection Sort](#selection-sort)
    * [Insertion Sort](#insertion-sort)
    * [Shell Sort](#shell-sort)
    * [Merge Sort](#merge-sort)
    * [Quick Sort](#quick-sort)

* [Data Structures](#data-structures)
  * [Singly Linked List](#singly-linked-list)
  * [Doubly Linked List](#doubly-linked-list)

---

## Algorithms

### Sorting Algorithms

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

##### Bubble Sort Examples

[Bubble Sort with Hungarian ("Csángó") folk dance](http://www.youtube.com/watch?v=lyZQPjUT5B4)

[![Bubble Sort with Hungarian (Csango) folk dance](http://img.youtube.com/vi/lyZQPjUT5B4/0.jpg)](http://www.youtube.com/watch?v=lyZQPjUT5B4 "Bubble Sort with Hungarian (Csango) folk dance")

##### Bubble Sort Code

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

[Javascript Example](https://github.com/drminnaar/algorithms-and-data-structures/blob/master/javascript-ads/src/algorithms/sorting/bubbleSort/bubbleSort.js)

```javascript
Javascript

function sort(list) {
    for (let lastUnsortedIndex = list.length - 1; lastUnsortedIndex > 0; lastUnsortedIndex--) {
        for (let i = 0; i < lastUnsortedIndex; i++) {
            if (list[i] > list[i + 1]) {
                // swap
                const temp = list[i + 1];
                list[i + 1] = list[i];
                list[i] = temp;
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

##### Selection Sort Examples

[Select Sort with Gypsy folk dance](http://www.youtube.com/watch?v=Ns4TPTC8whw )

[![Select Sort with Gypsy folk dance](http://img.youtube.com/vi/Ns4TPTC8whw/0.jpg)](http://www.youtube.com/watch?v=Ns4TPTC8whw "Select Sort with Gypsy folk dance")

##### Selection Sort Code

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

[Javascript Example](https://github.com/drminnaar/algorithms-and-data-structures/blob/master/javascript-ads/src/algorithms/sorting/selectionSort/selectionSort.js)

```javascript
Javascript

function sort(list) {
    let maxValueIndex = 0;

    for (let lastUnsortedIndex = (list.length - 1); lastUnsortedIndex > 0; lastUnsortedIndex--) {
        maxValueIndex = lastUnsortedIndex;

        for (let i = 0; i <= lastUnsortedIndex; i++) {
            if (list[i] > list[maxValueIndex]) {
                maxValueIndex = i;
            }
        }

        // swap
        const temp = list[lastUnsortedIndex];
        list[lastUnsortedIndex] = list[maxValueIndex];
        list[maxValueIndex] = temp;
    }

    return list;
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

##### Insertion Sort Examples

[Insertion Sort with Romanian folk dance](http://www.youtube.com/watch?v=ROalU379l3U)

[![Insertion Sort with Romanian folk dance](http://img.youtube.com/vi/ROalU379l3U/0.jpg)](http://www.youtube.com/watch?v=ROalU379l3U "Insertion Sort with Romanian folk dance")

##### Insertion Sort Time and Complexity

* Worst Case Time Complexity [ Big-O ]: O(n<sup>2</sup>)
* Best Case Time Complexity [Big-omega]: O(n)
* Average Time Complexity [Big-theta]: O(n<sup>2</sup>)
* Space Complexity: O(1)

##### Insertion Sort Code

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

[Javascript Example](https://github.com/drminnaar/algorithms-and-data-structures/blob/master/javascript-ads/src/algorithms/sorting/insertionSort/insertionSort.js)

```javascript
Javascript

function sort(list) {
    let key = 0;
    let i = 0;

    for (let firstUnsortedIndex = 1; firstUnsortedIndex < list.length; firstUnsortedIndex++) {
        key = list[firstUnsortedIndex];
        i = firstUnsortedIndex - 1;

        while (i >= 0 && key < list[i]) {
            // swap
            const temp = list[i + 1];
            list[i + 1] = list[i];
            list[i] = temp;

            i--;
        }
    }

    return list;
}
```

#### Shell Sort

In my explanation of an _Insertion Sort_ algorithm, I use the analogy of a dealer dealing out cards from an unsorted deck of cards where one takes each card and inserts it in it's appropriate position based on rank. The same analogy can be used to explain _Shell Sort_. Except now imagine that the dealer took his deck of cards and partially sorted it so that all the cards having the lowest values are on one side of the deck, and the cards having the largest values are on the opposite side of the deck. Therefore, when one is dealt a card, it is coming from a partially sorted deck of cards.

Therefore, a _Shell Sort_ algorithm can be summarised as follows:

* It's a variation of the _Insertion Sort_ algorithm
* Therefore, _Shell Sort_ is a also comparison based sorting algorithm. However, unlike _Insertion Sort_, it is not a stable sorting algorithm.
* Due to the introduction of a _gap_ value, elements that are distant from each other (based on gap) are compared to each other as opposed to adjacent elements.
* Once the _Shell Sort_ algorithm reaches a _gap_ value of 1, it is equivalent to an _Insertion Sort_.
* The reason for introducing a _gap_ value that is greater than 1, is to reduce the number of _shifting_ that occurs in a standard _Insertion Sort_ algorithm. Therefore, by the time the _Shell Sort_ algorithm reaches a value of 1, it is partially sorted.

The way _Shell Sort_ works is as follows:

* Where _Insertion Sort_ chooses an element to insert using a _gap_ of 1, _Shell Sort_ starts out using a larger _gap_.
* The _gap_ value is determined based on a _"strategy"_ that helps calculate a value that provides the lowest time complexity. A common _strategy_ that is used in many _Shell Sort_ algorithm examples, is to calculate the _gap_ value by initially dividing the list length by 2. Then with each pass, the _gap_ value is divided by 2 until the _gap_ is 1
* Once a _gap_ value of 1 is reached, the sort algorithm is equivalent to an _Insertion Sort_ algorithm.

##### Shell Sort Examples

[Shell Sort with Hungarian (Székely) folk dance](http://www.youtube.com/watch?v=CmPA7zE8mx0)

[![Shell Sort with Hungarian (Székely) folk dance](http://img.youtube.com/vi/CmPA7zE8mx0/0.jpg)](http://www.youtube.com/watch?v=CmPA7zE8mx0 "Shell Sort with Hungarian (Székely) folk dance")

##### Shell Sort Time and Complexity

* Worst Case Time Complexity [ Big-O ]: O(n<sup>2</sup>)
* Best Case Time Complexity [Big-omega]: O(n(log(n))<sup>2</sup>)
* Average Time Complexity [Big-theta]: O(n(log(n))<sup>2</sup>)
* Space Complexity: O(1)

##### Shell Sort Code

[C# Example](https://github.com/drminnaar/algorithms-and-data-structures/blob/master/csharp-ads/src/ADS.Algorithms/Sorting/ShellSort.cs)

```csharp
public void Sort(int[] list)
{
    var i = 0;
    var j = 0;
    var key = 0;

    for (int gap = list.Length / 2; gap > 0; gap /= 2)
    {
        for (i = gap; i < list.Length; i++)
        {
            key = list[i];
            j = i;

            while (j >= gap && key < list[j - gap])
            {
                // swap
                var temp = list[j - gap];
                list[j - gap] = list[j];
                list[j] = temp;

                j -= gap;
            }
        }
    }
}
```

[Javascript Example](https://github.com/drminnaar/algorithms-and-data-structures/blob/master/javascript-ads/src/algorithms/sorting/shellSort/shellSort.js)

```javascript
Javascript

function sort(list) {
    let i = 0;
    let j = 0;
    let key = 0;

    for (let gap = list.length / 2; gap > 0; gap /= 2)
    {
        for (i = gap; i < list.length; i++)
        {
            key = list[i];
            j = i;

            while (j >= gap && key < list[j - gap])
            {
                // swap
                var temp = list[j - gap];
                list[j - gap] = list[j];
                list[j] = temp;

                j -= gap;
            }
        }
    }

    return list;
}
```

#### Merge Sort

The _Merge Sort_ algorithm is a comparison based sorting algorithm that can be summarised as follows:

* It is a divide and conquer algorithm
* Typically implemented as a recursive algorithm
* Primary made up of 2 phases namely a splitting and merging phase

The _Merge Sort_ algorithm repeatedly splits a list unti all that remains is a collection of 1 element lists. A 1 element list is sorted due to there only being 1 element. Next, the _Merge Sort_ algorithm repeatedly merges all the sub-lists until all that remains is the sorted list.

##### Merge Sort Examples

[Merge Sort Algorithm. (n.d). In Wikipedia](https://en.wikipedia.org/wiki/File:Merge-sort-example-300px.gif)

![Merge Sort Algorithm. (n.d). In Wikipedia](https://upload.wikimedia.org/wikipedia/commons/c/cc/Merge-sort-example-300px.gif)

[Merge Sort With Transylvanian-saxon (German) Folk Dance](http://www.youtube.com/watch?v=XaqR3G_NVoo)

[![Merge Sort with Transylvanian-saxon (German) folk dance](http://img.youtube.com/vi/XaqR3G_NVoo/0.jpg)](http://www.youtube.com/watch?v=XaqR3G_NVoo "Merge Sort with Transylvanian-saxon (German) folk dance")

##### Merge Sort Time and Complexity

* Worst Case Time Complexity [ Big-O ]: O(n log n)
* Best Case Time Complexity [Big-omega]: O(n log n)
* Average Time Complexity [Big-theta]: O(n log n)
* Space Complexity: O(n)

##### Merge Sort Code

[C# Example](https://github.com/drminnaar/algorithms-and-data-structures/blob/master/csharp-ads/src/ADS.Algorithms/Sorting/MergeSort.cs)

```csharp
C#

public void Sort(int[] list)
{
    MergeSort(list, new int[list.Length], 0, list.Length - 1);
}

private void MergeSort(int[] list, int[] tempList, int leftStart, int rightEnd)
{
    if (leftStart >= rightEnd)
        return;

    var middleIndex = (leftStart + rightEnd) / 2;
    MergeSort(list, tempList, leftStart, middleIndex);
    MergeSort(list, tempList, middleIndex + 1, rightEnd);
    Merge(list, tempList, leftStart, rightEnd);
}

private void Merge(int[] list, int[] tempList, int leftStart, int rightEnd)
{
    var leftEnd = (leftStart + rightEnd) / 2;
    var rightStart = leftEnd + 1;
    var size = rightEnd - leftStart + 1;

    var leftIndex = leftStart;
    var rightIndex = rightStart;
    var tempIndex = leftStart;

    while (leftIndex <= leftEnd && rightIndex <= rightEnd)
    {
        tempList[tempIndex++] = list[leftIndex] < list[rightIndex]
            ? list[leftIndex++]
            : list[rightIndex++];
    }

    Array.Copy(list, leftIndex, tempList, tempIndex, leftEnd - leftIndex + 1);
    Array.Copy(list, rightIndex, tempList, tempIndex, rightEnd - rightIndex + 1);
    Array.Copy(tempList, leftStart, list, leftStart, size);
}
```

[Javascript Example](https://github.com/drminnaar/algorithms-and-data-structures/blob/master/javascript-ads/src/algorithms/sorting/mergeSort/mergeSort.js)

```javascript
Javascript

function sort(list) {

    mergeSort(list, [], 0, list.length - 1);

    return list;
};

function mergeSort(list, tempList, leftStart, rightEnd) {

    if (leftStart >= rightEnd) {
        return;
    }

    var middle = Math.floor((leftStart + rightEnd) / 2);

    mergeSort(list, tempList, leftStart, middle);
    mergeSort(list, tempList, middle + 1, rightEnd);
    merge(list, tempList, leftStart, rightEnd);
}

function merge(list, tempList, leftStart, rightEnd) {

    var leftEnd = Math.floor((leftStart + rightEnd) / 2);
    var rightStart = leftEnd + 1;
    var size = rightEnd - leftStart + 1;

    var leftIndex = leftStart;
    var rightIndex = rightStart;
    var tempIndex = leftStart;

    while (leftIndex <= leftEnd && rightIndex <= rightEnd) {
        tempList[tempIndex++] = list[leftIndex] < list[rightIndex]
            ? list[leftIndex++]
            : list[rightIndex++];
    }

    list.copy(leftIndex, tempList, tempIndex, leftEnd - leftIndex + 1);
    list.copy(rightIndex, tempList, tempIndex, rightEnd - rightIndex + 1);
    tempList.copy(leftStart, list, leftStart, size);
}

Array.prototype.copy = function(sourceIndex, destination, destinationIndex, length) {
    while (length !== 0) {
        destination[destinationIndex++] = this[sourceIndex++];
        length--;
    }
};
```

#### Quick Sort

The _Quick Sort_ algorithm is an in-place and comparison based sorting algorithm that can be summarised as follows:

* It is a divide and conquer algorithm
* Typically implemented as a recursive algorithm
* Partitions the list into 2 parts by establishing a pivot
  * A pivot may be determined using different techniques
  * Elements less than pivot are moved to the left of pivot
  * Elements greater than pivot are moved to the right of pivot
  * At this point the pivot is in it's correct sorted position
* The paritioning process is repeated for the left subarray (array that is left of pivot) and right subarray (array that is right og pivot) until the list is sorted.

##### Quick Sort Examples

[Merge Sort With Transylvanian-saxon (German) Folk Dance](https://www.youtube.com/watch?v=ywWBy6J5gz8)

[![Quick sort with Hungarian folk dance](http://img.youtube.com/vi/ywWBy6J5gz8/0.jpg)](http://www.youtube.com/watch?v=ywWBy6J5gz8 "Quick sort with Hungarian folk dance")

##### Quick Sort Time and Complexity

* Worst Case Time Complexity [ Big-O ]: O(n<sup>2</sup>)
* Best Case Time Complexity [Big-omega]: O(n log n)
* Average Time Complexity [Big-theta]: O(n log n)
* Space Complexity: O(n log n)

##### Quick Sort Code

[C# Example](https://github.com/drminnaar/algorithms-and-data-structures/blob/master/csharp-ads/src/ADS.Algorithms/Sorting/QuickSort.cs)

```csharp
C#

protected override void QickSort(T[] list)
{
    QickSort(list, 0, list.Length);
}

private void QickSort(T[] list, int start, int end)
{
    if (end - start < 2)
        return;

    var pivotIndex = Partition(list, start, end);
    QickSort(list, start, pivotIndex);
    QickSort(list, pivotIndex + 1, end);
}

private int Partition(T[] list, int start, int end)
{
    var pivot = list[start];
    var left = start;
    var right = end;

    while (left < right)
    {
        while (left < right && list[--right] >= pivot) { }

        if (left < right)
            list[left] = list[right];

        while (left < right && list[++left] <= pivot) { }

        if (left < right)
            list[right] = list[left];
    }

    list[right] = pivot;

    return right;
}
```

[Javascript Example](https://github.com/drminnaar/algorithms-and-data-structures/blob/master/javascript-ads/src/algorithms/sorting/quickSort/quickSort.js)

```javascript
Javascript

const quickSort = function(list) {

    sort(list, 0, list.length);

    return list;
};

const sort = (list, start, end) => {
    if (end - start < 2) {
        return;
    }

    let pivot = partition(list, start, end);
    sort(list, start, pivot);
    sort(list, pivot + 1, end);
};

const partition = (list, start, end) => {
    let pivot = list[start];
    let left = start;
    let right = end;

    while (left < right) {

        while (left < right && list[--right] >= pivot) {}

        if (left < right) {
            list[left] = list[right];
        }

        while (left < right && list[++left] <= pivot) {}

        if (left < right) {
            list[right] = list[left];
        }
    }

    list[right] = pivot;

    return right;
};
```

---

## Data Structures

### Singly Linked List

* A _Singly Linked List_ is a data structure that represents a sequential list of _nodes_.
* Each _node_ in the list contains a value and a pointer to the next _node_ that forms part of list.
* The first _node_ is called the _Head_

The following diagram illustrates a list of nodes, with each node consisting of a card as it's value and a _'Next'_ pointer to the next node in the list.

![singly-linked-list](https://user-images.githubusercontent.com/33935506/41312381-31ea502c-6e87-11e8-97c8-071247623692.png)

#### Examples

[C# Example](https://github.com/drminnaar/algorithms-and-data-structures/blob/master/csharp-ads/src/ADS.DataStructures/SinglyLinkedList/SinglyLinkedList.cs)

```csharp
C#

public sealed class SinglyLinkedList<T> where T : class
{
    public long Count { get; private set; }

    public Node<T> Head { get; private set; }

    public void AddFront(T value)
    {
        var node = new Node<T>(value);
        node.Next = Head;

        Head = node;

        Count++;
    }

    public Node<T> RemoveFront()
    {
        if (Head == null)
        {
            return null;
        }

        var removedNode = Head;
        Head = removedNode.Next;
        removedNode.Next = null;
        Count--;

        return removedNode;
    }
}

public sealed class Node<T> where T : class
{
    public Node(T value)
    {
        Value = value;
    }

    public T Value { get; private set; }

    public Node<T> Next { get; set; }
}

```

[Javascript Example](https://github.com/drminnaar/algorithms-and-data-structures/blob/master/javascript-ads/src/data-structures/singly-linked-list/SinglyLinkedList.js)

```javascript
Javascript

class Node {
    constructor(value) {
        this.value = value;
        this.next = null;
    }

    toString() {
        return this.value.toString();
    }
}

class SinglyLinkedList {

    constructor() {
        this.head = null;
        this.count = 0;
    }

    any() {
        return this.head !== null;
    }

    addFront(value) {
        const node = new Node(value);
        node.next = this.head;

        this.head = node;

        this.count++;
    }

    removeFront() {
        if (!this.any()) {
            return null;
        }

        const removedNode = this.head;
        this.head = removedNode.next;
        removedNode.next = null;

        this.count--;

        return removedNode;
    }

    toArray() {
        const nodes = [];

        let currentNode = this.head;

        while (currentNode != null) {
            nodes.push(currentNode.value);
            currentNode = currentNode.next;
        }

        return nodes;
    }

    toString() {
        const nodes = this.toArray();
        return `SinglyLinkedList [ ${nodes.join(' -> ')} ]`;
    }
}

```

### Doubly Linked List

* A _Doubly Linked List_ is a data structure that represents a sequential list of _nodes_.
* Each _node_ in the list contains a value and pointers to the next and previous _nodes_ that forms part of list.
* The first _node_ is called the _Head_
* The last node is called the _Tail_

The following diagram illustrates a list of nodes, with each node consisting of a card as it's value, a _'Next'_ pointer to the next node in the list, a _'Previous'_ pointer to the previous node in the list.

![doubly-linked-list](https://user-images.githubusercontent.com/33935506/42072606-ad9a8fc0-7b61-11e8-9241-59037648ba31.png)

#### Examples

[C# Example](https://github.com/drminnaar/algorithms-and-data-structures/blob/master/csharp-ads/src/ADS.DataStructures/DoublyLinkedList/DoublyLinkedList.cs)

```csharp
C#

public sealed class DoublyLinkedList<T> where T : class
{
    public long Count { get; private set; }

    public Node<T> Head { get; private set; }

    public Node<T> Tail { get; private set; }

    public bool Any()
    {
        return Head != null;
    }

    public void AddFront(T value)
    {
        var node = new Node<T>(value);
        node.Next = Head;

        if (Head == null)
        {
            Tail = node;
        }
        else
        {
            Head.Previous = node;
        }

        Head = node;
        Count++;
    }

    public void AddEnd(T value)
    {
        var node = new Node<T>(value);

        if (Tail == null)
        {
            Head = node;
        }
        else
        {
            Tail.Next = node;
            node.Previous = Tail;
        }

        Tail = node;
        Count++;
    }

    public Node<T> RemoveFront()
    {
        if (Head == null) return null;

        var removedNode = Head;

        if (Head.Next == null)
            Tail = null;
        else
            Head.Next.Previous = null;

        Head = Head.Next;
        removedNode.Next = null;
        Count--;

        return removedNode;
    }

    public Node<T> RemoveEnd()
    {
        if (Head == null) return null;

        var removedNode = Tail;

        if (Tail.Previous == null)
            Head = null;
        else
            Tail.Previous.Next = null;

        Tail = Tail.Previous;
        removedNode.Previous = null;
        Count--;

        return removedNode;
    }
}

public sealed class Node<T> where T : class
{
    public Node(T value)
    {
        Value = value;
    }

    public T Value { get; private set; }

    public Node<T> Next { get; set; }

    public Node<T> Previous { get; set; }
}

```

[Javascript Example](https://github.com/drminnaar/algorithms-and-data-structures/blob/master/javascript-ads/src/data-structures/doubly-linked-list/DoublyLinkedList.js)

```javascript
Javascript

class Node {
    constructor(value) {
        this.value = value;
        this.next = null;
        this.previous = null;
    }

    toString() {
        return this.value.toString();
    }
}

class DoublyLinkedList {
    constructor() {
        this.head = null;
        this.tail = null;
        this.count = 0;
    }

    any() {
        return this.head !== null;
    }

    addFront(value) {
        const node = new Node(value);
        node.next = this.head;

        if (this.head === null) {
            this.tail = node;
        } else {
            this.head.previous = node;
        }

        this.head = node;
        this.count++;
    }

    addEnd(value) {
        const node = new Node(value);

        if (this.tail === null) {
            this.head = node;
        } else {
            this.tail.next = node;
            node.previous = this.tail;
        }

        this.tail = node;
        this.count++;
    }

    removeFront() {
        if (this.head === null) {
            return null;
        }

        const deletedNode = this.head;

        if (this.head.next == null) {
            this.tail = null;
        } else {
            this.head.next.previous = null;
        }

        this.head = this.head.next;
        deletedNode.next = null;
        this.count--;

        return deletedNode;
    }

    removeEnd() {
        if (this.tail === null) {
            return null;
        }

        const deletedNode = this.tail;

        if (this.tail.previous === null) {
            this.head = null;
        } else {
            this.tail.previous.next = null;
        }

        this.tail = this.tail.previous;
        deletedNode.previous = null;
        this.count--;

        return deletedNode;
    }

    toArray() {
        const nodes = [];

        let currentNode = this.head;

        while (currentNode != null) {
            nodes.push(currentNode.value);
            currentNode = currentNode.next;
        }

        return nodes;
    }

    toString() {
        const nodes = this.toArray();
        return `DoublyLinkedList [ ${nodes.join(' <-> ')} ]`;
    }
}

```

---

## Authors

* **Douglas Minnaar** - _Initial work_ - [drminnaar](https://github.com/drminnaar)

---

[C# algorithms and data structures]: https://github.com/drminnaar/algorithms-and-data-structures/tree/master/csharp-ads
[Javascript algorithms and data structures]: https://github.com/drminnaar/algorithms-and-data-structures/tree/master/javascript-ads