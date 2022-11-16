// Вывести на экран последнюю цыфру целого числа введенного с клавиатуры.
int a;
int b;
System.Console.Write("Введите число : ");
string? s = Console.ReadLine();
a = Convert.ToInt32(s);
b = a%10;
System.Console.Write($"Последнее число : {b}");
