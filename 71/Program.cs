// 71. Показать натуральные числа от N до 1, N задано
int N=10;
int i=1;
void Recursion(int i,int N)
{
    if(N>=i)
    {
        System.Console.WriteLine(N);
        Recursion(i,N-1);
    }
}

Recursion(i,N);
