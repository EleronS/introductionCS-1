// ABC=>CBA, ABC=>CAB

bool Test(string s1,string s2)
{
    s1=s1.ToLower();//  приводит строку с разным регистром 
    s2=s2.ToLower();//       к общему регистру
    if(s1.Length!=s2.Length) return false;
    char[] c1=s1.ToCharArray();
    char[] c2=s2.ToCharArray();
    Array.Sort(c1);//ABC
    Array.Sort(c1);//ABC
    s1= new String(c1);
    s1= new String(c2);
    return s1==s2;
}
string s1 = "ABC";
string s2 = "CBA";

System.Console.WriteLine(Test(s1,s2));

