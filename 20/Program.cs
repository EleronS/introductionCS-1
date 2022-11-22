// 20.Определить номер четверти плоскости, в которой находится точка с координатами Х и У, причем X ≠ 0 и Y ≠ 0
double x,y;
System.Console.WriteLine("Введите координаты X");
x=Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите координаты Y");
y=Convert.ToInt32(Console.ReadLine());

int Part(double x,double y)
{

if(x>0 && y>0) return 1;
if(x<0 && y>0) return 2;
if(x<0 && y<0) return 3;
if(x>0 && y<0) return 4;

return 0;
}
System.Console.WriteLine("Четверть плоскости :" +Part(x,y));