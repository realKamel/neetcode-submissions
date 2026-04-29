class Solution:
    def twoSum(self, nums: List[int], target: int) -> List[int]:
        listLen = len(nums)
        if (listLen == 2):
            return [0, 1]
        numsMap: dict[int, int] = {}
        numsMap[nums[0]] = 0

        for index in range(1, listLen):
            wantedValue = target - nums[index]
            itemOrFound = numsMap.get(wantedValue, False)
            if (itemOrFound is not False):
                return [numsMap.get(wantedValue, -1), index]
            numsMap[nums[index]] = index