
using System;
using static System.Console;

Clear();

void PrintArray(int[] array)
{
    Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Write(array[i] + ", ");
    }
    Write("\b\b]\n\r");
}

int[] GetArray(int size, int min, int max)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(min, max + 1);
    }
    return array;
}

//--------------------------------------------------------------------------
//Задача 34: 
//Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

/*

//Поиск кол-ва четных элементов массива 
int GetCountInArray(int[] inArray)
{
    int count = 0;
    foreach (int item in inArray)
    {
        if (item % 2 == 0)
        {
            count++;
        }
    }
    return count;
}

try
{
    Write("Введите кол-во элементов массива: ");
    int N = Convert.ToInt32(ReadLine());

    int[] Array = GetArray(N, 100, 1000);

    PrintArray(Array);

    int count = GetCountInArray(Array);

    WriteLine($"Четных элементов: {count}");

}
catch (OverflowException)
{
    Write("Переполнение! Ввели слишком большое число!");
}
catch (FormatException)
{
    Write("Ожидалось число!");
}
catch
{
    Write("Ошибка выполнения!");
}
*/

//---------------------------------------------------------------------------------

//Задача 36: 
//Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

/*
//Поиск суммы элементов стоящх на нечетных позициях
int GetCountInArray(int[] inArray)
{
    int sum = 0;
    for (int i = 0; i < inArray.Length; i++)
        if (i % 2 != 0) sum += inArray[i];
    return sum;
}


try
{
    Write("Введите кол-во элементов массива: ");
    int N = Convert.ToInt32(ReadLine());

    int[] Array = GetArray(N, 1, 10);

    PrintArray(Array);

    int sum = GetCountInArray(Array);

    WriteLine($"Сумма нечетных элементов: {sum}");
}
catch (OverflowException)
{
    Write("Переполнение! Ввели слишком большое число!");
}
catch (FormatException)
{
    Write("Ожидалось число! Ввели непонять что!");
}
catch
{
    Write("Ошибка выполнения!");
}
*/

//Задача 38: 
//Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

//Печать массива вещественных чисел 
void PrintArrayDouble(double[] array)
{
    Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Write(array[i] + "| ");
    }
    Write("\b\b]\n\r");
}
//Создание массива размером N вещественных элементов, полученных рандомно в указанном диапазоне
double[] GetArrayDouble(int size, int min, int max)
{
    double[] array = new double[size];
    for (int i = 0; i < size; i++)
    {
        //вариант 1
        //var random = new Random();
        //array[i] =  Math.Round(Convert.ToDouble(random.Next(min*100, max*100 + 1)/100.0),2);
        
        //вариант 2
        //var random = new Random();
        //array[i] = random.Next(min, max + 1) + Math.Round(random.NextDouble(), 2);
        
        //вариант 3 - 
        array[i] =(new Random().Next(min, max + 1)) +  (Math.Round( new Random().NextDouble(),2));
    }
    return array;
}
//Поиск Максимального элемента массива
double GetMaxInArray(double[] inArray)
{
    double max = inArray[0];
    foreach (double item in inArray)
    {
        if (item > max) max = item;
    }
    return max;
}
//Поиск Минимального элемента массива
double GetMinInArray(double[] inArray)
{
    double min = inArray[0];
    foreach (double item in inArray)
    {
        if (item < min) min = item;
    }
    return min;
}
//Поиск Минимального и максимального элемента массива
double[] GetMinMaxInArray(double[] inArray)
{
    double[] ret = new double[2];
    ret[0] = inArray[0];
    ret[1] = inArray[0];
    foreach (double item in inArray)
    {
        if (item < ret[0]) ret[0] = item;
        if (item > ret[1]) ret[1] = item;
    }
    return ret;
}

try
{
    Write("Введите кол-во элементов массива: ");
    int N = Convert.ToInt32(ReadLine());

    double[] Array = GetArrayDouble(N, 1, 99);

    PrintArrayDouble(Array);

    WriteLine("Вариант 1");
    double maxEl = GetMaxInArray(Array);
    double minEl = GetMinInArray(Array);
    double razn = maxEl - minEl;
    WriteLine($"Максимальный элемент: {maxEl}\r\nМинимальный элемент: {minEl}\r\nРазницв максимального и минимального элементов: {razn:f2}");

    WriteLine("Вариант 2");
    double[] minMaxEl = GetMinMaxInArray(Array);
    WriteLine($"Максимальный элемент: {minMaxEl[1]}\r\nМинимальный элемент: {minMaxEl[0]}\r\nРазницв максимального и минимального элементов: {(minMaxEl[1]-minMaxEl[0]):f2}");
    
}
catch (OverflowException)
{
    Write("Переполнение! Ввели слишком большое число!");
}
catch (FormatException)
{
    Write("Ожидалось число!");
}
catch
{
    Write("Ошибка выполнения!");
}


