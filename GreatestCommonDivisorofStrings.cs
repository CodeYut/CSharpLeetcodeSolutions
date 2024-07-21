//https://leetcode.com/problems/greatest-common-divisor-of-strings/?envType=study-plan-v2&envId=leetcode-75


public class Solution {
    //We need to create a seperate method to deal with the math side of the strings.  We try to eliminate certain edge cases like when n2 doesnt exist.
    public int gcd(int n1, int n2) {
        if (n2 == 0) {  //Were weeding out the possibility that the n2 string could be empty, returning n1 only.
            return n1;
        }
        else {  
            return gcd(n2, n1 % n2);
            //When we dont meet the IF criteria we want to figure out the remainder of n1 modulus n2.  
            //The remainder operator "%" divides the left hand operand by the right hand operand and returns how many whole times the number is divisible.
        }
    }

    public string GcdOfStrings(string str1, string str2) {
        int len1 = str1.Length;
        int len2 = str2.Length;

        if ((str1 + str2).Equals(str2 + str1)) {
            int index = gcd(len1, len2);

            return str1.Substring(0, index);
        }
        else {
            return "";
        }
    }
}
