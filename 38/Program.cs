// 38. В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99]

int[] RandomIntArray(int size=122,int min=0,int max=122)
{
    int[] a=new int[size];
    Random random = new Random();
    for(int i=0;i<size;i++)
    a[i]=random.Next(min, max+1);
    return a;
}
int CountPositions(int[] a)
{
    int s=0;
    for(int i=0;i<a.Length;i++)
       if(a[i]>9 && a[i]<100)
       s=s+1;
       return s;
}

void Print(int[] a)
{
    for(int i=0;i<a.Length;i++)
    System.Console.Write($"{a[i],5}");
}
int[] a=RandomIntArray(10,0,123);

Print (a);
System.Console.WriteLine();
System.Console.WriteLine(CountPositions(a));
