int elementsCount = InputValue("elements");

string[] array = new string[elementsCount];

Console.WriteLine();
FillArray(array);
methodArray(array);
Console.WriteLine();

int InputValue(string element)
{
    int value;
    Console.Write($"Enter count of {element} in the array: ");
    while (!int.TryParse(Console.ReadLine(), out value))
    {
        Console.WriteLine("Error. Try again.");
        Console.Write($"Enter count of {element} in the array: ");
    }
    return value;
}

void FillArray(string[] Inputarray)
{
    int count = 1;
    for (int i = 0; i < Inputarray.Length; i++)
    {
        Console.Write($"Enter value of {count} element in the array: ");
        Inputarray[i] = Console.ReadLine();
        count++;
    }
    Console.WriteLine();
}

void methodArray(string[] array)
{
    string[] newarr = new string[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        if (i == 0)
            Console.Write($"{array[i]}, ");
        else if (i == newarr.Length - 1)
            Console.Write($"{array[i]} => ");
        else
            Console.Write($"{array[i]}, ");
    }
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            newarr[i] = array[i];
            if (i == 0)
                Console.Write($"{newarr[i]}, ");
            else if (i == newarr.Length - 1)
                Console.Write($"{newarr[i]}");
            else
                Console.Write($"{newarr[i]}, ");
        }
    }
    Console.WriteLine();
}