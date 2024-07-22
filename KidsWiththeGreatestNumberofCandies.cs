//https://leetcode.com/problems/kids-with-the-greatest-number-of-candies/?envType=study-plan-v2&envId=leetcode-75



public class Solution {
    public IList<bool> KidsWithCandies(int[] candies, int extraCandies) {
        int max = 0;

        for (int i = 0; i < candies.Length; i++) {
            if (max < candies[i]) {
                max = candies[i];
            }
        }

        bool[] result = new bool[candies.Length];

        for (int i = 0; i < candies.Length; i++) {
            if (candies[i] + extraCandies >= max) {
                result[i] = true;
            }
        }

        return result.ToList();
    }
}
