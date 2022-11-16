// С клавиатуры вводятся два числа a и b. Выяснить, кратно ли число a числу b, если нет, вывести остаток от деления a на b.
int a;
int b;
int c;
System.Console.Write("Введите первое число (a): ");
string? s = Console.ReadLine();
a = Convert.ToInt32(s);
System.Console.Write("Введите второе число (b): ");
string? d = Console.ReadLine();
b = Convert.ToInt32(d);
c=a%b;
if(a%b==0)
{
    System.Console.WriteLine($"Число {a} кратно {b}");
}
else{
    System.Console.WriteLine(c);
}