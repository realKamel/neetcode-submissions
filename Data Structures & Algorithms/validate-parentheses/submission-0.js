class Solution {
    /**
     * @param {string} s
     * @return {boolean}
     */
    isValid(s) {
		let ref = new Map();
		let stk = [];
		stk.length = 0;
		ref.set( ')', '(' );
		ref.set( '}', '{' );
		ref.set( ']', '[' );
		console.log( ref.get( ']' ) )
		for ( const ch of s ) {
			if ( ref.has( ch ) ) {
				if ( stk.length === 0 || ref.get( ch ) != stk[ stk.length - 1 ] ) {
					return false;
				}
				else {
					stk.pop();
				}
			}

			else stk.push( ch );
		}

		return stk.length === 0;
    }
}
