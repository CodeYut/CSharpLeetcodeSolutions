//https://leetcode.com/problems/reverse-words-in-a-string/?envType=study-plan-v2&envId=leetcode-75



public class Solution {
    public string ReverseWords(string s) {
        Stack<string> words = new Stack<string>();  //create new stack for the words.

        string output = "";  //initialize string variable.
        string wordBuilder = "";  //initialize string variable to build the future word we create.

        for (int i = 0; i < s.Length; i++) {  //iterate through entire string array.
            if(s[i] != ' ') {  //checking if the s array doesnt contain a space, meaning its only one word.
                wordBuilder += s[i];  //if we only find one word in the array, the wordbuilder string gets assigned the entirety of the s array.
            }
            else {  //else is for the array containing a space, meaning theres more than one word in the array.
                if(wordBuilder.Length > 0) {  //checking if the string var length is greater than 0.
                    words.Push(wordBuilder);  //should the above be met, the stack gets the wordbuilder string pushed onto the stack.
                    wordBuilder = "";  //the string then becomes empty.
                }
            }
        }

        if(wordBuilder.Length > 0) {  //if the wordbuilder string ends up being greater than 0, continue.
            words.Push(wordBuilder);  //the words stack will then get the entirety of the wordbuilder string pushed onto it.
        }

        while (words.Count > 0) {  //while the stack count is greater than 0, continue.
            output += words.Pop();  //now we add the first item in the stack to the output var.

            if(words.Count > 0) {  //while the stack count is greater than 0, continue.
                output += " ";  //output will then get assigned a space in between each word in the while loop.
            }
        }

        return output;  //just return the output string.
    }
}
