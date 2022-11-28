﻿// Линейный поиск.

int[] RandomIntArray(int size)
{
    int[] a=new int[size];
    Random random = new Random();
    for(int i=0;i<size;i++)
    a[i]=random.Next(0,100);
    return a;
}


void Print(int[] a)
{
    for(int i=0;i<a.Length;i++)
    System.Console.Write($"{a[i],5}");
}

int LinearSearch(int[] m, int find)
{
   int i =0; 
   while(i<m.Length && m[i]!=find)i++;
   if(i==m.Length)
     return -1;
   else
     return i;
}

int[] m=RandomIntArray(10);
Print(m);

int find=20;
//m[4]=find;
int i =LinearSearch(m,find);
if(i==-1)
System.Console.WriteLine($" Element {find} not found");
else
System.Console.WriteLine($" Element {find} found at {i}");