Solution solution = new Solution();

public class Solution {
    public string ReverseVowels(string s)
    {
        int stringLenght = s.Length;
        int rightPointer = stringLenght - 1;
        List<char> reversedString = s.ToList(); 

        for (int leftPointer = 0; leftPointer < stringLenght && leftPointer < rightPointer; leftPointer++)
        {
            char leftChar = s[leftPointer];
            
            if ("aeiouAEIOU".IndexOf(leftChar) >= 0)
            {
                char rightChar = s[rightPointer];
                while ("aeiouAEIOU".IndexOf(rightChar) < 0 && rightPointer > leftPointer) 
                {
                    rightPointer -= 1;
                    rightChar = s[rightPointer];
                }

                reversedString[leftPointer] = rightChar;
                reversedString[rightPointer] = leftChar;
                rightPointer -= 1;
            }
            
        }
        string convertedString = new string(reversedString.ToArray());
        
        return convertedString;
    }
}