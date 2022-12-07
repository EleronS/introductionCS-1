// 70. Показать натуральные числа от 1 до N, N задано
int N=10;
int i=1;
void Recursion(int N,int i)
{
    if(i<=N)
    {
        System.Console.WriteLine(i);
        Recursion(N,i+1);
    }
}

Recursion(N,i);
