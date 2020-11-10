#### [787. Cheapest Flights Within K Stops](https://leetcode-cn.com/problems/cheapest-flights-within-k-stops/)

## 1.题目

There are n cities connected by m flights. Each flight starts from city u and arrives at v with a price w.

Now given all the cities and flights, together with starting city src and the destination dst, your task is to find the cheapest price from src to dst with up to k stops. If there is no such route, output -1.

**Example:**

```
Example 1:
Input: 
n = 3, edges = [[0,1,100],[1,2,100],[0,2,500]]
src = 0, dst = 2, k = 1
Output: 200
```

# 2. 分析

首先我们可以想到的是类似背包问题，一个3维数组可以表示dp[src,dst,k] k次中转的限制下，src到dst的最小花费

那么dp[src,dst,k] = min(dp[src,dst,k-1], dp[src,u,k-1] + cost[i,j])

用一个三维数组遍历更新即可解决问题由于只与上一次k有关，所以用二维数组即可

但是这里如果我们要考虑所有的src，dst情况我们就要维护一个二维nxn的数组，时间和空间消耗都比较大

这里根据题目，src和dst固定，我们进一步简化问题

dp[i]为src到i站在k次中转下的最小值

dp[i] = min(dp[i], dp[u] + cost[u,i])

因为只有有航班才可能有cost所以遍历的时候以航班为基，而不是用站点