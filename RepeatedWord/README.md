## Problem Domain

Imagine you have a text document, and you want to find the first repeated word in that document, ignoring common punctuation and case sensitivity. This code provides a solution to this problem.

### Input
- The input is a text document (a string).

### Output
- The output is the first repeated word found in the text document.
- If no repeated words are found, it returns "No repetition."

## Efficiency

The efficiency of the provided code can be analyzed as follows:

- **Time Complexity**: The code loops through each word in the input string, and for each word, it checks whether it has been seen before. This operation has a time complexity of O(N), where N is the number of words in the input string.

- **Space Complexity**: The code uses two `HashSet` objects (`seenWords` and `repeatedWords`) to keep track of words. The space complexity is O(M), where M is the number of unique words in the input string.

Overall, the code has a time complexity of O(N) and a space complexity of O(M), making it efficient for most practical purposes.
