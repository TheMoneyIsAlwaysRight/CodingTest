#include <stdio.h>
#include <stdbool.h>
#include <stdlib.h>

int solution(int n, int k) 
{
        int answer = 0;
        
        if(n>=10)
        {
          answer = n*12000 + k*2000 - 2000*(n/10); 
        }
        else if(n<10)
        {
        answer = n*12000 + k*2000;
        }
        return answer;
}