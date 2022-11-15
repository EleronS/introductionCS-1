// С клавиатуры вводится два вещественных числа. Проверять является ли одно из них квадратом второго.
System.Console.WriteLine("Введите первое число");
double a = Convert.ToDouble(Console.ReadLine());
System.Console.WriteLine("Введите второе число");
double b = Convert.ToDouble(Console.ReadLine());

/*
//полное условие
if()
{
    //true
}
else
{
    //false
}*,
*/

if(a*a==b)
{
     System.Console.WriteLine($"{b} является квадратом {a}");
}

if(b*b==a)
{
     System.Console.WriteLine($"{a} является квадратом {b}");
}     