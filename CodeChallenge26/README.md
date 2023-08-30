## Insertion Sort Algorithm :

Insertion sort is a simple way to arrange a list of numbers in order. 

## Here's how it works:

Imagine you have a jumbled set of numbers (like [8, 4, 23, 42, 16, 15]) that you want to sort.
You start by taking the first number (8) and consider it as a sorted list of one number.
Then you pick the next number (4) and compare it to the sorted list (just 8 for now). Since 4 is smaller, you move 8 to the right and put 4 in its place.
Now you have two sorted numbers: [4, 8].
You repeat this process for each remaining number, like 23, 42, 16, and 15. You compare each number to the sorted list and insert it into the right position.
After going through all the numbers, you end up with a completely sorted list.

## Example Sorting [8, 4, 23, 42, 16, 15]:

1-Start with [8]. (Just one number, so it's already sorted.)

2-nsert 4 into the right spot: [4, 8].

3-Insert 23 into the right spot: [4, 8, 23].

4-Insert 42 into the right spot: [4, 8, 23, 42].

5-Insert 16 into the right spot: [4, 8, 16, 23, 42].

6-Insert 15 into the right spot: [4, 8, 15, 16, 23, 42].

## Efficiency - How Fast and How Much Space:

 ### Time Complexity: 


Insertion Sort has an average and worst-case time complexity of O(n^2), where "n" represents the number of elements in the array being sorted.
