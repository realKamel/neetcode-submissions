class Solution {
    /**
     * @param {number[]} nums
     * @return {number}
     */
    longestConsecutive(nums) {
		if ( nums.length === 0 ) { return 0; }
		let set = new Set( nums );
		let arr = Array.from( set );
		arr.sort( ( a, b ) => a - b );
		let lastMax = -1;
		let count = 1;
		for ( let i = 1; i < arr.length; i++ ) {
			if ( ( arr[ i - 1 ] + 1 ) === arr[ i ] ) {
				count++;
			}
			else {
				lastMax = Math.max( lastMax, count );
				count = 1;
			}
		}
		return Math.max( lastMax, count )
    }
}
