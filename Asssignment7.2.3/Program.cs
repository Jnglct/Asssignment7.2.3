namespace Asssignment7._2._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(IsAnagram("anagram", "nagaram"));
        }
        static bool IsAnagram(string s, string t)
        {
            int count = 0;
            if (s.Length != t.Length)
            {
                return false;
            }
            foreach (char sitem in s)
            {
                foreach (char titem in t)
                {
                    if (sitem == titem)
                    {
                        count++;
                        break;
                    }
                }
            }
            if (count == s.Length)
            {
                return true;
            }
            return false;
        }
    }
}
