// Задача 27: Напишите программу, которая принимает на вход число
// и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

// Сумма цифр числа
int Sum(string a)
{
    int sum = 0;
    for (int i = 0; i < a.Length; i++)
    {
        sum = sum + (int)Char.GetNumericValue(a[i]);
    }
    return sum;
}

void Print(string a, int s)
{
    Console.WriteLine($"Сумма цифр числа {a} = {s}.");
    Console.WriteLine();
}

Console.Write("Введите целое число: ");
string num = (Console.ReadLine());

int s = Sum(num);
Print(num, s);