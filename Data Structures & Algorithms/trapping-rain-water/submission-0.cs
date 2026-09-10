public class Solution {
    public int Trap(int[] height) {
        int left = 0, right = height.Length - 1;
        int leftMax = height[left], rightMax = height[right];
        int trapped = 0;

        while (left < right) {
            if (height[left] > leftMax) {
                leftMax = height[left];
            } else {
                trapped += leftMax - height[left];
            }

            if (height[right] > rightMax) {
                rightMax = height[right];
            } else {
                trapped += rightMax - height[right];
            }

            if (leftMax < rightMax) {
                left++;
            } else {
                right--;
            }
        }

        return trapped;
    }
}
