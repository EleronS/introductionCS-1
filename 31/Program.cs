// 31.Сгенерировать 10 случайных чисел. Показать кубы чисел, заканчиваются на четную цыфру.
Random random=new Random(10);
for(int i=0;i<5;i++)
{
int a=random.Next(1,100);
int b=(int)Math.Pow(a,3);//явное приведение к типу int.
if(b%2==0)
System.Console.WriteLine($"{a} , {b}");
}