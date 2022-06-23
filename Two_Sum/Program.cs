﻿
int[] TwoSum(int[] nums, int target) {
    int arrayLength = nums.Length;
    Dictionary < int, int > resultDictionary = new();
    //Validations
    if (nums == null || arrayLength < 2) {
        return Array.Empty < int > ();
    }
    //Logic
    for (int i = 0; i < arrayLength; i++) {
        int firstNumber = nums[i];
        int secondNumber = target - firstNumber;
        if (resultDictionary.TryGetValue(secondNumber, out int index)) {
            return new [] {
                index,
                i
            };
        }
        //resultDictionary.Add(firstNumber, i);
        resultDictionary[firstNumber] = i;
    }
    return Array.Empty < int > ();;
}