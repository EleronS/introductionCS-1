// 21. Задать номер четверти, показать диапазоны для возможных координат.
 int q;
 System.Console.WriteLine("Введите номер четверти: ");
 q=Convert.ToInt32(Console.ReadLine());
 if(q>0 && q<5)
 {
    if(q==1)System.Console.WriteLine("Диапазон X>0 и Y>0");
    else
    if(q==2)System.Console.WriteLine("Диапазон X<0 и Y>0");
    else
    if(q==3)System.Console.WriteLine("Диапазон X<0 и Y<0");
    else
    if(q==4)System.Console.WriteLine("Диапазон X>0 и Y<0");
 }
 else System.Console.WriteLine("Неверный номер");
