// Задача 93: Задайте две матрицы. Напишите программу, 
// которая будет находить произведение двух матриц.

int[,] Random2DArrayA(int n,int m,int min=0,int max=10)
{
int[,]a=new int[n,m];
Random random=new Random();
for(int i=0;i<n;i++)
    for(int j=0;j<m;j++)
    a[i,j]=random.Next(min,max+1);
    return a;
}

int[,] Random2DArrayB(int n,int m,int min=0,int max=10)
{
int[,]b=new int[n,m];
Random random=new Random();
for(int i=0;i<n;i++)
    for(int j=0;j<m;j++)
    b[i,j]=random.Next(min,max+1);
    return b;
}


int[,] ArrayMultiGeneration(int [,]a,int [,]b)
{
    int [,]d= new int[a.GetLength(0),b.GetLength(1)]; 
    
    for(int i=0; i<a.GetLength(0);i++)
    {
        for(int j=0;j<b.GetLength(1);j++)
        {
            for(int k=0;k<b.GetLength(0);k++)
            {
                d[i,j]=a[i,j] * b[i,j];
               
            }
        }
    }
    return d;
}

void Print2DArray(int[,]a,int[,]b,int[,]d)
{
    for(int i=0;i<d.GetLength(0);i++)
    {
       for(int j=0;j<d.GetLength(1);j++)
           System.Console.Write($"{a[i,j],4}");
       System.Console.WriteLine();
       
    }
    System.Console.WriteLine();

    for(int i=0;i<d.GetLength(0);i++)
    {
       for(int j=0;j<d.GetLength(1);j++)
           System.Console.Write($"{b[i,j],4}");
       System.Console.WriteLine();
       
    }
    System.Console.WriteLine();

    for(int i=0;i<d.GetLength(0);i++)
    {
       for(int j=0;j<d.GetLength(1);j++)
           System.Console.Write($"{d[i,j],4}");
       System.Console.WriteLine();
       
    }
}
System.Console.WriteLine("При умножении на ноль  результатом будет ноль");
int[,]a= Random2DArrayA(5,5);
int[,]b= Random2DArrayB(5,5);
int[,]d= ArrayMultiGeneration(a,b);

Print2DArray(a,b,d);


 