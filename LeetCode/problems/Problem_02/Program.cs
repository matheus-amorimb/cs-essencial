public class Solution 
{
    public string GcdOfStrings(string str1, string str2) 
    {
        if (str1 + str2  != str2 + str1)
        {
            return "";
        }
        
        else
        {
            int str1Length = str1.Length;
            int str2Length = str2.Length;
            
            int mdc = MDC(str1Length, str2Length);

            if (str1Length < str2Length)
            {
                return str1.Substring(0, mdc);
            }

            else
            {
                return str2.Substring(0, mdc);
            }
        }
    }   

    public int MDC(int num1, int num2)

    {
        int minNum = Math.Min(num1, num2);
        int mdc = 1;

        for(int i = 1; i <= minNum; i++)
        {
    
            if(num1 % i == 0 && num2 % i == 0)
            {
                mdc = i;
            }

        }

        return mdc;

    }

    static void Main()
    {

        string result = new Solution().GcdOfStrings("leet", "code");

        Console.WriteLine(result);

    }


}