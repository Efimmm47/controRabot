Console.WriteLine("Введите массив строк через пробел");
string inPutString = Console.ReadLine();
string[] userArray = inPutString.Split(' ');

string[] resultArray = new string[userArray.Length];

SearchElemnentsBigerThenFour(userArray, resultArray);
Console.Write($"Элементы со значением меньше либо равно 3 символам: ");
PrintArray(resultArray);

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
void SearchElemnentsBigerThenFour(string[] inputArray, string[] resultArray)
{
    int count = 0;
    for (int i = 0; i < inputArray.Length; i++)
    {
        if (inputArray[i].Length < 4)
        {
            resultArray[count] = inputArray[i];
            count++;
        }
    }
}