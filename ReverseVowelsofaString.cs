//https://leetcode.com/problems/reverse-vowels-of-a-string/?envType=study-plan-v2&envId=leetcode-75


public class Solution {
    public string ReverseVowels(string s) {
        Stack<char> vowelsInTheString = new Stack<char>();  //create a new stack.
        HashSet<char> vowels = new HashSet<char>() {'a', 'e', 'o', 'u', 'i', 'A', 'E', 'O', 'U', 'I'};  //create a hashset including the vowels.
        HashSet<int> indexesOfVowels = new HashSet<int>();  //This hashset is for the integer index of the vowels.
        StringBuilder result = new StringBuilder(s);  //create a new StringBuilder.

        for (var i = 0; i < s.Length; i++) {  //iterate through the entire array.
            if(vowels.Contains(s[i])) {   //if the vowels hashset contains the string array.
                vowelsInTheString.Push(s[i]);  //push the string array position onto the stack.
                indexesOfVowels.Add(i);  //add the letter to the hashset.
            }
        }

        for(var i = 0; i < s.Length; i++) {  //iterate through the entire array again.
            if(indexesOfVowels.Contains(i)) {  //check if the hashset contains the letter.
                result[i] = vowelsInTheString.Pop();  //take the result array and set it equal to the hashset after the pop happens.
            }
        }

        return result.ToString();  //return the result to a string.
    }
}
