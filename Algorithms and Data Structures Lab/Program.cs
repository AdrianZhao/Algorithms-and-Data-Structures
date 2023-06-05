using System;
using System.Collections.Generic;
using System.Linq;
// Helper method to find the highest value in the argument List<int> and return an int. They are both int.
static int GetHighestValueInList(List<int> list)
{
    int max = int.MinValue; // To nake sure the negative numbers also be counted
    foreach (int num in list)
    {
        if (num > max)
            max = num;
    }
    return max;
}
// Program 1
Console.WriteLine("Prgoram 1:");
List<List<int>> lists = new List<List<int>>{ new List<int> { 1, 5, 3 }, new List<int> { 9, 7, 3, -2 }, new List<int> { 2, 1, 2 } };
List<int> maxNumbers = MaxNumbersInLists(lists);
for (int i = 0; i < maxNumbers.Count; i++)
{
    Console.Write($"List {i} has a maximum of {maxNumbers[i]}, ");
}
// Creating the method with arguments type of List<int> and return type of List<int>
// The time complexity of below method should be O(n)^2
static List<int> MaxNumbersInLists(List<List<int>> lists)
{
    if (lists.Count == 0)
    {
        throw new Exception("Please enter a non-empty list");
    }
    List<int> maxNumbers = new List<int>();
    for (int i = 0; i < lists.Count; i++)
    {
        int max = GetHighestValueInList(lists[i]);
        maxNumbers.Add(max);
    }
    return maxNumbers;
}
Console.WriteLine();
// Program 2
Console.WriteLine("Prgoram 2:");
List <List<int>> courses = new List<List<int>>
{ new List<int> { 85, 92, 67, 94, 94 }, new List<int> { 50, 60, 57, 95 }, new List<int> { 95 } };
Console.WriteLine(HighestGrade(courses));
// Creating the method with arguments type of List<int> and return type of void
// The time complexity of below method should be O(n + n)*(n) + O(n)
static string HighestGrade(List<List<int>> courses)
{
    if (courses.Count == 0)
    {
        throw new Exception("Please enter a non-empty list");
    }
    int highestGrade = 0;
    List<int> index = new List<int>();
    int temp = 0;
    for (int i = 0; i < courses.Count; i++)
    {
        for (int j = 0; j < courses[i].Count; j++)
        {
            if (courses[i][j] < 0 || courses[i][j] > 100)
            {
                throw new Exception("Please enter valid number");
            }
        }
        int max = GetHighestValueInList(courses[i]);
        if (max > highestGrade)
        {
            highestGrade = max;
            temp = i;
        }
    }
    index.Add(temp);
    for (int j = 0; j < courses.Count; j++)
    { 
        if (courses[j].Contains(highestGrade) && j != temp)
        {
            index.Add(j);
        }
    }
    string indexString = string.Join(", ", index);
    return $"The highest grade is {highestGrade}. This grade was found in class(es) {indexString}";
}
// Program 3
Console.WriteLine("Prgoram 3:");
List<int> orderedList = OrderByLooping(new List<int> { 6, -2, 5, 3 });
foreach (int i in orderedList)
{
    Console.Write(i + ", ");
}
// Creating the method with arguments type of List<int> and return type of List<int>
// The time complexity of below method should be O(n)^2
static List<int> OrderByLooping(List<int> list)
{
    if (list.Count == 0)
    {
        throw new Exception("Please enter a non-empty list");
    }
    for (int i = 0; i < list.Count - 1; i++)
    {
        for (int j = 0; j < list.Count - i - 1; j++)
        {
            if (list[j] > list[j + 1])
            {
                int temp = list[j];
                list[j] = list[j + 1];
                list[j + 1] = temp;
            }
        }
    }
    return list;
}