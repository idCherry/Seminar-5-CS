// Задайте одномерный масив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечетных позициях.

Console.Write("Введите размер массива: ");
int size = int.Parse(Console.ReadLine());
int[] nums = new int[size];

int sum = 0;

var newRnd = new Random();
Console.Write("Рандомный массив: [");
for (int i = 0; i < size; i++)
{
    nums[i] = newRnd.Next(-100, 100);
    Console.Write(nums[i] + " ");
}
Console.Write("]");

Console.WriteLine();

for (int i = 0; i < size; i++)
{
    if (i % 2 != 0)
    {
        sum += nums[i];
    }
}
Console.WriteLine($"Сумма элементов нечетных позиций = {sum}");