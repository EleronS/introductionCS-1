// С клавиатуры вводятся три числа, найти максимальное из них.
int a;
int b;
int c;
System.Console.Write("Введите первое число : ");
string? s = Console.ReadLine();
a = Convert.ToInt32(s);
System.Console.Write("Введите второе число : ");
string? d = Console.ReadLine();
b = Convert.ToInt32(d);
System.Console.Write("Введите третье число : ");
string? e = Console.ReadLine();
c = Convert.ToInt32(e);
if(a>b & a>c)
{
     System.Console.WriteLine($"Максимальное число :{a}");
}
if(b>a & b>c)
{
     System.Console.WriteLine($"Максимальное число :{b}");
}
if(c>a & c>b)
{
     System.Console.WriteLine($"Максимальное число :{c}");
}