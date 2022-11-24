// 27. Возведите число А в натуральную степень В используя цикл.
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
int c= a;
for(int i=1;i<b;i++)
{
    c=c*a;
}
System.Console.WriteLine(c);
