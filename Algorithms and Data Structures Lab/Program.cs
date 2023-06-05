// Program 1
using System.Text;

Console.WriteLine("Program 1:");
int[] nums = new int[] { 1, 2, 3, 4, 7, 9, 2, 4 };
List<int> duplicates = new List<int>();
HashSet<int> nonDuplicates = new HashSet<int>();

foreach (int num in nums)
{
    if (nonDuplicates.Contains(num))
    {
        duplicates.Add(num);
    }
    else
    {
        nonDuplicates.Add(num);
    }
}
foreach (int num in duplicates)
{
    Console.Write(num + " ");
}
Console.WriteLine();
// Program 2
Console.WriteLine("Program 2:");
int[] arr1 = new int[] { 1, 2, 3, 4, 5 };
int[] arr2 = new int[] { 2, 5, 7, 9, 13 };
int[] merged = new int[arr1.Length + arr2.Length];
int i = 0;
int j = 0;
int k = 0;
while (i < arr1.Length && j < arr2.Length)
{
    if (arr1[i] < arr2[j])
    {
        merged[k] = arr1[i];
        i++;
    }
    else
    {
        merged[k] = arr2[j];
        j++;
    }
    k++;
}
while (i < arr1.Length)
{
    merged[k] = arr1[i];
    i++;
    k++;
}
while (j < arr2.Length)
{
    merged[k] = arr2[j];
    j++;
    k++;
}
foreach (int num in merged)
{
    Console.Write(num + " ");
}
Console.WriteLine();
// Program 3
Console.WriteLine("Program 3:");
int myNum = 3415;
string myString = myNum.ToString();
StringBuilder reversedNum = new StringBuilder("", myString.Length);
for (int l = myString.Length - 1; l >= 0; l--)
{
    reversedNum.Append(myString[l]);
}
Console.WriteLine(reversedNum);
// The time complexity of my solution is O(n)