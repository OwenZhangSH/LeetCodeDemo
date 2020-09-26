# 309. Best Time to Buy and Sell Stock with Cooldown

## 1.题目

Say you have an array for which the ith element is the price of a given stock on day i.

Design an algorithm to find the maximum profit. You may complete as many transactions as you like (ie, buy one and sell one share of the stock multiple times) with the following restrictions:

You may not engage in multiple transactions at the same time (ie, you must sell the stock before you buy again).
After you sell your stock, you cannot buy stock on next day. (ie, cooldown 1 day)

Example:

```
Input: [1,2,3,0,2]
Output: 3 
Explanation: transactions = [buy, sell, cooldown, buy, sell]
```

# 2. 分析

首先应该想到的是根据价格的变化去求最大值，但是会面临一个问题，当两个上升区间紧邻的时候由于冷却期，应该如何选择什么时候卖出或者应不应该卖出，在多个区间紧邻的时候情况会复杂很多。此时应该想办法简化问题。

假设当第i天**结束**时，我们的最大收益为fi，那么此时我们的情况有三种

1. 我们持有当前这只股票
2. 我们没有持有当前这只股票，且今天结束时我们进入冷却期（我们今天卖出了这只股票）
3. 我们没有持有当前这只股票，且今天结束时我们没有冷却期（我们今天未做操作）

也就是说**f\[i][0]**，有两种情况

1. 之前就持有该股票，今天没有操作**（f\[i-1][0]）**
2. 之前没有持有该股票，今天买了**(f\[i-1][2] - prices[i])**,这里要注意如果我们第i-1天结束时，处于冷却期(也就是f\[i-1][1])我们第i天是无法进行操作的

需要在这两者间取**max**，也就是**max(f\[i-1][0], f\[i-1][2] - prices[i])**

**f\[i][1]**，有1种情况,也就是当天卖出**(f\[i-1][0] - prices[i])**,这里注意当天要卖出，所以前一天一定要持有

**f\[i][2]**，有2种情况

1. 前一天结束后，进入冷却期，不能操作**（f\[i-1][1]）**
2. 前一天结束后，未进入冷却期，没有购买**（f\[i-1][2]）**

其实，这里可以理解为，将昨天没有持有的情况继承过来，因为今天是没有进行操作的

所以现在我们可以根据已知求未知了，直接应用DP解决问题