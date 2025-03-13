int[] arr = [ 1, 5,6,3, 6, 7,];
int min = arr[0];
for (int i = 0; i < arr.Length; i++)
{
    if (arr[i] < min)
    {
        min= arr[i];
    }
}
Console.WriteLine(min);