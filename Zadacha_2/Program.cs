Console.WriteLine("Введите число");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int b = Convert.ToInt32(Console.ReadLine());
if (a > b)
    Console.WriteLine($"{a} > {b} -  большее {a} ");
else
    Console.WriteLine($"{a} < {b} - большее {b} ");
