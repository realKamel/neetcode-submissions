class Solution {
    /**
     * @param {number[]} nums
     * @return {boolean}
     */
    hasDuplicate(nums) {
        let myset = new Set(nums);
        if(myset.size !== nums.length)
        {
            return true
        }else
            return false
    }
}
