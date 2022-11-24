// Вывести на экран таблицу квадратов чисел от 1 до N.

int N = Convert.ToInt32(Console.ReadLine());
int a=1;
int b=0;

while(a<=N)
{
    b=a*a;
    System.Console.WriteLine(b);
    a++;
}

