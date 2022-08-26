// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

double[] arr = new double[6]; // вещественные
double sum = 0;
double a;
int leng = arr.Length;
Console.WriteLine("Массив случайных чисел: ");
for (int i = 0; i < leng; i++)
{
    a = new Random().Next(0, 43);
    a = a / 0.423; //преобразование в вещественные
    arr[i] = a;
    Console.WriteLine(i + "-й элемент: " + arr[i] + "; ");
}

double max = arr[0], min = arr[0];

for (int i = 1; i < leng; i++)
{
    if (max <= arr[i]) max = arr[i];
    else
    {
        if (min >= arr[i]) min = arr[i];
    }
}
Console.WriteLine("Максимум: " + max + ". Минимум: " + min);
sum = max - min;
Console.WriteLine("Разница: " + sum);