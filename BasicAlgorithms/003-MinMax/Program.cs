// Вводятся числа, нужно найти минимальное.
int n=Convert.ToInt32(Console.ReadLine());
int min=30000;//указываем минимальное как максимальное,что бы задать потолок и откатывать минимальное.
for(int i=0;i<n;i++)
{
    int a=Convert.ToInt32(Console.ReadLine());
    if(a<min && a%10==4) min=a;//дополнительная проверка на последннюю цифру числа
}
System.Console.WriteLine(min);