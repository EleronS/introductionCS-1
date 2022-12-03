// 61. Показать двумерный массив размером m×n заполненный вещественными случайными числами


double[,] Random2DArray(int m,int n,double min=0.0,double max=1.0)
{
double[,]a=new double[m,n];
Random random=new Random();
for(int i=0;i<m;i++)
    for(int j=0;j<n;j++)
    a[i,j]=random.NextDouble();
    return a;
}

void Print2DArray(double[,]a)
{
    for(int i=0;i<a.GetLength(0);i++)
    {
       for(int j=0;j<a.GetLength(1);j++)
           System.Console.Write($"{a[i,j],4}");
       System.Console.WriteLine();
    }
}
int m=5;
int n=5;
double[,] a=Random2DArray(m,n);
Print2DArray(a);

