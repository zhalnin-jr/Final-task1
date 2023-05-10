string[] InputArray(string[] arr)
{
    Console.WriteLine("Enter elements of array via enter button");
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = Convert.ToString(Console.ReadLine());
    }
    return arr;
}

void PrintArray(string[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} \t");
    }
}

Console.Clear();
Console.WriteLine("Enter number of array elements: ");
int n = Convert.ToInt32(Console.ReadLine());
string[] array = new string[n];
InputArray(array);
Console.WriteLine("Input array:");
PrintArray(array);

int m = 0;
for (int i = 0; i < array.Length; i++)
{
    string b = array[i];
    int a = b.Length;
    if (a <= 3)
    {
        m++;
    }
}
string[] newArray = new string[m];
int j = 0;
for (int i = 0; i < array.Length; i++)
{
    string b = array[i];
    int a = b.Length;
    if (a <= 3)
    {
        newArray[j] = array[i];
        j++;
    }
}
Console.WriteLine();
Console.WriteLine("Result:");
PrintArray(newArray);