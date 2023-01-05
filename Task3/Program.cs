// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементом массива.

Console.WriteLine("Введите размер массива");
int size = Convert.ToInt32(Console.ReadLine());
double[] num = new double[size];
FillArrayRandomNumbers(num);
Console.WriteLine("Массив: ");
PrintArray(num);

double min = Int32.MaxValue;
double max = Int32.MinValue;
 for (int a = 0; a < num.Length; a++)
 {
    if (num[a] > max)
        {
            max = num[a];
        }
    if (num[a] < min)
        {
            min = num[a];
        }
}

Console.WriteLine($" Максимальное = {max}, Минимальное = {min}");
Console.WriteLine($"Разница между максимальным и минимальным = {max - min}");

void FillArrayRandomNumbers(double[] num)
{
    for(int i = 0; i < num.Length; i++)
        {
            num[i] = Convert.ToDouble(new Random().Next(100,1000)) / 100;
        }
}
void PrintArray(double[] num)
{
    Console.Write("[ ");
    for(int i = 0; i < num.Length; i++)
        {
            Console.Write(num[i] + " ");
        }
    Console.Write("]");
    Console.WriteLine();
}

