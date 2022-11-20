// Программа: из заданного колличества учеников выяснить сколько написало контрольную на отлично, а сколько двоешников.
int n=int.Parse(Console.ReadLine());
int k=0;//счетчик
bool flag = false;//флаг
for(int i=0;i<0;i++)
{
    int a=int.Parse(Console.ReadLine());
    if(a<5)k++;
    if(a==10)flag=true;
}
System.Console.WriteLine(k);
if(flag) System.Console.WriteLine("YES"); else System.Console.WriteLine("NO");
//Альтернатива Convert.ToInt32