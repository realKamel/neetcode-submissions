class Solution {
    /**
     * @param {number[]} nums
     * @param {number} k
     * @return {number[]}
     */
    topKFrequent(nums, k) {
        let ref = new Map();
		for ( const it of nums ) {
			if ( ref.has( it ) ) {
				let x = ref.get( it );
				x++
				ref.set( it, x );
			} else {
				ref.set( it, 1 );
			}
		}
		let temp = [ ...ref ].sort( ( a, b ) => b[ 1 ] - a[ 1 ] );
		temp = temp.map( ( a ) => { return a[ 0 ] } );
		temp.splice( k );
		return temp;
    }
}
