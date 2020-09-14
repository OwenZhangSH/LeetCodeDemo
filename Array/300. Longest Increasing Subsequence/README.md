# 300. Longest Increasing Subsequence

## 1.题目

Given an unsorted array of integers, find the length of longest increasing subsequence.

Example:

```
Input: [10,9,2,5,3,7,101,18]
Output: 4 
Explanation: The longest increasing subsequence is [2,3,7,101], therefore the length is 4. 
```

Note:

```
There may be more than one LIS combination, it is only necessary for you to return the length.
Your algorithm should run in O(n2) complexity.
Follow up: Could you improve it to O(n log n) time complexity?
```



# 2. 分析

题目要求是 在一个序列中找到最长的上升序列啊，即一个单调递增的子序列

时间复杂度要求是 O(n2)，进阶要求是O(n log n)

## 2.1 动态规划

首先想到的是动态规划 一个序列中的最长限定子序列 = max（以每个元素为开头的最长限定序列）

T(n) = max((n 符合限定？) T(K) + 1: 1) | K > n && K < m

所以动态规划从最后一个元素T(n)可得到结果

整体的时间复杂度为O(n2)

# 2.2 二分查找

为了进一步提升效率，分析一下动态规划中的时间消耗，我们在得出T(n)是是对(n,m)进行遍历，求出最大上升序列，但是如果我们知道n能组成长度为3的序列的话，我们就不用计算长度为2的这种情况，那么什么时候我们能确定这种情况呢，即nums[n] < nums[k] (k=max(T(k)=2)) , 这种情况下就不用比较了，所以如果我们能在遍历过程中记录下每个子序列长度中的最大值，那我们即可以直接确定T(n)可能的取值范围而不用进行遍历

整体其实是一个贪心+二分查找
$$
最后整个算法流程为：

设当前已求出的最长上升子序列的长度为 \textit{len}（初始时为 1），从前往后遍历数组 \textit{nums}，在遍历到 \textit{nums}[i] 时：

如果 \textit{nums}[i] > d[\textit{len}] ，则直接加入到 d数组末尾，并更新 \textit{len} = \textit{len} + 1；

否则，在 d 数组中二分查找，找到第一个比 \textit{nums}[i] 小的数 d[k] ，并更新 d[k + 1] = \textit{nums}[i]。

以输入序列 [0, 8, 4, 12, 2][0,8,4,12,2] 为例：

第一步插入 0，d = [0]；

第二步插入 8，d = [0, 8]；

第三步插入 4，d = [0, 4]；

第四步插入 12，d = [0, 4, 12]；

第五步插入 2，d = [0, 2, 12]。

最终得到最大递增子序列长度为 3。

作者：LeetCode-Solution
链接：https://leetcode-cn.com/problems/longest-increasing-subsequence/solution/zui-chang-shang-sheng-zi-xu-lie-by-leetcode-soluti/
来源：力扣（LeetCode）
$$
