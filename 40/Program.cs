// 40. Задан массив a из N элементов. Заполнить массив случайными числами от 1 до 10. Создайте массив, который является произведением пар чисел в одномерном массиве a. Парой считаем первый и последний элемент, второй и предпоследний и т.д.

int[] RandomIntArray(int N,int min=1,int max=10)
{
    int[] a=new int[N];
    Random random = new Random();
    for(int i=0;i<N;i++)
    a[i]=random.Next(1,10);
    return a;
    
}

void Print(int[] a)
{ 
    for(int i=0;i<a.Length;i++)
    System.Console.Write($"{a[i],5}");
  

    
}   
int[] m=RandomIntArray(10);

Print(m);
System.Console.WriteLine();
