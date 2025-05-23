public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        int n = nums.Length;
        int[] result = new int[n];
        result[0] = 1;
        for (int i = 1; i < n; i++) {
            result[i] = result[i - 1] * nums[i - 1];
        }
        int prod = 1;
        for (int i = n - 1; i >= 0; i--) {
            result[i] *= prod;
            prod *= nums[i];
        }
        return result;
    }
}
