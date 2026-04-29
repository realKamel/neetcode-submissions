class Solution:
    def maxArea(self, heights: List[int]) -> int:
        head = 0
        tail = len(heights)-1

        max_area = -1
        while head < tail:
            height = heights[head] if heights[head] < heights[tail] else heights[tail]
            current_area = (tail-head) * height
            if current_area > max_area:
                max_area = current_area

            if heights[head] > heights[tail]:
                tail -= 1
            else:
                head += 1
        return max_area