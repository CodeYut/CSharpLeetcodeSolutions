//https://leetcode.com/problems/reverse-words-in-a-string/?envType=study-plan-v2&envId=leetcode-75



public class Solution {
    public string ReverseWords(string s) {
        Stack<string> words = new Stack<string>();

        string output = "";
        string wordBuilder = "";

        for (int i = 0; i < s.Length; i++) {
            if(s[i] != ' ') {
                wordBuilder += s[i];
            }
            else {
                if(wordBuilder.Length > 0) {
                    words.Push(wordBuilder);
                    wordBuilder = "";
                }
            }
        }

        if(wordBuilder.Length > 0) {
            words.Push(wordBuilder);
        }

        while (words.Count > 0) {
            output += words.Pop();

            if(words.Count > 0) {
                output += " ";
            }
        }

        return output;
    }
}
