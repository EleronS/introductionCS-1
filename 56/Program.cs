// 56.Написать программу копирования массива.
/*System.Console.Write("Введите длину массива: ");
int n= Convert.ToInt32(Console.ReadLine());
int[]a= new int[n];
System.Console.WriteLine("Введите элементы массива: ");
for(int i=0;i<n;i++)
a[i]=Convert.ToInt32(Console.ReadLine());

int CopyArray(int[]c)
{
    for(int i=0;i<a.Length;i++)
    c[i]=a[i];
    return c.Length;
}

void Print(int[] c)
{
    System.Console.WriteLine("Копия массива");
    for(int i=0;i<c.Length;i++)
    System.Console.Write($"{c[i],5}");
}
int[]c= new int[a.Length];
CopyArray(c);
Print(c);*/

int []a={1,2,3,4,5,6,7,8,9,10};
int []c=new int[a.Length];


int[] CopyArray(int[]c)
{
  for(int i=0;i<a.Length;i++)
  
     c[i]=a[i];
  
  return c;
}

void PrintArray(int[]c)
{
    for(int i=0;i<c.Length;i++)
           System.Console.Write($"{c[i],4}");
       System.Console.WriteLine();
    
}

CopyArray(c);
PrintArray(c);
