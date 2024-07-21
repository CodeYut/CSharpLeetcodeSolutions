//https://leetcode.com/problems/merge-strings-alternately/?envType=study-plan-v2&envId=leetcode-75


public class Solution {
    public string MergeAlternately(string word1, string word2) {
        StringBuilder res = new StringBuilder();  //StringBuilder is used to modify strings, which are immutable in C#.  Every time you use String in C# you create a new object in memory,
                                                  //which requires a new allocation of space for that new object.  Repeated modifications to a string is costly so StringBuilder 
                                                  //prevents the creation of a new object.
      
        int i = 0;  //Here were creating our two pointers to iterate through our array.                              
        int j = 0;

        while (i < word1.Length && j < word2.Length) {
            res.Append(word1[i]).Append(word2[j]);  //Were appending a letter from each string to res, our new StringBuilder.  It iterates through the strings until the while loop condition is no longer met. 
            i++;  //After the append is complete were increase the pointers by one spot until the work is done.
            j++;  
        }

        while (i < word1.Length) {
            res.Append(word1[i]);
            i++;
        }

        while (j < word2.Length) {
            res.Append(word2[j]);
            j++;
        }

        return res.ToString();
    }
}
