﻿// 75. Написать программу вычисления функции Аккермана.
 
 int Ack(int n,int m)
 {
    if(n==0) 
    {
     return m+1;
    }
    else
      if(n!=0 && m==0) 
      {
       return Ack(n-1,1);
      }
      else
        if(n>0 && m>0) 
        {
        return Ack(n-1,Ack(n,m-1));
        }
      return Ack(n,m); 
 }
Ack(0,0);
System.Console.WriteLine(Ack(3,4));
 