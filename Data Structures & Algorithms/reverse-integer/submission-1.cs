public class Solution {
    public int Reverse(int x) {
        if (x == 0)
        return 0;
    bool isNegative = x < 0;
    uint current = x > 0 ? (uint)x : (uint)-x;
    long result = current % 10;
    current /= 10;
    while (current > 0)
    {
        result *= 10;
        result += current % 10;
        current /= 10;
    }
    if (result > int.MaxValue)
        return 0;
    if (isNegative)
        return (int)-result;
    else
        return (int)result;
    }
}
