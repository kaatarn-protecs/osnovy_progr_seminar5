// Задача 33: Задайте массив. Напишите программу, которая
// определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// 3; массив [6, 7, 19, 345, 3] -> да
Console.WriteLine("Введите число ");
int getDigit = Convert.ToInt32(Console.ReadLine());


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

bool GetDigit(int [] array, int digit)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == digit) return true;
    }
    return false;
}

void PrintArray (int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if(i < array.Length - 1) Console.Write($"{array[i]},");
        else Console.Write(array[i]);
    }
    Console.Write("]");
}

int[] arrayGen = CreateArrayRndInt(5, -5, 5);
bool select = GetDigit(arrayGen, getDigit);

// 4; массив [6, 7, 19, 345, 3] -> нет
if (select == true) 
{
    Console.Write($"{getDigit}, массив ");
    PrintArray(arrayGen);
    Console.Write($" -> Да");
}
else 
{
    Console.Write($"{getDigit}, массив ");
    PrintArray(arrayGen); Console.Write($" -> Нет");
}




