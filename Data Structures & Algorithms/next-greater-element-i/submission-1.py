class Solution:
    def nextGreaterElement(self, nums1: List[int], nums2: List[int]) -> List[int]:
        next_greater = defaultdict(lambda: -1)
        stack = []

        for i in range(len(nums2)):
            while stack and stack[-1] < nums2[i]:
                next_greater[stack[-1]] = nums2[i]
                stack.pop()
            stack.append(nums2[i])

        result = []
        for item in nums1:
            result.append(next_greater[item])

        return result
