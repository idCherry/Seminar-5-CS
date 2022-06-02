// Найдите произведение пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.

Console.Write("Введите размер массива: ");
int size = int.Parse(Console.ReadLine());

int[] Array = new int[size];

var newRnd = new Random();
Console.Write("Массив: [");
for (int i = 0; i < size; i++)
{
    Array[i] = newRnd.Next(-10, 10);
    Console.Write(Array[i] + " ");
}
Console.Write("]");

Console.WriteLine();

int[] res = new int [Array.Length/2];

Console.Write("Произведение крайних элементов: ");
for (int i = 0; i < res.Length; i++)
{
    res[i] = Array[i] * Array[Array.Length - 1 - i];
    Console.Write(res[i] + " ");
}
