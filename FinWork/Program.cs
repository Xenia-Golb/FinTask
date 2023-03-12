string[] array = new string[5] { "Wow", "the", "world", "is", "mine" };
string[] newArray = new string[array.Length];

void FindWordInArray(string[] array1, string[] array2)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            newArray[count] = array[i];
            count++;
        }
    }
}
void PrintArray(string[] array)
{
    Console.WriteLine($"[{string.Join(", ", array)}] -> [{string.Join(" ", newArray)}]");
}
Console.Clear();
FindWordInArray(array, newArray);
PrintArray(array);
