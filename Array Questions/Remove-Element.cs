public class Solution {
    public int[] swapAtIndices(int[] array, int indexOne, int indexTwo) {
        int firstItem = array[indexOne];
        int secondItem = array[indexTwo];

        array[indexOne] = secondItem;
        array[indexTwo] = firstItem;

        return array;
    }

    public int RemoveElement(int[] nums, int val) {
        int k = nums.Length;

        int index = 0;
        while (index < k)
        {
            int number = nums[index];
            if (number == val)
            {
                nums = swapAtIndices(nums, index, k-1);
                Console.WriteLine(String.Join(", ", nums));
                k--;
            } 
            else 
            {
                index++;
            }
        }

        return k;
    }
}