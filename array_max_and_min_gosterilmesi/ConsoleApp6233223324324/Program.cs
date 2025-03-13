int[] arr = [1, 2, 3,6,12, 4, 5];
int max = arr[0];
int min = arr[0];
int maxIndex = 0;
int minIndex = 0;
for (int i = 0; i < arr.Length; i++)
{
    if (arr[i] > max)
    {
        max = arr[i];
        maxIndex = i;
    }
    if (arr[i] < min)
    {
        min = arr[i];
        minIndex = i;   
    }

}
Console.WriteLine("max eded  "+max);
Console.WriteLine("min eded  "+min);
Console.WriteLine("max index  " + maxIndex);
Console.WriteLine("min index  " + minIndex);    