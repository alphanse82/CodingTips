// Iterative
public bool binary_search(int num, int[] input) 
{
  
  int left = 0;
  int right = input.Length -1;
    
    while( left <= right) {
        long  mid = left + ( right - left ) / 2;
        
        if(num == input[mid])
            return true;
        
        if( input[mid] > num)
            right = mid - 1;
        else
            left = mid + 1;
    }
    return false;   
}
