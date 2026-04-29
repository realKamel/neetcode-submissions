class Solution {
    /**
     * @param {string} s
     * @param {string} t
     * @return {boolean}
     */
    isAnagram(s, t) {
	if ( s.length !== t.length )
		return false;
	else {
		let map = new Map();

		for ( const e of s ) {
			if ( map.has( e ) ) {
				map.set( e, map.get( e ) + 1 );
			}
			else {
				map.set( e, 1 );
			}
		}
		for ( const e of t ) {
			if ( map.get( e ) > 1 )
				map.set( e, map.get( e ) - 1 );
			else { map.delete( e ); }
		}
		console.log( map.size === 0 );
		return map.size === 0;
	}
}
}
