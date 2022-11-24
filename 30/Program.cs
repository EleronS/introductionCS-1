// 30. Написать программу вычисления произведения чисел от 1 до N.
int a = 1;
System.Console.WriteLine("Введите число ");
int b = Convert.ToInt32(Console.ReadLine());
int c =1;
for(int i=a;i<=b;i++)
{
c*=i;
}
System.Console.Write(c);