//Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N с помощью рекурсии.
//M = 1; N = 15 -> 120
//M = 4; N = 8. -> 30
//1


Console.Write("Введите значение M: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите значение N: ");
int n = Convert.ToInt32(Console.ReadLine());

int sum = CalcSum(m, n);

Console.WriteLine($"Сумма натуральных чисел от {m} до {n}: {sum}");


int CalcSum(int start, int end)
{
    if (start > end)
    {
        return 0;
    }
    return start + CalcSum(start + 1, end);
}