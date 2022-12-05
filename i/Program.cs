// // 62. В двумерном массиве n*k заменить четные элементы на противоположные
// по значению a[i,j] = -a[i,j]. Написать отдельную подпрограмму на вход
// которой подается массив, а на выходе измененный массив.


int[,] Random2DArray(int n,int k,int min=0,int max=10)
{
int[,]a=new int[n,k];
Random random=new Random();
for(int i=0;i<n;i++)
    for(int j=0;j<k;j++)
    a[i,j]=random.Next(min,max+1);
    return a;
}
void Print2DArray(int[,]a)
{
    for(int i=0;i<a.GetLength(0);i++)
    {
       for(int j=0;j<a.GetLength(1);j++)
           System.Console.Write($"{a[i,j],4}");
       System.Console.WriteLine();
    }
}
void RedactorMinusArray(int[,] a)
{
    
    
          for(int i=0;i<=a.GetLength(0)-1;i++)
             for(int k=0;k<a.GetLength(0);k++)
                for(int j=k+1;j<a.GetLength(1);j++)
                
                {
                
                  a[i,j]=-a[i,j];
                  
                }
    
}
 
int[,]a= Random2DArray(6,6);
Print2DArray(a);
System.Console.WriteLine();
RedactorMinusArray(a);
Print2DArray(a);