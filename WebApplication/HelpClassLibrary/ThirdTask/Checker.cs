
namespace HelpClassLibrary.ThirdTask
{
    public static class Checker
    {
        public static bool IsPalindrome(string word)
        {
            for(int i = 0; i < word.Length/2-1; i++)
            {
                if (word[i] != word[word.Length - i - 1])
                    return false;
            }
            return true;
        }
    }
}
