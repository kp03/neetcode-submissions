public class Solution {
    public List<List<int>> ThreeSum(int[] nums) {
        // sort the nums first
        Array.Sort(nums);
        List<List<int>> result = new List<List<int>>();

        for (int i = 0; i < nums.Length; i++)
        {

            if (i > 0 && nums[i] == nums[i-1]) continue;

            int left = i + 1;
            int right = nums.Length - 1;
            int target =  -(nums[i]);

            while (left < right)
            {
                int sum = nums[left] + nums[right];
                if (sum == target)
                {
                    List<int> triplet = [nums[i], nums[left], nums[right]];
                    result.Add(triplet);
                    left++;
                    right--;

                    // Skip duplicate left values
                    while (left < right && nums[left] == nums[left - 1]) {
                        left++;
                    }

                    // Skip duplicate right values
                    while (left < right && nums[right] == nums[right + 1]) {
                        right--;
                    }
                }
                else if (sum < target) {
                    left++;
                }
                else {
                    right--;
                }
            }
        }

        return result;
    }
}
