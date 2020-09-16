# 416. Partition Equal Subset Sum

## 1.题目

Given a non-empty array containing only positive integers, find if the array can be partitioned into two subsets such that the sum of elements in both subsets is equal.

Example:

```
Input: [1, 5, 11, 5]

Output: true

Input: [1, 2, 3, 5]

Output: false
```

# 2. 分析

整个问题其实是在一个序列中选择若干的数，使其和为序列总和的一半

所以对于序列中每一个数都有选与不选两种状态

自上而下可以使用DFS

自下而上可以使用DP

## 2.1 DFS

对于每一个元素都有选与不选两个状态所以

T(n,target) = T(n+1, target-nums[n]) || T(n+1, target)

# 2.2 DP

动态规划理论上是一致的

也是

T(n,target) = T(n+1, target-nums[n]) || T(n+1, target)

区别是记录下中间的求值结果不用重复递归

