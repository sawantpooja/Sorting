using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;

class Sorting
{
  public static void InsertionSort(List<int>unsortedArray)
  {
    for(int i=0;i<unsortedArray.Count;i++)
    {
      int key= unsortedArray[i+1];
      int j=i+1;
      while(key<unsortedArray[j-1]&&j>0)
      {
        unsortedArray[j]=unsortedArray[j-1];
        j--;
      }
      
      unsortedArray[j]=key;
      
    }
  }
  
  public static void PrintArray(List<int> array)
  {
    for(int i=0;i<array.Count;i++)
    {
        Console.WriteLine(array[i].ToString());
    }
  }
  
  public static void Main()
  {
    List<int>inputArray=new List<int>{5,6,8,1,4,0};
    PrintArray(inputArray);
    InsertionSort(inputArray);
    PrintArray(inputArray);
  }
}


