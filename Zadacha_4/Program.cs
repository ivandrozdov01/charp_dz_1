Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье число: ");
int c = Convert.ToInt32(Console.ReadLine());
if ((a > b) & (a > c))
    Console.WriteLine($"{a}, {b}, {c}  -  большее {a} ");
else if (b > c)
    Console.WriteLine($"{a}, {b}, {c} - большее {b} ");

else 
    Console.WriteLine($"{a}, {b}, {c} - большее {c} ");




 

