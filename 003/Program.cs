// Задача 3: Задайте массив вещественных чисел. 
//Найдите разницу между максимальным и минимальным элементов массива.
//[3, 7.4, 22.3, 2, 78] -> 76

double[] CreateArray(int length)
{
    double[] answer = new double[length];
    Random rnd = new Random();
    for (int i = 0; i < answer.Length; i++)
    {
        answer[i] = rnd.NextDouble() + rnd.Next(0, 50);
    }
    return answer;
}
void PrintArray(double[] array)
{
    for (int j = 0; j < array.Length; j++)
    {
        Console.Write($"{array[j]:0.#} \t");
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
double Difference(double[] array)
{
    double MinArray = array[0];
    double MaxArray = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > MaxArray)
        {
            MaxArray = array[i];
        }

        if (array[i] < MinArray)
        {
            MinArray = array[i];
        }
    }
    double result = MaxArray - MinArray;
    return result;
}

int length = Prompt("Введите размер массива ");
double[] array1 = CreateArray(length);
PrintArray(array1);
double Diff = Difference(array1);
System.Console.WriteLine($"Разность между максимальным и минимальным значением массива равна {Diff:0.##}");