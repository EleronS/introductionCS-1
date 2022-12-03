// Ввод-вывод в двумерного массива, поиск в двумерном массиве, 
//сортировка лвумерного массива(по колонкам, так как в дз есть такое)


int[,] Random2DArray(int n,int m,int min=0,int max=10)
{
int[,]a=new int[n,m];
Random random=new Random();
for(int i=0;i<n;i++)
    for(int j=0;j<m;j++)
    a[i,j]=random.Next(min,max+1);
    return a;
}

//int[,]a1=new int[3,4]{{1,2,3,4},{1,2,3,4}{1,2,3,4}};
//int[,]a2={{1,2,3,4},{1,2,3,4}{1,2,3,4}};
void Print2DArray(int[,]a)
{
    for(int i=0;i<a.GetLength(0);i++)
    {
       for(int j=0;j<a.GetLength(1);j++)
           System.Console.Write($"{a[i,j],4}");
       System.Console.WriteLine();
    }
}

int[,]a= Random2DArray(3,5);
Print2DArray(a);