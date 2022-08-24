// Задача 38: 
// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементами массива.

// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2

double[] CreateArrayRndDouble(int size, double min, double max) // Метод создания массива
{
    double[] array = new double[size];
    Random rnd = new Random(); // Создаем объект рандом

    for (int i = 0; i < size; i++)
    {
        array[i] = Math.Round((rnd.NextDouble() * (max - min) + min), 2);
    }
    return array;
}

void PrintArrayDouble(double[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}; ");
        else Console.Write(array[i]);
    }
    Console.Write("]");
}

double DifferceDouble(double[] arr2)
{
    double differ = 0;
    double max = arr2[0];
    double min = arr2[0];
    for (int i = 0; i < arr2.Length; i++)
    {
        if (arr2[i] > max) max = arr2[i];
        if (arr2[i] < min) min = arr2[i];
    }
    Console.WriteLine($"{min}");
    Console.WriteLine($"{max}");
    return Math.Round(differ = max - min, 2);

}

double[] arr = CreateArrayRndDouble(10, 1, 1000);
double res = DifferceDouble(arr);
PrintArrayDouble(arr);
Console.Write($" -> {res}");
