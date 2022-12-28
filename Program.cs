using System;
using static System.Console;

Clear();
string [] array = new string[] {"All", "you", "need", "is", "love", "<3"}; 
//string [] NewArray = new string[array.Length];

PrintArray(array);
WriteLine();
string [] NewArray = ChangeStringArray(array);
PrintArray(NewArray);



string [] ChangeStringArray(string[] array)
{
    string [] NewArray = new string[array.Length];
    int j = 0; 
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            NewArray[j] = array[i];
            j++;
        }
    }
    return NewArray;
}


void PrintArray(string[] inArray)
{
    for (int i = 0; i < inArray.Length; i++)
    {
        Write($"{inArray[i]} ");
    }
    WriteLine();
}