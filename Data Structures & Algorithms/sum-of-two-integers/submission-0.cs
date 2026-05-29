public class Solution {
    public int GetSum(int a, int b) {
            while (b != 0)
    {
        var rawSum = a ^ b;
        var carry = a & b;
        a = rawSum;
        b = carry << 1;
    }
    return Convert.ToInt32(a);
    }
}
