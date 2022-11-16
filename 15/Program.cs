// С клавиатуры вводится целое число. Вывести третью цыфру числа или сообщить, что ее нет(Вывести:NO).
 int a;
 int b;
 int c;
System.Console.Write("Введите число: ");
string? s = Console.ReadLine();
a = Convert.ToInt32(s);
b=a%10;
c=a%100*10/100;
if(a<100)
{
    System.Console.WriteLine("NO");
}
else
{
    System.Console.WriteLine(b);
}