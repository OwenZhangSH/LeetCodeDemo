#### [978. Longest Turbulent Subarray](https://leetcode-cn.com/problems/longest-turbulent-subarray/)

## 1.题目

A subarray A[i], A[i+1], ..., A[j] of A is said to be turbulent if and only if:

For i <= k < j, A[k] > A[k+1] when k is odd, and A[k] < A[k+1] when k is even;
OR, for i <= k < j, A[k] > A[k+1] when k is even, and A[k] < A[k+1] when k is odd.
That is, the subarray is turbulent if the comparison sign flips between each adjacent pair of elements in the subarray.

Return the length of a maximum size turbulent subarray of A.

**Example:**

```
Input: [9,4,2,10,7,8,8,1,9]
Output: 5
Explanation: (A[1] > A[2] < A[3] > A[4] < A[5])
```

# 2. 分析

比较经典的动态规划问题，求一个序列满足一定条件的最长子序列，考虑中间状态第i-1个元素在序列中，那么第i个元素是否会在序列中有以下几种情况

1. 符合要求在序列中，最长数量+1
2. 不符合要求形成新的子序列

放到本题中有以下3种情况

1. 符合湍流要求，max + 1
2. 不符合要求，但是能与前一元素组成新的序列
3. 不符合要求，且与前一元素相等，新序列从i开始

所以问题上升到以i结尾的最大子序列长度

假设maxEnd数组代表以i结尾的最大子序列长度，对整个序列进行遍历，过程中不断更新max，即可解决问题

这里由于之后的元素只与之前的元素有关，可以用一个变量保存最大值结果，节省空间开销