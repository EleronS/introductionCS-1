// 62. В двумерном массиве n*k заменить четные элементы на противоположные
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
 bool RedactorMinusArray (int[,] a,int find,out int i,out int j)
{
    for(i=0;i<a.GetLength(0);i=+2)
             
        for(j=0;j<a.GetLength(1);j++)
            
        
}
       

int[,]a= Random2DArray(5,5);

int find=;
