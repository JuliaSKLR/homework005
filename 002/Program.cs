// Задача 2: Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 26
//[-4, -6, 4, 67] -> 0

int[] CreateArray(int length)
{
    int[] answer = new int[length];
    Random rnd = new Random();
    for (int i = 0; i < answer.Length; i++)
    {
        answer[i] = rnd.Next(-100, 100);
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

int SumUnEven(int[] array)
{
    int value = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 == 0)                     //индекс нечетной позиции сам по себе четный )
        {
            value = value + array[i];
        }
    }
    return value;
}
int length = Prompt("Введите размер массива ");
int[] array = CreateArray(length);
PrintArray(array);
int result = SumUnEven(array);
System.Console.WriteLine($"Сумма элементов на нечетной позиции = {result}");