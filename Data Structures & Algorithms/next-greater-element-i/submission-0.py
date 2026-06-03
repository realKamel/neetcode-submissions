class Solution:
    def nextGreaterElement(self, nums1: List[int], nums2: List[int]) -> List[int]:
        next_greater = defaultdict(lambda: -1)
        stack = []

        for i in range(len(nums2)):
            if not stack or nums2[stack[-1]] >= nums2[i]:
                stack.append(i)

            while stack and nums2[stack[-1]] < nums2[i]:
                next_greater[stack[-1]] = i
                stack.pop()
            stack.append(i)
        result = []

        for item in nums1:
            idx = nums2.index(item)
            if next_greater[idx] != -1:
                result.append(nums2[next_greater[idx]])
            else:
                result.append(-1)

        return result
