namespace LogicProject.Array.Challenges
{
    internal class Challenges02
    {
        public static bool IsPalindrome(string[] arr)
        {
            for (int i = 0; i < arr.Length / 2; i++)
            {
                if (arr[i] != arr[arr.Length - 1 - i])
                {
                    return false;
                }
            }
            return true;
        }
    }
}
