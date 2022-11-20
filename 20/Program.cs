// 20.Определить номер четверти плоскости, в которой находится точка с координатами Х и У, причем X ≠ 0 и Y ≠ 0
double x,y;
System.Console.WriteLine("Введите координаты X");
x=Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите координаты Y");
y=Convert.ToInt32(Console.ReadLine());
if(x>0 && y>0) System.Console.WriteLine("Первая четверть плоскости");
if(x<0 && y>0) System.Console.WriteLine("Вторая четверть плоскости");
if(x<0 && y<0) System.Console.WriteLine("Третья четверть плоскости");
if(x>0 && y<0) System.Console.WriteLine("Четвертая четверть плоскости");