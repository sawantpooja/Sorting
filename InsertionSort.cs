using System;
using System.IO;
using System.Collections;

public void InsertionSort(List<int>unsortedArray)
  {
    for(int i=0;i<unsortedArray.size();i++)
    {
      int key= unsortedArray[i+1];
      int j=i+1;
      while(key<unsortedArray[j]&&j>0)
      {
        unsortedArray[j]=unsortedArray[j-1];
        j--;
      }
      
      unsortedArray[j]=key;
      
    }
  }
  
  public void PrintArray(List<int> array)
  {
    for(int i=0;i<array.size();i++)
    {
        Console.WriteLine(array[i].ToString());
    }
  }
  
  public static void main()
  {
    List<int>inputArray=new List<int>{5,6,8,1,4,0};
    PrintArray(inputArray);
    InsertionSort(inputArray);
    PrintArray(inputArray);
  }

