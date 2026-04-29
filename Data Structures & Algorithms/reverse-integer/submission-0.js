class Solution {
    /**
     * @param {number} x
     * @return {number}
     */
    reverse(x) {
        let ref = x;
        let out = 0;

    if(x < 0)
      {  ref *= (-1);}

    while (ref > 0)
    {
        let temp = ~~(ref % 10);
        out *= 10;
        out += temp;
        ref = ~~(ref / 10)
    }
    if(out >2147483647)
        return 0;
    return (x < 0)? out *= (-1): out;
    }

}
