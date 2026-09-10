public class Solution {
    public int FindMin(int[] nums) {
        int left = 0;
        int right = nums.Length - 1;

        while (left < right) {
            int mid = left + (right - left) / 2;

            if (nums[mid] > nums[right]) {
                // Minimum must be to the right
                left = mid + 1;
            } else {
                // Mid could itself be the minimum
                right = mid;
            }
        }

        return nums[left];
    }
}