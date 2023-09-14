### Hashtable Class Algorithm

#### Initialization
- Create a Hashtable with an array of linked lists to handle collisions.
- The size of the array is determined by the initial capacity or defaults to 16 if not provided.

#### Set Method
- To set a key-value pair:
  1. Hash the key to determine its index in the array.
  2. If the bucket at the index is null, create a new linked list in that bucket.
  3. Iterate through the linked list in the bucket:
     - If the key already exists, replace its associated value.
     - If the key does not exist in the list, add a new key-value pair to the list.
  
#### Get Method
- To get the value associated with a key:
  1. Hash the key to determine its index in the array.
  2. Iterate through the linked list in the bucket at the calculated index:
     - If the key is found, return its associated value.
     - If the key is not found in the list, throw a KeyNotFoundException.

#### Has Method
- To check if a key exists in the Hashtable:
  1. Hash the key to determine its index in the array.
  2. Iterate through the linked list in the bucket at the calculated index:
     - If the key is found, return true.
     - If the key is not found in the list, return false.

#### Keys Method
- To retrieve all keys in the Hashtable:
  1. Initialize an empty list to store keys.
  2. Iterate through all buckets in the array:
     - If a bucket exists, iterate through the linked list in the bucket and add each key to the list.
  3. Return the list of keys.

#### Hash Method
- To calculate the index for a key:
  1. Calculate the hash code of the key.
  2. Take the absolute value of the hash code to ensure it's non-negative.
  3. Calculate the index by taking the modulus of the absolute hash code with the length of the array.

### Time Complexity

- The time complexity of various Hashtable operations depends on the distribution of keys and the quality of the hash function.
- In the average case (assuming a good hash function), the time complexity for set, get, and has operations is O(1), which means they are constant time operations.
- However, in the worst case, when there are many collisions (poor hash function or high load factor), the time complexity can degrade to O(n), where n is the number of key-value pairs.
- The Keys method has a time complexity of O(n) since it needs to iterate through all key-value pairs in the Hashtable.
