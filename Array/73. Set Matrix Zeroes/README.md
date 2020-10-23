#### [73. Set Matrix Zeroes](https://leetcode-cn.com/problems/set-matrix-zeroes/)

## 1.题目

Given an m x n matrix. If an element is 0, set its entire row and column to 0. Do it in-place.

Follow up:

A straight forward solution using O(mn) space is probably a bad idea.
A simple improvement uses O(m + n) space, but still not the best solution.
Could you devise a constant space solution?

Example:

```
Input: matrix = [[1,1,1],[1,0,1],[1,1,1]]
Output: [[1,0,1],[0,0,0],[1,0,1]]
```

Note:

```
Input: matrix = [[0,1,2,0],[3,4,5,2],[1,3,1,5]]
Output: [[0,0,0,0],[0,4,5,0],[0,3,1,0]]
```



# 2. 分析

分析题目，问题解决的重点是原数组中0所处的位置

但是因为有空间的要求所以我们应该不能重新新建一个数组去做处理

这里首先是想到特殊值处理，在原数组上通过修改0所处位置行和列的值到最小值或最大值做处理，但是原题中没有给定范围（英文版有)

第二种方案是标记0所处位置行和列首元素的值进行处理，但是这里由于00元素同时被行和列影响需要新的空间进行区分，实际结果这种方式的空间占用也比较多

