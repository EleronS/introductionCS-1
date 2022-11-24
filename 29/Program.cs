// 29. Подсчитать сумму цифр в числе, сделать подпрограмму.
 int a = Convert.ToInt32(Console.ReadLine());
 int Sum(int a)
 {
    int b =0;
 while(a>0)
 {
    b=b+a%10;
    a=a/10;
   
 }
return b;
 }
   
System.Console.WriteLine(Sum(a));