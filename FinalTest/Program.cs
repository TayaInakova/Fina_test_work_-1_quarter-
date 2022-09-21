int LengthNewArrayFind(string[] startArray, int size)
{
    int j = 0;
    for (int i = 0; i < startArray.Length; i++)
    {
        if (startArray[i].Length <= size)
        {
            j++;
        }
    }
    return j;
}

void FillNewArray(string[] array1, string[] array2, int length)
{

    for (int i = 0, j = 0; i < array1.Length; i++)
    {
        if (array1[i].Length <= length)
        {
            array2[j] = array1[i];
            j++;
        }
    }
}

void PrintArray(string[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i]);
        if (i < arr.Length - 1)
        {
            Console.Write(", ");
        }
    }
    Console.Write("]");
}

void Start(string[] array)
{
    int n = LengthNewArrayFind(array, 3);
    string[] newArray = new string[n];
    FillNewArray(array, newArray, 3);
    PrintArray(newArray);
    Console.WriteLine();
}

string[] exampleArray = { "me", "mom", "jelly", "15", "aquarium", "gladiolus", "you" };
Start(exampleArray);