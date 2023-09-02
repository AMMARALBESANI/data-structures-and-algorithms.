# Understanding Merge Sort: Step-by-Step Visualization

Merge Sort is a popular sorting algorithm known for its efficiency and stability. It follows the divide-and-conquer strategy to sort an array. In this article, we will walk through the Merge Sort algorithm using the provided pseudocode and apply it to the sample input array `[8, 4, 23, 42, 16, 15]`. 


## Visual Representation

Let's apply the Merge Sort algorithm to the sample array `[8, 4, 23, 42, 16, 15]` step by step:

### Step 1: Initial Setup

- The input array is `[8, 4, 23, 42, 16, 15]`.
- `Mergesort` is called with this array.

### Step 2: Splitting the Array

- `n` is 6 (the length of the array), and it's greater than 1.
- Calculate `mid` as 3.
- Create `left` with `[8, 4, 23]` and `right` with `[42, 16, 15]`.

### Step 3: Sorting Left and Right

- Recursively call `Mergesort` on `left`.
  - Split `left` into `[8]` and `[4, 23]`.
  - Merge `[8]` and `[4, 23]` to get `[4, 8, 23]`.

- Recursively call `Mergesort` on `right`.
  - Split `right` into `[42]` and `[15, 16]`.
  - Merge `[42]` and `[15, 16]` to get `[15, 16, 42]`.

### Step 4: Merging Left and Right

- Merge the sorted `left` and `right` to obtain `[4, 8, 15, 16, 23, 42]`.

### Step 5: Final Sorted Array

- The entire array `[8, 4, 23, 42, 16, 15]` is now sorted as `[4, 8, 15, 16, 23, 42]`.

## Efficiency

This O(n log n) time complexity holds true in the worst, average, and best cases for Merge Sort. It makes Merge Sort an excellent choice for sorting large datasets or when a stable sorting algorithm is required.
