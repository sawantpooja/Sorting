using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;

class Sorting
{
  public static void InsertionSort(List<int>unsortedArray)
  {
    for(int i=0;i<unsortedArray.Count-1;i++)
    {
      
      int key= unsortedArray[i+1];
      int j=i+1;
      //Console.WriteLine("Key: "+ key + " J: "+j); 
      while(j>0 && key>unsortedArray[j-1])
      {
        //Console.WriteLine("J inside loop: "+j);
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
        Console.Write(array[i].ToString()+ " ");
    }
    Console.WriteLine();
  }
  
  public static void Main()
  {
    List<int>inputArray=new List<int>{5,6,8,1,4,0};
    PrintArray(inputArray);
    InsertionSort(inputArray);
    PrintArray(inputArray);
  }
}


