int CheckN(int n)
{
    while (n == 0 || n < 0)
    {
        Console.WriteLine("You have entered 0 (zero) or less, there is nothing to check");
        Console.WriteLine("Enter how many 'words' (word, number, symbol, etc) you need to check (input an integer)");
        n = Convert.ToInt32(Console.ReadLine());
    }
    return n;
}

void PrintArray(string[] array)
{
    int i = 0;
    int n = array.Length;
    while (i < n)
    {
        Console.Write($"{array[i]}");
        i++;
        if (i < n)
            Console.Write($", ");
    }
    Console.WriteLine($"");
}





Console.WriteLine("Enter how many 'words' (word, number, symbol, etc) you need to check (input an integer)");
int n = Convert.ToInt32(Console.ReadLine());
n = CheckN(n);
int k = n;
string[] array = new string[n];
string[] arrayFinal = new string[k];

Console.WriteLine("Type a 'word' (word, number, symbol, etc) you want to check and press enter one by one");
int i = 0;
while (i < n)
{
    array[i] = Console.ReadLine();
    i++;
}

Console.Write($"Your word(s): ");
PrintArray(array);

i = 0;
k = 0;
n = array.Length;
while (i < n)
{
    if (array[i].Length <= 3)
    {
        arrayFinal[k] = array[i];
        k++;
    }
    i++;
}

int d = n - k;
Array.Resize(ref arrayFinal, arrayFinal.Length - d);

if (k == 0)
    Console.WriteLine("There are no 'words' less than or equal to 3 characters");
else
{
    Console.Write($"The total number of 'words' containing 3 characters or less is {k}: ");
    PrintArray(arrayFinal);
}