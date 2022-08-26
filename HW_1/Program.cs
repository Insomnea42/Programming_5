// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

int[] arr = new int[4];
int sum_krat = 0, leng = arr.Length;
Console.Write("Массив случайных положительных трёхзначных чисел: ");
for (int i = 0; i < leng; i++)
{
    arr[i] = new Random().Next(100, 1000);
    Console.Write(arr[i] + " ");
    if (arr[i] % 2 == 0) sum_krat++;
}
Console.WriteLine("Колличество кратных 2: " + sum_krat);
