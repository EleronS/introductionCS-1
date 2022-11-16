//03. С клавиатуры вводятся два числа a и b. Найти максимальное из них.
int a;
int b;
System.Console.Write("Введите первое число (a) : ");
string? s = Console.ReadLine();
a = Convert.ToInt32(s);
System.Console.Write("Введите второе число (b): ");
string? d = Console.ReadLine();
b = Convert.ToInt32(d);
if(a>b)
{
    System.Console.WriteLine($"Максимальное число (a) :{a}");
}
else
{
    System.Console.WriteLine($"Максимальное число (b) :{b}");
}
