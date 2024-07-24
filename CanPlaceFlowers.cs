//https://leetcode.com/problems/can-place-flowers/?envType=study-plan-v2&envId=leetcode-75




public class Solution {
    public bool CanPlaceFlowers(int[] flowerbed, int n) {
        int count = 0;  //initialize the integer count to 0.

        for (int i = 0; i < flowerbed.Length; i++)  //iterate through the length of the array.
        {
            if (flowerbed[i] == 0 && (i == 0 || flowerbed[i - 1] == 0) && (i == flowerbed.Length - 1 || flowerbed[i + 1] == 0)) {  //checking if the flowerbed array equals 0 or other conditions.
                flowerbed[i] = 1;  //making the flowerbed array equal to 1.
                count++;  //increase the count by 1.
            }
        }

        return count >= n;  //returning the count greater or equal to n.  returns a bool from the comparison.
    }
}
