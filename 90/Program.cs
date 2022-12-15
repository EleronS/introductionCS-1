// 90. Есть два массива info и data.
//Массив data состоит из нулей и единиц хранящий числа в двоичном 
//представлении. Числа идут друг за другом без разделителей.
//Массив info состоит из чисел, которые представляют количество бит
// чисел из массива data.
//Составить массив десятичных представлений чисел массива data с учётом
// информации из массива info.

int[]data = {0, 1, 1, 1, 1, 0, 0, 0, 1 };
int[]info = {2, 3, 3, 1 };
int n=info.Length;
int t=0;
int[]res = new int[info.Length];
  for(int j=0;j<n;j++)
   {
   t=t+info[0];
   for(int i=0;i<t;i++)
   System.Console.Write(data[i]);
   }
  
      

     
       
      
      




    



      
     


  
    /*  for(int i=1;i<info[i];i++)
         for(int j=0;j<data.Length;j++)
            System.Console.Write($" {j}");  */
     

