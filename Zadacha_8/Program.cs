
// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.Clear();
Console.WriteLine("Введите число N от 1: ");
int n = Convert.ToInt32(Console.ReadLine());
string s = "";

while (n < 1)
{
    Console.Write("Вы ошиблись!\nВведите число N от 1: ");
    n = Convert.ToInt32(Console.ReadLine());
}

for (int i = 1; i <= n; i++)
{
    if (i % 2 == 0) 
        s = s + ($"{i } ");
}

Console.WriteLine($"{n} -> {s} ");