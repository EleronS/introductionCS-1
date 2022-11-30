// 51.С клавиатуры вводится число N. Затем вводятся N чисел. Определить сколько чисел больше 0 введено с клавиатуры
System.Console.WriteLine( "Введите число определяющее длину массива ");
int n = Convert.ToInt32(Console.ReadLine());

int[] RandomIntArray(int size)
{
    int[] a=new int[size];
    Random random = new Random();
    for(int i=0;i<size;i++)
    a[i]=random.Next(-10,10);
    return a;
}

void Print(int[] a)
{
    for(int i=0;i<a.Length;i++)
    System.Console.Write($"{a[i],5}");
}


int LinearSearch(int[] m, int find)
{
   int count=0;
   for(int i=0;i<m.Length;i++)
      if(m[i]>0) count++;
      return count;
         if(count<1)
         return -11;


}

int find=0;
int[] m=RandomIntArray(n);
Print(m);
System.Console.WriteLine();
int count =LinearSearch(m,find);
if(count==-11)
System.Console.WriteLine($"Элементов больше {find} не найден в массиве");
else
System.Console.WriteLine($"В данном массиве {count} элементов больше {find}");