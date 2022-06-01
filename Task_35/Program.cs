// Задайте одномерный массив из 123 элементов случайных чисел.
// Найдите количество элементов массива, значения которых лежат в отрезке [10, 99].


int[] array = new int[123];
int count = 0;

var newRnd = new Random();
Console.Write("Рандомный массив из 123 элементов: [");
for (int i = 0; i < array.Length; i++)
{
    array[i] = newRnd.Next(0, 500);
    Console.Write(array[i] + " ");
}
Console.Write("]");

Console.WriteLine();

for (int i = 0; i < array.Length; i++)
{
    if (array[i] >= 9 && array[i] <= 99)
    count++;
}
Console.WriteLine($"Количество значений в промежутке от 10 до 99 = {count}");

