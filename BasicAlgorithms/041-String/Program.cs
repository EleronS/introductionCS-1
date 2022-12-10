// String
/*
string s= "asdf";
//immutable string (не изменяемые строки)
System.Console.WriteLine(s[0]);
for(int i=0;i<s.Length;i++)
    System.Console.WriteLine(s[i]);
char[] cc=s.ToCharArray();
cc[0]='S';
s= new String(cc);

//для многократного использования строчки
System.Text.StringBuilder sb= new System.Text.StringBuilder("asda");
sb[0]='s';

s=sb.ToString();

//for(int i=0;i<1000000;i++)
   s=s+"1"; // создается строка
for(int i=0;i<1000000;i++)
   sb.Append("1");

string s1="Hello";
string s2="Hello";
System.Console.WriteLine(s1==s2);  //s1.CompareTo(s2); 
System.Console.WriteLine(String.Compare(s1,s2));

//s1.Length 
s2=s1.Substring(2,4); //вырезает символы из строки
System.Console.WriteLine(s1.IndexOf("as"));
s2=s1.Replace('a','b');
s1=s1.Replace('a','b');//замена с возвратом ссылки. без создания новой строки

Random random1 =new Random();
Random random2 =new Random();
random2=random1;
// System.Console.WriteLine(random2==random1);*/
/*
string s=Console.ReadLine();
string[] ss=s.Split(' ');
int[] n=new int[ss.Length];
for(int i=0;i<ss.Length;i++)
  n[i]=Convert.ToInt32(ss[i]);
int a=n[0];
int b=n[1];
int c=n[2];*/

string[] ss=Console.ReadLine().Split(' ');
int[] n=Array.ConvertAll<string,int>(ss,Convert.ToInt32);//с помощью методов
int a=n[0];
int b=n[1];
int c=n[2];