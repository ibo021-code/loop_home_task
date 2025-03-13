int[] arr = [34, 23, 43,1, 54, 56,];

for (int i = 0; i < arr.Length; i++)
{
    if (arr[i] <= 1)
    {
        Console.WriteLine($"{arr[i]} ededi ne sadedir ne murekkeb");
    }
    else
    {
        for (int j = 2; j < arr[i]; j++)
        {
            if (arr[i] % j == 0)
            {
                Console.WriteLine($"{arr[i]} ededi murekkebdir");
                break;
            }
            else
            {
                Console.WriteLine($"{arr[i]} ededi sadeddir");
                break;
            }
        }


    }
}
