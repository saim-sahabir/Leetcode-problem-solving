

 int[] a1 = new[] { 1,2,3,0,0,0};
 int[] a2 = new[] { 2,5,6};
 
 Merge(a1,3,a2,3 );

   void Merge(int[] nums1, int m, int[] nums2, int n)
   {
      int j = 0;
      for (int i = 0; i < m+n; i++)
      {
         if (m > i)
         {
            nums1[i] = nums1[i];
         }
         else
         {
            nums1[i] = nums2[j];
            j++;
         }
      }

      Array.Sort(nums1);
      
      foreach (var item  in nums1)
      {
         Console.Write(item);
      }
   }