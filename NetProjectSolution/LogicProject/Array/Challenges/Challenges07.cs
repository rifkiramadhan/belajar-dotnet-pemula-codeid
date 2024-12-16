namespace LogicProject.Array.Challenges
{
    internal class Challenges07
    {
        public static int[] MergeList(int[] list1, int[] list2)
        {
            int[] result = new int[list1.Length + list2.Length];

            int k = 0;

            for (int i = 0, j = 0; i < list1.Length || j < list2.Length;)
            {
                if (i >= list1.Length)
                {
                    result[k] = list2[j];
                    j++;
                }
                else if (j >= list2.Length)
                {
                    result[k] = list1[i];
                    i++;
                }
                else if (list1[i] <= list2[j])
                {
                    result[k] = list1[i];
                    i++;
                }
                else
                {
                    result[k] = list2[j];
                    j++;
                }

                k++;
            }

            return result;
        }
    }
}
