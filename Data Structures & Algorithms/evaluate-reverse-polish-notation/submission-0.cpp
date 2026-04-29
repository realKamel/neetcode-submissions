#include <charconv>
class Solution {
public:
    int evalRPN(vector<string> &tokens)
{
	if (0 == tokens.size())
		return 0;
	else
	{
		int res = 0;
		stack<int> stk;
		for (int i = 0; i < (int)tokens.size(); i++)
		{
			int x;
			if (tokens[i] != "*" && tokens[i] != "+" && tokens[i] != "-" && tokens[i] != "/")
			{
				std::from_chars(tokens[i].data(), tokens[i].data() + (int)tokens[i].size(), x);
				stk.push(x);
			}
			else
			{
				int temp2 = stk.top();
				stk.pop();
				int temp1 = stk.top();
				stk.pop();
				switch (tokens[i][0])
				{
				case 42:
					stk.push(temp1 * temp2);
					break;
				case 43:
					stk.push(temp1 + temp2);
					break;
				case 45:
					stk.push(temp1 - temp2);
					break;
				case 47:
					stk.push(temp1 / temp2);
					break;
				default:
					break;
				}
			}
		}
		return stk.top();
	}
	return 0;
}
};
