#### [[384. Shuffle an Array](https://leetcode-cn.com/problems/shuffle-an-array/)](https://leetcode-cn.com/problems/set-matrix-zeroes/)

## 1.题目

Shuffle a set of numbers without duplicates.

**Example:**

```
// Init an array with set 1, 2, and 3.
int[] nums = {1,2,3};
Solution solution = new Solution(nums);

// Shuffle the array [1,2,3] and return its result. Any permutation of [1,2,3] must equally likely to be returned.
solution.shuffle();

// Resets the array back to its original configuration [1,2,3].
solution.reset();

// Returns the random shuffling of array [1,2,3].
solution.shuffle();
```

# 2. 分析

1. 构造函数直接数组克隆就好
2. reset方法直接返回克隆好的origin数组
3. shuffle方法，可以使用算法，首先克隆origin数组，然后进行随机取值，不断缩小范围，最后完成打乱