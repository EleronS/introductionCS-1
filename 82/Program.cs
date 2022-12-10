// 82. C клавиатуры вводится строка разделенная точкой. Подсчитать 
//     количество символов до точки.

 string s=Console.ReadLine();

void DigitAddPoint(string s)
{

    char[] c=s.ToCharArray();
    for(int i =0;i<s.Length;i++)
        if(c[i]=='.')
        System.Console.WriteLine(i);

    
}

DigitAddPoint(s);




