using System.Diagnostics.CodeAnalysis;

int[] arr = [1,2,3,4,5,2];    
int sum = 0;
for (int i = 0; i < arr.Length; i++)
{
    sum= sum + arr[i];

}
Console.WriteLine(sum);