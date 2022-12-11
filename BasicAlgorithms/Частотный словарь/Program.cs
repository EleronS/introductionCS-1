// Частотный словарь.
// Составить частотный словарь элементов одномерного массива из чисел от 0 до 99.
//частотный массив

int[] data={1,2,3,4,7,7,8,};
int[] freqArr=new int[100];
/*
foreach(int element in data)
      freqArr[element]++;
for(int i=0;i<freqArr.Length;i++)
      if(freqArr[i]!=0)
      System.Console.WriteLine($"{i} {freqArr[i]}");*/

      
//частотный словарь
Dictionary<int,int> freqDic=new Dictionary<int,int>();
foreach(int element in data)
   if(freqDic.ContainsKey(element))freqDic[element]++;
      else
        freqDic.Add(element,1);
foreach(var el in freqDic)
System.Console.WriteLine($"{el.Key} {el.Value}");
