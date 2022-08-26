// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

int[] arr = new int[8];
int sum = 0, leng = arr.Length;
Console.WriteLine("Массив случайных чисел: ");
for (int i = 0; i < leng; i++)
{
    arr[i] = new Random().Next(-42, 43);
    Console.WriteLine(i + "-й элемент: " + arr[i] + "; ");
    if (i % 2 != 0) sum = sum + arr[i];
}
Console.WriteLine("Сумма элементов на нечётных позициях: " + sum);
