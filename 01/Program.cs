// See https://aka.ms/new-console-template for more information
/*Console.WriteLine("Hello, World!");
System.Console.WriteLine("2");
#region My Code
System.Console.WriteLine(2+2);
#endregion*/

// 1. С клавиатуры вводится целое число. Вывести квадрат числа.
int a;
a=10;
System.Console.Write("Введите целое число");
string?s=Console.ReadLine();
a=Convert.ToInt32(s);
int b=a*a;
//System.Console.WriteLine(b);// без диалога
// System.Console.WriteLine(Convert.ToString(a)+"^2="+b.ToString());// с диалогом но криво
 System.Console.WriteLine($"{a}^2={b}");// результат тот же, просто грамотно.

