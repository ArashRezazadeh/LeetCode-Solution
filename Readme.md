dotnet restore LeetCode-Solution.sln  
dotnet new console -n name  
cd name

## #1 Median of Two Sorted Arrays

**The Core Concept (What I Should Have Started With):**  
We're not actually merging the arrays. Instead, we're asking: "If I were to split the combined sorted array into left and right halves, how many elements would come from each original array?"

This is the fundamental trick that makes the algorithm efficient. Rather than doing the actual merge (O(m+n)), we're just counting how many elements we need from each array.

Imagine we have:

- nums1 = `[1, 3, 5, 7]`

- nums2 = `[2, 4, 6, 8]`

Instead of merging them into `[1, 2, 3, 4, 5, 6, 7, 8]`, we just need to find a dividing line:

```text
nums1: [1, 3, 5, 7]
        ↑     ↑
        |     Can we put the cut here?
        Or here?

nums2: [2, 4, 6, 8]
        ↑     ↑
```

The cut position determines how many elements from each array go to the left half:

- If we take first 2 from nums1 and first 2 from nums2 → Left half = [1, 3, 2, 4]

- But this isn't sorted! The algorithm checks if [1, 3] and [2, 4] can form a valid left half.

We don't care about the actual order within the left half. We only need to ensure that:

1. We have the right number of elements in the left half (totalLeft)

2. The largest element from the left half ≤ the smallest element from the right half
