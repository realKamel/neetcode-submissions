class Solution {
    /**
     * @param {number[]} nums
     * @param {number} k
     * @return {number[]}
     */
    maxSlidingWindow(nums, k) {
        
		if ( k <= 0 || k > nums.length ) return {};
		let maxone = [];
		let window = [];
		for ( let i = 0; i < k; i++ ) {
			window.push( nums[ i ] );
		}
		window.sort( ( a, b ) => b - a );
		maxone.push( window[ 0 ] );
		for ( let i = k; i < nums.length; i++ ) {
			window.splice( window.indexOf( nums[ i - k ] ), 1 )
			window.push( nums[ i ] );
			window.sort( ( a, b ) => b - a );
			maxone.push( window[ 0 ] );
		}
		return maxone;
    }
}
