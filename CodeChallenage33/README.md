
## Problem Domain

You are given two dictionaries, one containing synonyms and the other containing antonyms. Your task is to implement the `LeftJoin` function, which will perform a left join operation on these dictionaries and return a list of lists containing three elements: the key, the synonym (if found), and the antonym (if found).

### Input

- `synonyms`: A dictionary where keys represent words and values represent their synonyms.
- `antonyms`: A dictionary where keys represent words and values represent their antonyms.

### Output

- A list of lists, where each inner list contains three elements: the word (key), its synonym , and its antonym . If a word has no synonym or antonym, the corresponding field should be filled with `null`.

### Example

#### Test Case 1

```csharp
Dictionary<string, string> synonyms1 = new Dictionary<string, string>
{
    { "diligent", "employed" },
    { "fond", "enamored" },
    { "guide", "usher" },
    { "outfit", "garb" },
    { "wrath", "anger" }
};

Dictionary<string, string> antonyms1 = new Dictionary<string, string>
{
    { "diligent", "idle" },
    { "fond", "averse" },
    { "guide", "follow" },
    { "flow", "jam" },
    { "wrath", "delight" }
};

List<List<string>> result1 = LeftJoin(synonyms1, antonyms1);
```

**Output:**

```
[
    ["diligent", "employed", "idle"],
    ["fond", "enamored", "averse"],
    ["guide", "usher", "follow"],
    ["outfit", "garb", null],
    ["wrath", "anger", "delight"]
]
```



## Efficiency

- **Time Complexity**: The time complexity of this solution is O(n), where n is the number of entries in the `synonyms` dictionary. This is because it iterates through the `synonyms` dictionary once and performs a constant-time lookup in the `antonyms` dictionary for each entry.

- **Space Complexity**: The space complexity is O(n), where n is the number of entries in the `synonyms` dictionary. The space is used to store the resulting list of lists.
