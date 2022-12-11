// 84. Определить являются ли введенные с клавиатуры символы правильной
// записью целого числа. Вычислить сумму цифр введенного числа.

string s=Console.ReadLine();
int t=0;
int d=0;
int sum=0;
foreach(char a in s)
    if(char.IsDigit(a)) 
    {
       for(int i=0;i<=57;i++)

         if(i==a)
         {
         t=t+i-48;
           sum=sum+t;
         t=0;
         d++;
         }
    }

if(s.Length==d)    
System.Console.WriteLine(sum); 
else
System.Console.WriteLine("Not true digits"); 


/* решение с семинара(альтернатива с методами)
string s=Console.ReadLine();
int n;
bool flag=int.TryParse(s,out n);
if(flag)
{
  int sum=0;
  foreach(char c in s)
  sum=sum+(int)char.GetNumericValue(c);
  System.Console.WriteLine($"{n} {sum}");

}
else System.Console.WriteLine("Wrong number");*/
