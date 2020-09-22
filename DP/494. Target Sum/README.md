# 494. Target Sum

## 1.题目

You are given a list of non-negative integers, a1, a2, ..., an, and a target, S. Now you have 2 symbols + and -. For each integer, you should choose one from + and - as its new symbol.

Find out how many ways to assign symbols to make sum of integers equal to target S.

Example:

```
Input: nums is [1, 1, 1, 1, 1], S is 3. 
Output: 5
Explanation: 

-1+1+1+1+1 = 3
+1-1+1+1+1 = 3
+1+1-1+1+1 = 3
+1+1+1-1+1 = 3
+1+1+1+1-1 = 3

There are 5 ways to assign symbols to make the sum of nums be target 3.
```

# 2. 分析

整个问题其实是一个变形的0-1背包问题

依然可以用之前的dfs和dp

只需要将-号作为基本状态，并且整体加上total

目标值为S+total即可

## 2.1 DFS

对于每一个元素都有选与不选两个状态所以

T(n,target) = T(n+1, target-nums[n]) || T(n+1, target)

# 2.2 DP

动态规划理论上是一致的

也是

T(n,target) = T(n+1, target-nums[n]) || T(n+1, target)

区别是记录下中间的求值结果不用重复递归

