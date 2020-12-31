#### [213. House Robber II](https://leetcode-cn.com/problems/house-robber-ii/)

## 1.题目

You are a professional robber planning to rob houses along a street. Each house has a certain amount of money stashed. All houses at this place are arranged in a circle. That means the first house is the neighbor of the last one. Meanwhile, adjacent houses have a security system connected, and it will automatically contact the police if two adjacent houses were broken into on the same night.

Given a list of non-negative integers nums representing the amount of money of each house, return the maximum amount of money you can rob tonight without alerting the police

Example:

```
Input: nums = [2,3,2]
Output: 3
Explanation: You cannot rob house 1 (money = 2) and then rob house 3 (money = 2), because they are adjacent houses.
```

# 2. 分析

对于本问题的简化版问题，即首位不相连的打家劫舍问题，比较容易解决，标准的动态规划问题，这里首先想办法将问题想简单的问题进行转化，如果我们排除首尾房间那么这个问题又变回了简化版的打家劫舍问题，进一步可以将原问题拆分成两个子问题

1. 前n-1个房间的打家劫舍问题
2. 后n-1个房间的打家劫舍问题
3. 取两者的最大值

