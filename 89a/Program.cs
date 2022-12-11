// в некотором машинном алфавите имеется четыре буквы "а", "и", "с" и "в".
// покажите все слова(не обязательно осмысленные) состоящие из n букв этого 
// алфавита. Использовать рекурсию.

void Words(string A, ref string w, int N)
{
    if(N<1)
    {
        Console.Write($"{w}");
        return;
    }
    foreach(char c in A)
    {
        w=w+c;
        Words(A,ref w,N-1);
        w = w.Remove(w.Length-1);
    }
}

System.Console.WriteLine("Введите количество букв");
int n = Convert.ToInt32(Console.ReadLine());
string word=" ";
Words("аисв",ref word,n);



