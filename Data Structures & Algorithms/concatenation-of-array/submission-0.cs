public class Solution {
    public int[] GetConcatenation(int[] nums) {
        int[] ans = new int[2*nums.Length];
        int j = 0;
        for (int i = 0; i < ans.Length; i++) {
            if (i == nums.Length) {
                j = 0;
            }
            ans[i] = nums[j];
            j++;
        }

        return ans;
    }
}