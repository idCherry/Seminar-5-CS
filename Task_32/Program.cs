// Программа замена элементов массива: положительные жлементы замените
// на соответствующие отрицательные и наоборот.

Console.Write("Введите размер массива: ");
int size = int.Parse(Console.ReadLine());

int[] numsArr = new int[size];


var newRnd = new Random();
Console.Write("Исходный массив: [");

for (int i = 0; i < size; i++)
{
    numsArr[i] = newRnd.Next(-1000, 1000);
    Console.Write(numsArr[i] + " ");
}
Console.Write("]");

Console.WriteLine();

Console.Write("Обновленный массив: [");
for (int i = 0; i < size; i++)
{
    numsArr[i] *= -1;
    Console.Write(numsArr[i] + " ");
}
Console.Write("]");