//https://leetcode.com/problems/kids-with-the-greatest-number-of-candies/?envType=study-plan-v2&envId=leetcode-75



public class Solution {
    public IList<bool> KidsWithCandies(int[] candies, int extraCandies) {
        int max = 0;  //Initialize the integer max.

        for (int i = 0; i < candies.Length; i++) {  //This loop iterates through the length of the arrray.
            if (max < candies[i]) {  //If the above criteria is met, we then check if the max is greater than the entire length of the candies array.
                max = candies[i];  //Max gets set to the candies array.
            }
        }

        bool[] result = new bool[candies.Length];  //Here we are initializing result as a bool because the answer needs to be a true/false.

        for (int i = 0; i < candies.Length; i++) {  //Once again we iterate through the entire array.
            if (candies[i] + extraCandies >= max) {  //Were checking if the candies array plus the extraCandies is greater than or equal to the max.
                result[i] = true;  //We then set the result array bool to true.  If this doesnt work out it'll be set to false.
            }
        }

        return result.ToList();  //We then return the result bool to a list.
    }
}
