// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементами массива.

Console.Write("Введите размер массива: ");
int size = int.Parse(Console.ReadLine());
int[] nums = new int[size];

int max = nums[0];
int min = nums[0];

var newRnd = new Random();
Console.Write("Рандомный массив: [");
for (int i = 0; i < size; i++)
{
    nums[i] = newRnd.Next(-100, 100);
    Console.Write(nums[i] + " ");
}
Console.Write("]");

Console.WriteLine();

Console.Write("Максимальный элемент масива: ");
for (int i = 0; i < size; i++)
{
    if (nums[i] > max) max = nums[i];
}
Console.Write(max);

Console.WriteLine();

Console.Write("Минимальный элемент масива: ");
for (int i = 0; i < size; i++)
{
    if (nums[i] < min) min = nums[i];
}
 Console.Write(min);

 Console.WriteLine();
 
Console.WriteLine($"Разница между максимальным и минимальным элементами массива = {max - min}");
    
