namespace LeetCode;
public class TwoSumSolution
{
    public int[] TwoSum(int[] nums, int target)
    {
        Dictionary<int, int> caches = new Dictionary<int, int>();
        for (int i = nums.Length - 1; i >= 0; i--)
        {
            if (caches.ContainsKey(target - nums[i]))
            {
                return new int[] { caches[target - nums[i]], i
};
            }
            if (!caches.ContainsKey(nums[i]))
            {
                caches.Add(nums[i], i);
            }
        }

        return new int[0];
    }
}

