#### [474. Ones and Zeroes](https://leetcode-cn.com/problems/ones-and-zeroes/)

## 1.题目

You are given an array of binary strings strs and two integers m and n.

Return the size of the largest subset of strs such that there are at most m 0's and n 1's in the subset.

A set x is a subset of a set y if all elements of x are also elements of y.

**Example:**

```
Input: strs = ["10","0001","111001","1","0"], m = 5, n = 3
Output: 4
Explanation: The largest subset with at most 5 0's and 3 1's is {"10", "0001", "1", "0"}, so the answer is 4.
Other valid but smaller subsets include {"0001", "1"} and {"10", "1", "0"}.
{"111001"} is an invalid subset because it contains 4 1's, greater than the maximum of 3.
```

# 2. 分析

首先只考虑0的数量限制这是个经典的0-1背包问题，区别只是增加了一个限制条件，所以我们依然可以用背包问题的思路进行问题分析，这里有一个很不错的分析框架

（https://leetcode-cn.com/problems/ones-and-zeroes/solution/dong-tai-gui-hua-0-1bei-bao-wen-ti-labuladongdong-/）

写的非常好，我这里直接复制过来

**第一步，要明确两点，[状态]和[选择]。**

状态有三个， [背包对1的容量]、[背包对0的容量]和 [可选择的字符串]

选择就是把字符串[装进背包]或者[不装进背包]。

```
for 状态1 in 状态1的所有取值：
    for 状态2 in 状态2的所有取值：
        for ...
            dp[状态1][状态2][...] = 计算(选择1，选择2...)
```

**第二步，要明确dp数组的定义：**

首先，[状态]有三个，所以需要一个三维的dp数组。

dp\[i]\[j]\[k]的定义如下：

若只使用前i个物品，当背包容量为j个0，k个1时，能够容纳的最多字符串数。

经过以上的定义，可以得到：

base case为dp[0]\[..]\[..] = 0, dp\[..]\[0]\[0] = 0。因为如果不使用任何一个字符串，则背包能装的字符串数就为0；如果背包对0，1的容量都为0，它能装的字符串数也为0。

我们最终想得到的答案就是dp\[N]\[zeroNums][oneNums]，其中N为字符串的的数量。

**第三步，根据选择，思考状态转移的逻辑：**

注意，这是一个0-1背包问题，每个字符串只有一个选择机会，要么选择装，要么选择不装。

如果你不把这第 i 个物品装入背包（等同于容量不足，装不下去），也就是说你不使用strs[i]这一个字符串，那么当前的字符串数dp[i][j][k]应该等于dp\[i - 1]\[j]\[k],继承之前的结果。

如果你把这第 i 个物品装入了背包，也就是说你使用 strs[i] 这个字符串，那么 dp\[i]\[j] 应该等于 Max(dp\[i - 1]\[j][k], dp\[i]\[j - cnt\[0]][k - cnt[1]] + 1)。(cnt 是根据strs[i]计算出来的。)

比如说，如果你想把一个cnt = [1,2]的字符串装进背包(在容量足够的前提下)，只需要找到容量为

\[j - 1][k - 2]时候的字符串数再加上1，就可以得到装入后的字符串数了。

由于我们求的是最大值，所以我们要求的是装和不装中能容纳的字符串总数更大的那一个。

作者：dong-men
链接：https://leetcode-cn.com/problems/ones-and-zeroes/solution/dong-tai-gui-hua-0-1bei-bao-wen-ti-labuladongdong-/
来源：力扣（LeetCode）
著作权归作者所有。商业转载请联系作者获得授权，非商业转载请注明出处。



根据以上的分析框架能够得到最基础的结果，同背包问题我们也可以根据状态进行简化，因为结果只与上一次状态有关，减少空间占用