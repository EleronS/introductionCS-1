// 54.С клавиатуры вводится число N. Показать первые N чисел Фибоначчи. Принять первые числа равными 0 и 1
System.Console.WriteLine( "Введите число : ");
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

    }       




