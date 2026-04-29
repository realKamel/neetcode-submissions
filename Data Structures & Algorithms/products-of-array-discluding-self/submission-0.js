class Solution {
    /**
     * @param {number[]} nums
     * @return {number[]}
     */
    productExceptSelf(nums) {
        let map = new Map();

		for ( let i = 0; i < nums.length; i++ ) {
			let r = 1;
			for ( let j = 0; j < nums.length; j++ ) {
				if ( i === j ) {
					continue;
				} else {
					r *= nums[ j ];
				}
			}
			map.set( i, r );
		}
		return [ ...map.values() ];
    }
}
