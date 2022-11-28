// 35. Написать программу замены элементов массива на противоположные
int[] RandomIntArray(int size=10,int min=0,int max=100)
{
    int[] a=new int[size];
    Random random = new Random();
    for(int i=0;i<size;i++)
    a[i]=random.Next(min, max+1);
    return a;
}

void Print(int[] a)
{
    for(int i=0;i<a.Length;i++)
    System.Console.Write($"{a[i],3}");
}
void PrintPosToNeg(int[] a)
{
    for(int i=0;i<a.Length;i++)
       if(a[i]<0)
    System.Console.Write($"{a[i]-a[i]*2,3}");
       else
       System.Console.Write($"{0-a[i],3}");
}

int[] a=RandomIntArray(8,-9,9);

Print (a);
System.Console.WriteLine();
PrintPosToNeg(a);


