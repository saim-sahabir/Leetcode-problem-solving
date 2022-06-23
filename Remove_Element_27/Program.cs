// See https://aka.ms/new-console-template for more information

int[] rannum = new[] { 22, 2, 23, 3, 22, 5, 67, 9 };

var result = RemoveElement( rannum, 22);
Console.WriteLine(result);


  int  RemoveElement(int[] nums, int val)
  {
      int removeNum = 0;
      for (int i = 0; i < nums.Length; i++)
      {
          if (nums[i] == val)
          {
              removeNum++;
          } 
          
          else 
          {
              nums[i-removeNum] = nums[i];  
              
          }
      }

      return nums.Length - removeNum;
  }

