// methods
int a=3, b=5;
void Swap(ref int a,ref int b)// reference -ссылка 
{
    int t=a;
    a=b;
    b=t;
}

void Calculator(int a,int b,out int  sum,out int multi)//out значение переменной задается в выводе.
{
    sum=a+b;
    multi=a*b;
}

System.Console.WriteLine($"a={a} b={b}");
Swap(ref a,ref b);
System.Console.WriteLine($"a={a} b={b}");
Calculator(a,b,out int  sum,out int multi);

bool flag;
int x;
do
{
flag=int.TryParse(Console.ReadLine(), out x);
if(flag==false)System.Console.WriteLine("Введите целое число");
}
while(flag==false);