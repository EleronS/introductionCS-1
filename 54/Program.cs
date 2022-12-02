// 54.С клавиатуры вводится число N. Показать первые N чисел Фибоначчи. Принять первые числа равными 0 и 1
/*System.Console.WriteLine( "Введите число : ");
int n = Convert.ToInt32(Console.ReadLine());

 


    int a =1;
    int b =1;
    int c;
    for(int i=0;i<n;i++)
    if(i==0)System.Console.Write($"{0} ");
    else
    {
       System.Console.Write($" {a} ");
       c=a+b;
       a=b;
       b=c;

    }  */     

    // Второй способ с рекурентной формулой.
    int n=10;
    int[] a=new int[n];
    a[0]=0;
    a[1]=1;
    for(int i=2;i<n;i++)
      a[i]=a[i-1]+a[i-2]; // рекурентная формула(следующее значение за счет использования предидущего.)
    for(int i=0;i<n;i++)
      System.Console.Write($"{a[i]} ");
        




