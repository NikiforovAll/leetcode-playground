/*
 * @lc app=leetcode id=231 lang=csharp
 *
 * [231] Power of Two
 *
 * https://leetcode.com/problems/power-of-two/description/
 *
 * algorithms
 * Easy (43.01%)
 * Likes:    789
 * Dislikes: 185
 * Total Accepted:    322.1K
 * Total Submissions: 740.7K
 * Testcase Example:  '1'
 *
 * Given an integer, write a function to determine if it is a power of two.
 *
 * Example 1:
 *
 *
 * Input: 1
 * Output: true
 * Explanation: 2^0 = 1
 *
 *
 * Example 2:
 *
 *
 * Input: 16
 * Output: true
 * Explanation: 2^4 = 16
 *
 * Example 3:
 *
 *
 * Input: 218
 * Output: false
 *
 */
namespace _231
{
    // @lc code=start
    public class Solution
    {
        public bool IsPowerOfTwo(int n) =>
            n switch
            {
                int n1 when n1 > 0 => n != 0 && (n & (n - 1)) == 0,
                _ => false,
            };
    }
    // @lc code=end
}
