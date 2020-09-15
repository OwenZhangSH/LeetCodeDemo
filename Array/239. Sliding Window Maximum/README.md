# 239. Sliding Window Maximum

## 1.题目

Given an array nums, there is a sliding window of size k which is moving from the very left of the array to the very right. You can only see the k numbers in the window. Each time the sliding window moves right by one position. Return the max sliding window.

Example:

```
Input: nums = [1,3,-1,-3,5,3,6,7], and k = 3
Output: [3,3,5,5,6,7] 
Explanation: 

Window position                Max
---------------               -----
[1  3  -1] -3  5  3  6  7       3
 1 [3  -1  -3] 5  3  6  7       3
 1  3 [-1  -3  5] 3  6  7       5
 1  3  -1 [-3  5  3] 6  7       5
 1  3  -1  -3 [5  3  6] 7       6
 1  3  -1  -3  5 [3  6  7]      7
```

Constraints:

```
1 <= nums.length <= 10^5
-10^4 <= nums[i] <= 10^4
1 <= k <= nums.length
```



# 2. 分析

一个滑动窗口问题 暴力破解需要O(N * K)不满足要求

## 2.1 双端队列

其实一个滑动窗口移动时，无非是排除掉一个元素，新加入一个元素

所以基本有两种情况：

- 排除掉的元素不为最大值元素，只需要最大值元素与新引入的元素比较即可
- 排除掉的元素为最大值元素，则需要次大值元素与新引入的元素比较即可

综上，第一种情况比较简单，只需要保存最大值位置，进行更新即可

第二种情况需要知道次大值元素所在位置，并且在之后的相对应的情况下也需要知道次大值元素位置

所以理论上只需要维护一个队列，队首是最大值的秩，之后的元素分别是次大值的秩（单调递增，且值单调递减）

但是这个队列维护相对来说比较复杂，普通队列无法高效完成，这里使用deque双端队列

但是C#没有提供原生的双端队列类，这里使用c++完成

# 2.2 双向扫描

这种方法非常巧妙

根据K的大小将队列分为若干个窗口

![](https://pic.leetcode-cn.com/1598322814-vgxEqd-image.png)

那么滑动区域有两种情况

- 正好与窗口重合
- 位于两个窗口之间

第一种情况只需知道当前窗口的最大值即可

第二种情况则需要知道两个窗口内分别最值大小，即以窗口分割线为基础向左，向右分别的最值

所以这里构建两个队列left，right

left为从左往右扫描，窗口start到当前元素的最大值

right为从右往左扫描，窗口start到当前元素的最大值

![](https://pic.leetcode-cn.com/1598322835-oXsIFc-image.png)

第一种情况是相等的

![](https://pic.leetcode-cn.com/1598322843-nhAyjW-image.png)

第二种情况只需对比right左侧最大值与left右侧最大值

