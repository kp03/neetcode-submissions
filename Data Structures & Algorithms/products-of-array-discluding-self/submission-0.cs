public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        int[] result = new int[nums.Length];

        int prefix = 1;
        for (int i = 0; i < nums.Length; i++) {
            result[i] = prefix;
            prefix *= nums[i];
        }

        int suffix = 1;
        for (int i = nums.Length - 1; i >= 0; i--) {
            result[i] *= suffix;
            suffix *= nums[i];
        }

        return result;
    }

    // public int[] ProductExceptSelf(int[] nums) {
    //     int[] result = new int[nums.Length];
    //     int[] prefix = new int[nums.Length];
    //     int totalProduct = 1;
    //     int zeroCount = 0;

    //     foreach (int num in nums) {
    //         if (num == 0) {
    //             zeroCount++;
    //         } else {
    //             totalProduct *= num;
    //         }
    //     }

    //     for (int i = 0; i < nums.Length; i++) {
    //         if (zeroCount > 1) {
    //             result[i] = 0;
    //         } else if (zeroCount == 1) {
    //             if (nums[i] == 0) {
    //                 result[i] = totalProduct;
    //             } else {
    //                 result[i] = 0;
    //             }
    //         } else {
    //             result[i] = totalProduct / nums[i];
    //         }
    //     }

    //     return result;
    // }

    // public int[] ProductExceptSelf(int[] nums) {
    //     int[] result = new int[nums.Length];
    //     int[] prefix = new int[nums.Length];
    //     int totalProduct = 1;
    //     int zeroCount = 0;

    //     foreach (int num in nums) {
    //         if (num == 0) {
    //             zeroCount++;
    //         } else {
    //             totalProduct *= num;
    //         }
    //     }

    //     for (int i = 0; i < nums.Length; i++) {
    //         if (zeroCount > 1) {
    //             result[i] = 0;
    //         } else if (zeroCount == 1) {
    //             if (nums[i] == 0) {
    //                 result[i] = totalProduct;
    //             } else {
    //                 result[i] = 0;
    //             }
    //         } else {
    //             result[i] = totalProduct / nums[i];
    //         }
    //     }

    //     return result;
    // }
    
    // public int[] ProductExceptSelf(int[] nums) {
    //     int[] result = new int[nums.Length];
    //     int[] prefix = new int[nums.Length];
    //     for (int i = 0; i < nums.Length; i++) {
    //         result[i] = 1;
    //         for (int j = 0; j < nums.Length; j++) {
    //             if (i != j) {
    //                 result[i] *= nums[j];
    //             }
    //         }
    //     }

    //     return result;
    // }
}
