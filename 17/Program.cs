// Дано число обозначающее день недели. Выяснить является номер дня недели выходным.
int d=Convert.ToInt32(Console.ReadLine());
if(d<5 && d>0) 
 System.Console.WriteLine("Будний день");
if(d>5 && d<8) 
 System.Console.WriteLine("Выходной день"); 
if(d<1)
 System.Console.WriteLine("Неверный номер дня");
if(d>7)
 System.Console.WriteLine("Неверный номер дня");