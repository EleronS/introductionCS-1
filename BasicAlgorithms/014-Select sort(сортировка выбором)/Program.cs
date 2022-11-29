// Сортировка выбором.
int[] RandomIntArray(int N,int min,int max)
{
    int[] a=new int[N];
    Random random = new Random();
    for(int i=0;i<N;i++)
    a[i]=random.Next(1,100);
    return a;
    
}


void Swap(ref int a,ref int b)
{
    int t=a;
    a=b;
    b=t;
}




void Print(int[] a)
{ 
    //string formatString="{0,"+tab+"}";
      for(int i=0;i<a.Length;i++)
    System.Console.Write($"{a[i],5}");
     // System.Console.Write(formatString,a[i]);
    
} 

void SelectSort(int[] a)
{
    int im;//индекс максимального.
   for(int i=0;i<a.Length;i++)
   {
    im=i;
    for(int j=i+1;j<a.Length;j++) if(a[im]<a[j]) im=j;
    Swap(ref a[i],ref a[im]);
   }
}

int[]a=RandomIntArray(5,0,10);
Print(a);
SelectSort(a);
System.Console.WriteLine();
Print(a);
