//Задача 64: Задайте значения M и N. Напишите программу, которая выведет все чётные натуральные числа в промежутке от M до N с помощью рекурсии.
//M = 1; N = 5 -> "2, 4"
//M = 4; N = 8 -> "4, 6, 8"
//1

   Console.Write("Введите значение M: ");
    int m = Convert.ToInt32(Console.ReadLine());

    Console.Write("Введите значение N: ");
    int n = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine($"Чётные числа от {m} до {n}:");
    evenNumbers(m, n);

void evenNumbers(int start, int end)
{
        if (start > end)
    {
        return;
    }
    if (start % 2 == 0)
    {
        Console.WriteLine(start);
    }

 
    evenNumbers(start + 1, end);
}