//  Задача 1: Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2


int[] CreateArray(int length)
{
    int[] answer = new int[length];
    Random rnd = new Random();
    for (int i = 0; i < answer.Length; i++)
    {
        answer[i] = rnd.Next(100, 999);
    }
    return answer;
}
void PrintArray(int[] array)
{
    for (int j = 0; j < array.Length; j++)
    {
        Console.Write(array[j] + "\t");
    }
    System.Console.WriteLine();
}
int Prompt(string message)
{
    System.Console.Write(message);
    string readValue = Console.ReadLine();
    int result = int.Parse(readValue);
    return result;
}
int SumEven(int[] array)
{
    int value = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            value++;
        }
    }
    return value;
}
int length = Prompt("Введите размер массива");
int[] array = CreateArray(length);
PrintArray(array);
int count = SumEven(array);
System.Console.WriteLine($"Колличество четных элементов = {count}");
