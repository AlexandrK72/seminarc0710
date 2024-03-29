﻿// Задача 39: Напишите программу, которая перевернёт
// одномерный массив (последний элемент будет на первом
// месте, а первый - на последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]

int Prompt(string message)
{
    System.Console.Write(message);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}

int[] RandomNumbersArray(int min, int max, int size)
{
    int[] arr = new int[size];
    Random rnd = new Random();

    for (int i = 0; i < size; i++)
    {

        arr[i] = rnd.Next(min, max + 1);

    }
    return arr;
}

void ReversArray(int[] arr)
{
    for (int i = 0; i < arr.Length/2; i++)
    {
        int temp = arr[i];
        arr[i] = arr[arr.Length - 1 -i];
        arr[arr.Length - 1 -i] = temp;
    }
}
// ReversArray


 void PrintArray(int[] arr)
 {
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if(i < arr.Length-1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]} ");
    }
     Console.WriteLine("]");
}

int minnumber = Prompt("Введите миннимальное число массива = ");

int maxnumber = Prompt("Введите максимальное число массива = ");


int sizenumber = Prompt("Введите длину массива ");

int[] array = RandomNumbersArray(minnumber, maxnumber, sizenumber);




Console.Write(" [");
PrintArray(array);
Console.Write("] -> ");

ReversArray(array);
PrintArray(array);
