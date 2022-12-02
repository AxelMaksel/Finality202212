string[] array = new string[4] { "hi", "Hello", "Star", "23" };
int arrayLength = array.Length;
int min = 3; // ограничитель, фильтр массива
int sizeNewArray = CountElementTrue(array);
string[] newArray = new string[sizeNewArray];
newArray = FilterArray(array);
PrintArray(newArray);


int CountElementTrue(string[] arr)
{
    int count = 0;
    for (int i = 0; i < arrayLength; i++)
    {
        if (arr[i].Length <= min) count++;
    }
    return count;
}
string[] FilterArray(string[] arr)
{
    int k = 0;
    for (int i = 0; i < arrayLength; i++)
    {
        if (arr[i].Length <= min)
        {
            newArray[k] = arr[i];
            k++;
        }
    }
    return newArray;
}

void PrintArray(string[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"'{arr[i]}', ");
        else Console.Write($"'{arr[i]}'");
    }
    Console.WriteLine("]");
}