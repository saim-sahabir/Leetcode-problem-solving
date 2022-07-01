// See https://aka.ms/new-console-template for more information



 var result =  RunningSum(new int[] { 3,1,2,10,1 });
 foreach (var item in result)
 {
     Console.WriteLine(item);
 }
 
 
int[] RunningSum(int[] nums) {
    int sum = 0; 
    for( int i = 0; i < nums.Length; i++)
    {
            sum =  sum + nums[i];
        nums[i] = sum;
    }
        
    return nums;
}