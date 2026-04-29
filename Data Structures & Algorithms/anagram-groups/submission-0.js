class Solution {
    /**
     * @param {string[]} strs
     * @return {string[][]}
     */
    groupAnagrams(strs) {
        let map = new Map();
		for ( const it of strs ) {
			let x = it.split( "" ).sort().join( "" );
			if ( map.has( x ) ) {
				let temp = map.get( x )
				temp.push( it );
				map.set( x, temp );
			}
			else {

				map.set( x, [ it ] );
			}
		}
		return [ ...map.values() ];
    }
}
