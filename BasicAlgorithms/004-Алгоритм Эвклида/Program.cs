// Алгоритм Евклида.
int k= 0;
int GCD(int a,int b)
{
while(a!=b)
{
k++;
     if(a>b)
     a=a-b;

     else
     b=b-a;
}
     return a;

}
  System.Console.WriteLine(GCD(5,30));
  System.Console.WriteLine(k);

k=0;

  // Ускоренный алгоритм Евклида.
int QGCD(int a,int b)
{
while(a!=0 && b!=0)
{
k++;
     if(a>b)
     a=a%b;

     else
     b=b%a;
}
     return a+b;

}
  System.Console.WriteLine(QGCD(5,30));
  System.Console.WriteLine(k);