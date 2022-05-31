// Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9].
// Найдите сумму отрицательных и положительных элементов массива.
// Например, в массиве [3, 9, -8, 1, 0, -7, 2, -1, 8, -3, -1, 6] сумма всех положительных
// чисел равна 29, сумма отрицательных равна -20.

// Console.Write("Задайте размер массива: ");
// int size = int.Parse(Console.ReadLine());

Console.Write("Введите элементы массива через пробел: ");
int [] numsArr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

Console.WriteLine(string.Join(' ', numsArr));

// int[] nums = new int[size];
int positive = 0;
int negative = 0;

// var newRnd = new Random();
// for (int i = 0; i < size; i++)
// {
//     nums[i] = newRnd.Next(-9, 10);
//     Console.Write(nums[i] + " ");
// }

for (int i = 0; i < numsArr.Length; i++)
{
    if (numsArr[i] > 0) positive += numsArr[i];
    else negative += numsArr[i];
}

// Console.WriteLine();
Console.WriteLine($"Сумма положительных элементов массива = {positive}");
Console.WriteLine($"Сумма отрицательных элементов массива = {negative}");