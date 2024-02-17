﻿Console.Write("Введите размер массива: ");
int LengthArray = Convert.ToInt32(Console.ReadLine());
string[] InitialArray = FillingTheArray(LengthArray);
ArrayOutput(CheckingTheLengthOfElements(InitialArray));

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
    string[] NewArray = Array.Empty<string>();
    for(int i = 0; i < ArrayСheck.Length; i++)
    {
        if(ArrayСheck[i].Length < 4)
        {
            Array.Resize(ref NewArray, NewArray.Length + 1);
            NewArray[^1] = ArrayСheck[i];
        }
    }
    return NewArray;
}


void ArrayOutput(string[] NArray)
{
    Console.WriteLine($"Итоговый массив: [ {string.Join(", ", NArray)} ]");
}