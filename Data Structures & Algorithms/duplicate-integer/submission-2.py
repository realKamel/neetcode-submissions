class Solution:
    def hasDuplicate(self, nums: List[int]) -> bool:
        occurrences: Set[int] = set(nums)
        return len(occurrences) != len(nums)
        