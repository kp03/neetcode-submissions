public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        Dictionary<int, int> frequency = new Dictionary<int, int>();
        int[] result = new int[k];

        for (int i = 0; i < nums.Length; i++) {
            if (!frequency.ContainsKey(nums[i])) {
                frequency[nums[i]] = 1;
            }
            frequency[nums[i]] += 1;
        }

        for (int i = 0; i < k; i++) {
            int maxKey = frequency.MaxBy(kvp => kvp.Value).Key;    
            result[i] = maxKey;
            frequency.Remove(maxKey);
        }

        return result;
    }
}
