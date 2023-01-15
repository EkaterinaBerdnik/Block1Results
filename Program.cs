string[] array1 = new string[] {"Hello", "2", "World", ":-)"};
string[] array2 = new string[] {"1234", "1567", "-2", "computer science"};
string[] array3 = new string[] {"Russia", "Denmark", "Kazan"};

void PrintArray(string[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
}

void DiffArray(string[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        string element = arr[i];
        if (element.Length <= 3)
        {
            arr[i] = element;
        }
        else arr[i] =  string.Empty;
    }
}

PrintArray(array1);
DiffArray(array1);
Console.Write("Элементы, длина которых меньше или равна 3 символа: ");
PrintArray(array1);
Console.WriteLine();

PrintArray(array2);
DiffArray(array2);
Console.Write("Элементы, длина которых меньше или равна 3 символа: ");
PrintArray(array2);
Console.WriteLine();

PrintArray(array3);
DiffArray(array3);
Console.Write("Элементы, длина которых меньше или равна 3 символа: ");
PrintArray(array3);