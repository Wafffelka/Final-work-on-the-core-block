Console.Write("Введите размер массива: ");
int LengthArray = Convert.ToInt32(Console.ReadLine());
string[] InitialArray = FillingTheArray(LengthArray);
NewArrayOutput(CheckingTheLengthOfElements(InitialArray));

string[] FillingTheArray(int size)
{
    string[] array = new string[size]; 
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write("Введите строку: ");
        array[i] = Convert.ToString(Console.ReadLine());
    }
    return array;
}

string[] CheckingTheLengthOfElements(string[] ArrayСheck)
{
    d
}


void NewArrayOutput(string[] NArray)
{
    Console.WriteLine($"Итоговый массив: [ {string.Join(", ", NArray)} ]");
}