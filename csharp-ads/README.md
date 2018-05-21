# C# Data Structures and Algorithms

This is a repository of various data structures and algorithms that have been implemented in C#.

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

Code

```csharp
private void Sort(int[] list)
{
    for (int lastUnsortedIndex = list.Length - 1; lastUnsortedIndex > 0; lastUnsortedIndex--)
    {
        for(int i = 0; i < lastUnsortedIndex; i++)
        {
            if (list[i] > list[i + 1])
            {
                var temp = list[i + 1];
                list[i + 1] = list[i];
                list[i] = temp;
            }
        }
    }
}
```
