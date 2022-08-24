// Задача 32: Напишите программу замена элементов
// массива: положительные элементы замените на
// соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]

int[] CreateArrayRndInt(int size, int min, int max) // Метод создания массива
{
    int[] array = new int[size];
    Random rnd = new Random(); // Создаем объект рандом

    for (int i = 0; i < size; i++)
    {
        array[i] = rnd.Next(min, max + 1);
    }
    return array;
}

int [] ReplacePosElemArray(int [] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = -array[i];
    }
    return array;
}

void PrintArray (int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if(i < array.Length - 1) Console.Write($"{array[i]},");
        else Console.Write(array[i]);
    }
    Console.WriteLine("]");
}

int[] a = CreateArrayRndInt(4, -10, 11);
PrintArray(a);

int[] b = ReplacePosElemArray(a);
PrintArray(b);
