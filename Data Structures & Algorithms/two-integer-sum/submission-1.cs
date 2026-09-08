public class Solution {
    // public int[] TwoSum(int[] nums, int target) {
    //     for (int i = 0; i < nums.Length; i++) {
    //         for (int j = i + 1; j < nums.Length; j++) {
    //             if (nums[i] + nums[j] == target) {
    //                 return new int[] {i, j};
    //             }
    //         }
    //     }
    //     return new int[] {};
    // }
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int, int> seen = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++) {
            int complement = target - nums[i];
            if (seen.ContainsKey(complement)) {
                return new int[] {seen[complement], i};
            } else {
                seen[nums[i]] = i;
            }
        }

        return new int[] {};
    }
}
