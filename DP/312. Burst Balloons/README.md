# 312. Burst Balloons

## 1.题目

Given n balloons, indexed from 0 to n-1. Each balloon is painted with a number on it represented by array nums. You are asked to burst all the balloons. If the you burst balloon i you will get nums[left] * nums[i] * nums[right] coins. Here left and right are adjacent indices of i. After the burst, the left and right then becomes adjacent.

Find the maximum coins you can collect by bursting the balloons wisely.

Example:

```
Input: [3,1,5,8]
Output: 167 
Explanation: nums = [3,1,5,8] --> [3,5,8] -->   [3,8]   -->  [8]  --> []
             coins =  3*1*5      +  3*5*8    +  1*3*8      + 1*8*1   = 167
```

# 2. 分析

首先应该想到穷举法，那么整体结果应该为n!的复杂度一定是超时的

重新审视问题，发现问题的难点在于当你戳破一个气球时由于不能确定两边的边界值，所以不能确定此次获得的硬币数量。那什么时候我们能确定戳破的气球的边界值，从而将问题简化呢?

我们可以用分而治之的思想，考虑其中一个状态，如果我们最后戳破气球k那么我们本次获得的硬币数量就等于，在左侧戳破气球获得的硬币数与在右侧获得的硬币数的和再加上k气球的硬币数量，因为最后才戳破k所以，左侧右侧计算硬币数量时互不干扰，从而变成了两个互不干扰的子问题

进一步的我们可以生成递归算法

再进一步可以使用动态规划进行效率提升

# DP

动态规划的关键是以已知求未知，通过空间上对已知数据的存储避免深度递归

所以重点是状态转移方程

本题中可以dp\[i][j]为(i,j)的最值，那么

dp\[i][j] = max(v[i] * v[j] * v[k] + dp\[i][k] + dp\[k][j]) i<k<j

最终答案为dp\[i][j],这里要注意求值时需要已知的两个数据分别位于要求数据的左边和下边，所以要从左下角开始求值

