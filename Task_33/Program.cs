// Задайте массив. Напишите программу, которая определяет, присутствует ли
// заданное число в массиве

Console.Write("Задайте размер массива: ");
int size = int.Parse(Console.ReadLine());

Console.Write("Задайте число, чтобы проверить, есть ли оно в массиве: ");
int findDigit = int.Parse(Console.ReadLine());

int[] nums = new int[size];

var newRnd = new Random();
string result = $"Число {findDigit} не присутствует в массиве";
Console.Write("Рандомный массив: [");
for (int i = 0; i < size; i++)
{
    nums[i] = newRnd.Next(-10, 10);
    Console.Write(nums[i] + " ");
}
Console.Write("]");

Console.WriteLine();

// for (int i = 0; i < size; i++)
// {
//     if (nums[i] == findDigit) Console.WriteLine($"Число {findDigit} присутствует в массиве");
//     else Console.WriteLine($"Число {findDigit} не присутствует в массиве");
//     break;
// }

for (int i = 0; i < size; i++)
{
    if (nums[i] == findDigit) result = $"Число {findDigit} присутствует в массиве";
}
Console.WriteLine(result);