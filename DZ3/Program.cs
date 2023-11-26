//Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
//m = 2, n = 3 -> A(m,n) = 9
//m = 3, n = 2 -> A(m,n) = 29
//p

Console.Write("Введите не отрицательное значение m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите не отрицательное значение n: ");
int n = Convert.ToInt32(Console.ReadLine());
int result = Ackerman(m, n);
Console.WriteLine($"Значение функции Аккермана для m = {m}, n = {n}: {result}");

int Ackerman(int m, int n)
{
   if (m == 0)
    {
        return n + 1;
    }
    else if (m > 0 && n == 0)
    {
        return Ackerman(m - 1, 1);
    }
    else
    {
        return Ackerman(m - 1, Ackerman(m, n - 1));
    }
}