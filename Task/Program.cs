string[] CreateUserStringArray(int length)
{
    string[] array = new string[length];

    for(int i = 0; i < length; i++)
    {
        Console.Write("Input array element: ");
        string? value = Console.ReadLine();
        while(value == String.Empty)
        {
            Console.Write("You haven't inputed a value. Input array element: ");
            value = Console.ReadLine();
        }
        if(value != null) array[i] = value;
    }
    return array;
}

string[] CreateStringArray(string[] array, int numberSymbol = 3)
{
    int lengthNewArray = 0;
    for(int i = 0; i < array.Length;i++)
        if(array[i].Length <= numberSymbol) lengthNewArray++;

    string[] newArray = new string[lengthNewArray];

    for(int i = 0, j = 0; i < array.Length; i++)
    {
        if(array[i].Length <= numberSymbol)
        {
            newArray[j] = array[i];
            j++;
        }
    }
    return newArray;
}

void PrintStringArray(string[] array)
{
    Console.Write("Created array: [");
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write("'" + array[i] + "'");
        if(i < array.Length -1) Console.Write(",");
    }
    Console.Write("]");
    Console.WriteLine();
}

try
{
    Console.Write("Input array size: ");
    int sizeArray = Convert.ToInt32(Console.ReadLine());
    while(sizeArray < 0)
    {
        Console.WriteLine("Array size is a positive integer.");
        Console.Write("Input new value: ");
        sizeArray = Convert.ToInt32(Console.ReadLine());
    }
    if(sizeArray == 0) 
        Console.WriteLine("Array size is 0. Empty array: []");
    else 
    {
        string[] stringArray = CreateUserStringArray(sizeArray);
        PrintStringArray(stringArray);
        string[] newStringArray = CreateStringArray(stringArray);
        PrintStringArray(newStringArray);
    }
}
catch(Exception)
{
    Console.WriteLine("Invalid input. Conversion is not posible!");
}
