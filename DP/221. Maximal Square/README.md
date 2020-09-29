# 221. Maximal Square

## 1.题目

Given a 2D binary matrix filled with 0's and 1's, find the largest square containing only 1's and return its area.

Example:

```
Input: 

1 0 1 0 0
1 0 1 1 1
1 1 1 1 1
1 0 0 1 0

Output: 4
```

# 2. 分析

首先想到的是DP，设dp\[i][j]为以第i行，第j列为右下角的最大正方形边长，则有

dp\[i][j] = min(dp[i-1,j],dp\[i][j-1],dp\[i-1][j-1]) | matrix\[i][j] = 1

dp\[i][j] = 0 | matrix\[i][j] = 0

可以比较简单的写出dp的解决方案

又因为dp的确定只与上一行上一列有关，所以可以空间优化到一个数组解决

这里我又为了方便理清三个值之间的关系，用一个数组将三个值存了起来

