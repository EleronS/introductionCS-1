﻿// Обмен значениями двух переменных.
// Классический способ.
/*int a=5;
int b=7;
int temp;
temp=a;
a=b;
b=temp;
*/ 

// Без использования переменных.
/*int a=5;
int b=7;
a=a+b;
b=a-b;
a=a-b;
*/

int a=5;
int b=7;
a=a^b;
b=a^b;
a=a^b;