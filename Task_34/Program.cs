// Задайте массив, заполненный случайными положительными трехзначными числами.
// Напишите программу, которая покажет кол-во четных чисел в массиве.

Console.Write("Задайте размер массива: ");
int size = int.Parse(Console.ReadLine());
int[] nums = new int[size];

int count = 0;

var newRnd = new Random();
Console.Write("Массив : [");

for (int i = 0; i < size; i++)
{
    nums[i] = newRnd.Next(100, 1000);
    Console.Write(nums[i] + " ");
}
Console.Write("]");

for (int i = 0; i < size; i++)
{
    if (nums[i] % 2 == 0) 
    {
        count += 1;
    }
}
Console.WriteLine();

Console.WriteLine($"Количество четных элементов в массиве = {count}");