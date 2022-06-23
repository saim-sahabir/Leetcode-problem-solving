
 int[] a = new[] { 1,1, 1, 2, 3, 4, 5, 6, 6, 7 };
 
Console.WriteLine(RemoveDuplicates(a));
 // foreach (var item in RemoveDuplicates(a))
 // {
 //     Console.Write(item);
 // }

int  RemoveDuplicates(int[] nums) {  
   
    int temp = 0;
    for(int i = 0; i < nums.Length-1; i++)
    {
        if (nums[i] != nums[i+1])
        {
            nums[temp] = nums[i];
            
            temp++;
           
        }

    }
    
    return temp;
}