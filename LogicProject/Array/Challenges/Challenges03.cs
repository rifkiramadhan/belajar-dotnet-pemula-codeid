namespace LogicProject.Array.Challenges
{
    internal class Challenges03
    {
        public static int[] AddOnePlus(int[] arr)
        {
            if (arr[arr.Length - 1] == 9)
            {
                int[] result = new int[arr.Length];

                for (int i = 0; i < arr.Length; i++)
                {
                    result[i] = arr[i];
                }

                for (int i = result.Length - 1; i >= 0; i--)
                {
                    if (result[i] < 9)
                    {
                        result[i]++;
                        return result;
                    }

                    result[i] = 0;
                }

                int[] newArray = new int[result.Length + 1];
                newArray[0] = 1;
                return newArray;
            }
            return arr;
        }

    }
}
