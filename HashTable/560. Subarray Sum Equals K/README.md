#### 560. Subarray Sum Equals K

## 1.题目

Given an array of integers and an integer k, you need to find the total number of continuous subarrays whose sum equals to k.

Example:

```
Input:nums = [1,1,1], k = 2
Output: 2
```

Constraints:

```
The length of the array is in range [1, 20,000].
The range of numbers in the array is [-1000, 1000] and the range of the integer k is [-1e7, 1e7].
```



# 2. 分析

暴力穷举

构建前缀和，s[i]为0-i的和，s(i,J) = s[j]-s[i]

为了使是s(i,j) == k则s[i] = s[j]-k,所以只要记录下符合条件的s[i]的数量就可以快速计算

使用hashtable进行存储，可以进一步优化

