// 22. Программа проверяет пятизначное число на палиндромом.
 int n;
 System.Console.WriteLine("Введите пятизначное число: ");
 n=Convert.ToInt32(Console.ReadLine());
 int t=n;
 int i=0;
 while(n>0) 
 {
    int a=n%10;
    i=i*10+a;
    n=n/10;
 }
 if(t==i) System.Console.WriteLine("Число является палиндромом"); 
 else System.Console.WriteLine("Число не является палиндромом");
 