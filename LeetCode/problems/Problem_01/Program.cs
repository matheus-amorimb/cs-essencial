// See https://aka.ms/new-console-template for more information
using System;
using System.Text;

public class Solution 
{
    public string MergeAlternately(string word1, string word2) 
    {
        var merged = new StringBuilder();

        int minLength = Math.Min(word1.Length, word2.Length); 
        
        for (int i = 0; i < minLength; i++)
        {
            merged.Append(word1[i]).Append(word2[i]);
        }

        merged.Append(word1.Substring(minLength)).Append(word2.Substring(minLength));

        return merged.ToString(); 
    }

    static void Main()
    {

        string result = new Solution().MergeAlternately("party", "rocks");

        Console.WriteLine(result);
    
    }

}