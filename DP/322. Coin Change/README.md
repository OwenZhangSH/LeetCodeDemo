# 322. Coin Change

## 1.题目

You are given coins of different denominations and a total amount of money amount. Write a function to compute the fewest number of coins that you need to make up that amount. If that amount of money cannot be made up by any combination of the coins, return -1.

Example:

```
Input: coins = [1, 2, 5], amount = 11
Output: 3 
Explanation: 11 = 5 + 5 + 1
```

# 2. 分析

比较简单的选择求最值问题

两种思考方法自顶向下的dfs和自底向上的dp

