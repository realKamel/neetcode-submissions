class Solution:
    def myPow(self, x: float, n: int) -> float:
        if n == 0 or x == 1:
            return 1

        if n == 1:
            return x

        isNegative = n < 0

        if isNegative:
            n = -n

        if isNegative:
            return 1 / self.helper(x, n)
        return self.helper(x, n)

    def helper(self, x, n):
        if n == 0 and x == 0:
            return 0

        if n == 0 or x == 1:
            return 1

        if n % 2 == 0:
            return self.helper(x * x, n // 2)
        else:
            return x * self.helper(x * x, n // 2)