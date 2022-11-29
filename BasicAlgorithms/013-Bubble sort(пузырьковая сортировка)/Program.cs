// Пузырьковая сортировка.
int[] RandomIntArray(int N,int min=1,int max=10)
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

void BubbleSort(int[] a,out int count)//out int count счетчик на производительность, сколько раз выполнено действие сортировка.
{
    count=0;
    int flag=0;//flag дополнительная переменная для небольшого сокращения(меньшего нежели count) количества сортировок в методе.
    for(int i=0;i<a.Length;i++)
    {
        flag=0;
       for(int j=0;j<a.Length-1-i;j++)
       {
           if(a[j]>a[j+1])
           {
           Swap(ref a[j],ref a[j+1]);
           flag=1;
           }
           count++;
       }
       if(flag==0)return;
    }
}

int[]a=RandomIntArray(10,0,10);
Print(a);
int count =0;
BubbleSort(a,out count);
System.Console.WriteLine();
Print(a);
System.Console.WriteLine();
System.Console.WriteLine(count);