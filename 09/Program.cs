// 9. Вывести на экран четные числа от 1 до N.
int N = Convert.ToInt32(Console.ReadLine());
int i = 2;
while(i<=N)
{
    System.Console.Write($"{i} " );// чет
    i=i+2;
}
for(int j=1; j<=N; j=j+2)
{
     System.Console.Write($"{j} " );// нечет
}

