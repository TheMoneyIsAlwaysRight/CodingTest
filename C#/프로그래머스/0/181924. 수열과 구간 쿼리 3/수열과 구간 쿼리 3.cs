using System;
using System.Collections.Generic;

public class Solution 
{
    public int[] solution(int[] arr, int[,] queries)
    {
        Stack<int> stack = new Stack<int>();
        
        for(int x=0;x<queries.GetLength(0);x++)
        {
            for(int y=0;y<queries.GetLength(1);y++)
            {
                stack.Push(queries[x,y]);
                
                if(stack.Count == 2)
                {    
                    int first_index = stack.Pop();
                    int second_index = stack.Pop();      
                    
                    int backup = arr[first_index];
                    
                    arr[first_index] = arr[second_index];
                    arr[second_index] = backup;
                    
                    break;
                }

            }
            
        }
        return arr;
    }
}