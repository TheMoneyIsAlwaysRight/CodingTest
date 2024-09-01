using System;
using System.Linq;

public class Solution {
    public int solution(int[] arr1, int[] arr2)
    {
        if(arr1.Length != arr2.Length)
        {
            if(arr1.Length > arr2.Length){return 1;}
            else{return -1;}
        }
        else
        {
           int sum1 = arr1.Sum();
            int sum2 = arr2.Sum();
            if(sum1 != sum2)
            {
                if(sum1 > sum2){return 1;}
                else{return -1;}
            }
            else{
                return 0;
            }
            
        }
    }
}