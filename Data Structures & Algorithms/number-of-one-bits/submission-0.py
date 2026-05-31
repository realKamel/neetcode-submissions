class Solution:
    def hammingWeight(self, n: int) -> int:
        coutner = 0
        while n > 0:
            n = n&(n-1);
            coutner +=1
        return coutner;