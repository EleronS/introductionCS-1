// 
int[] RandomIntArray(int N,int min=1,int max=10)
{
    int[] a=new int[N];
    Random random = new Random();
    for(int i=0;i<N;i++)
    a[i]=random.Next(1,10);
    return a;
    
}


void Swap(ref int a,ref int b)
{
    int t=a;
    a=b;
    b=t;
}


void Reverse(int[]a)
{
    //int t;
    for(int i=0;i<a.Length/2;i++)
      Swap(ref a[i],ref a[a.Length-1-i]);
     /*{
      t=a[i];
      a[i]=a[a.Length-1-i];   реализация REVERSE без SWAP.
      a[a.Length-1-i]=t;
      }*/
}


void Print(int[] a,int tab=5)
{ 
    string formatString="{0,"+tab+"}";
      for(int i=0;i<a.Length;i++)
   // System.Console.Write($"{a[i],5}");
      System.Console.Write(formatString,a[i]);
    
}   

int M=10;
int[]a=RandomIntArray(M,0,200);
//a=a.Reverse().ToArray(); встроеннный метод C# для переворота.Требует новую память и создает новый массив.
Print(a,5);
System.Console.WriteLine();
Reverse(a);
System.Console.WriteLine();
Print(a,5);
