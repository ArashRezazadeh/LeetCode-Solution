dotnet restore LeetCode-Solution.sln  
dotnet new console -n name  
cd name

## #1 Median of Two Sorted Arrays

**What is a Median?**  
The median is the "middle" value in a sorted list of numbers.

**Simple Examples**
Odd number of elements:

```text
[1, 2, 3, 4, 5] → median = 3 (the middle element)
```

There are 2 numbers smaller and 2 numbers bigger than 3.

**Even number of elements:**

```text
[1, 2, 3, 4, 5, 6] → median = (3 + 4)/2 = 3.5
```

When there's no single middle, we take the average of the two middle numbers.  
.

.

.

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

**EX: Partitioning**

```text

nums1 = [10, 20, 30, 40, 50]
nums2 = [15, 25, 35, 45]

```

Suppose our algorithm decides to take:

- 3 elements from nums1 for the left half (partition1 = 3)

- 2 elements from nums2 for the left half (partition2 = 2)

**Visual Representation: **

```text
nums1: [10, 20, 30 | 40, 50]
         ↑   ↑   ↑    ↑   ↑
         |   |   |    |   |
index    0  1   2    3   4

       <--left1-->   <-right1->
       (last of left) (first of right)

       left1 = 30     right1 = 40
```

```text
nums2: [15, 25 | 35, 45]
         ↑   ↑    ↑   ↑
         |   |    |   |
index    0  1    2   3

       <left2->   <-right2->
       (last of left) (first of right)

       left2 = 25     right2 = 35
```

** We need to verify that ALL elements in the left half are ≤ ALL elements in the right half. **

```text
Left half (from both arrays): [10, 20, 30, 15, 25]
Right half (from both arrays): [40, 50, 35, 45]

But we don't actually merge them! We just need to ensure:

30 (largest from nums1's left)  ≤ 40 (smallest from nums1's right)? ✓
30 ≤ 35 (smallest from nums2's right)? ✓
25 (largest from nums2's left) ≤ 40? ✓
25 ≤ 35? ✓
```

The condition `left1 <= right2 && left2 <= right1` checks all cross-boundary relationships:

** Another Example with Different Partition **
If we instead took `partition1 = 2` and `partition2 = 3`:

```text
nums1: [10, 20 | 30, 40, 50]
         ↑   ↑    ↑   ↑   ↑
         left1    right1
         = 20     = 30

nums2: [15, 25, 35 | 45]
         ↑   ↑   ↑    ↑
         left2        right2
         = 35         = 45
```

Now check:

- `left1 (20) <= right2 (45)?` ✓
- `left2 (35) <= right1 (30)?` ✗ (35 > 30) → Invalid partition!
