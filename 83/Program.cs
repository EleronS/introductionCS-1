//83. Подсчитать количество цифр среди вводимых с клавиатуры символов

//for
/*
string s=Console.ReadLine();
int k=0;
for(int i=0;i<s.Length;i++)
    if(char.IsDigit(s[i])) k++;
    System.Console.WriteLine(k);
*/

//foreach
    string a=Console.ReadLine();
int d=0;
foreach(char c in a)
    if(char.IsDigit(c)) d++;
    System.Console.WriteLine(d);
