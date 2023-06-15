Console.Clear();
Console.WriteLine("Введите число n: ");
int n = Convert.ToInt32(Console.ReadLine());

if (n % 2 == 0)
    Console.WriteLine($"{n} - число является чётным, т.к. оно делится на 2 без остатка ");
else
    Console.WriteLine($"{n} - число является нечётным, т.к. оно делится на 2 с остатком ");
