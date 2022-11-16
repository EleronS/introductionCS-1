// С клавиатуры вводится целое число из диапозона [10,99]. Показать наибольшую цифру числа.
int a;
int b;
int c;
System.Console.Write("Введите число от 10 до 99 : ");
 string? s = Console.ReadLine();
 a = Convert.ToInt32(s);
if(a>10&a<99)
{

b=a%10;
c=a/10;
 if(b>=c)
    {
         System.Console.Write(b);
    }
    else
    {
         System.Console.Write(c);
    }
}