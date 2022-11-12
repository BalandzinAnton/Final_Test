// Написать программу, которая из имеющегося массива строк формирует массив 
// из строк, длина которых меньше либо равна 3 символа. Первоначальный массив 
// можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись
// исключительно массивами.

using static System.Console;
Clear();
string[] array = {"My", "name", "is", "Anton", ".", "I", "am", "32y.o."};
int size = CountNum(array);
string[] SortArray = GetNewArray(array, size);
PrintArray(SortArray);
string[] GetNewArray(string[] Array, int Count)
{
    string[] result = new string[Count];
    int j = 0;
    for(int i=0; i<Array.Length; i++)
    {
        if (Array[i].Length<4)
        {
        result[j] = Array[i];
        j++;
        }
    }
    return result;
}

int CountNum(string[] Array)
{
    int count = default;
    for (int i=0; i<Array.Length; i++)
    {
        if (Array[i].Length<4)
        {
            count+=1;
        }
    }
    return count;
}

void PrintArray(string[] inArray)
{
    Write("[");
    for(int i=0; i<inArray.Length-1; i++)
    {
        Write($"{inArray[i]},");
    }
    Write($"{inArray[inArray.Length-1]}]");
}