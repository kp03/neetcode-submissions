public class Solution {
    public int MaxArea(int[] heights) {
        int left = 0, right = heights.Length - 1;
        int currentMax = 0;
        
        while (left < right) {
            int width = right - left;
            int height = Math.Min(heights[right], heights[left]);
            int currentArea = width * height;

            currentMax = Math.Max(currentMax, currentArea);
            if (heights[left] < heights[right] ) {
                left++;
            } else {
                right--;
            }
        }

        return currentMax;
    }
}
