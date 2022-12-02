// 55. Написать программу масштабирования фигуры.
/*
double[] x,y;
x=new double[10];
y=new double[10];
x[0]=0;
y[0]=0;
*/

//Структура

class Program
{
struct Point
{
    public double x,y;
}

static double Distance(double x1,double y1,double x2,double y2)
{
    return Math.Sqrt(Math.Pow(x1-x2,2)+Math.Pow(y1-y2,2));
}

static double Distance(Point A,Point B)
{
    return Math.Sqrt(Math.Pow(A.x-B.x,2)+Math.Pow(A.y-B.y,2));
}

static void Main()
{
Point a,b;
a.x=0;
a.y=0;
b.x=0;
b.y=0;

Point[] figure = new Point[3];
double k=2;
for(int i=0;i<figure.Length;i++)
{
    figure[i].x*=k;
    figure[i].x*=figure[i].y*k;
}

}

}

