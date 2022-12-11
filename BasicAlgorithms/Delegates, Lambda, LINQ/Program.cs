// Подсчитать сумму цифр, встречающихся в строке



//Делегаты
/*
int CountDigits(string s)
{
    int count=0;
    foreach(char c in s)
    if(char.IsDigit(c))
    count++;
    return count;
}

int CountLatin(string s)
{
    int count=0;
    foreach(char c in s)
    if(c>='A' && c<='Z' || c>='a' && c<='z')
    count++;
    return count;
}

int CountRus(string s)
{
    int count=0;
    foreach(char c in s)
    if(c>='А' && c<='Я' || c>='а' && c<='я'|| c=='Ё' || c=='ё')
    count++;
    return count;
*/
delegate bool IsChar(char c);//сигнатура(что возвращает и какие арг принимает)
class Program                //
{
static  int CountChars(string s, IsChar isChar)
    {
      int count=0;
      foreach(char c in s)
      if(isChar(c))
        count++;
      return count;

    }
static  bool IsLatin(char c)
    {
     return (c>='A' && c<='Z' || c>='a' && c<='z');
    }    

static void Main()
    {
    string s="Эта строка содержит latinskie буквы и цыфры(12345)";
    var queary=(from c in s where (c>='A' && c<='Z' || c>='a' && c<='z')select c);

    System.Console.WriteLine(CountChars(s,IsLatin));
 //   System.Console.WriteLine(CountChars(s,
 //   delegate(char c)//анонимный делегат для единоразового использования функции
 //   {
 //      return (c>='A' && c<='Z' || c>='a' && c<='z');  
 //   }
 //   ));

 //lyambda многострочное выражение
  /*  System.Console.WriteLine(CountChars(s,
      (c)=>
      {
        return (c>='A' && c<='Z' || c>='a' && c<='z');
      }
    ));*/
 // lyambda однострочное выражение
  /*   System.Console.WriteLine(CountChars(s,
      (c)=>c>='A' && c<='Z' || c>='a' && c<='z'
     
    ));*/
    }

}
//Action готовый делегат c#
//Func <,>


//Лямбда выражения

