class Solution {
public:
    bool isPalindrome(string s)
{
	if (s.empty())
		return 1;
	vector<int> ref(s.length());
	bool Palindrome = true;
	regex pattern("^[a-z0-9]$");
	int vec_i = 0;
	for (int i = 0; i < (int)s.length(); i++)
	{
		if (s[i] <= 'Z' && s[i] >= 'A')
		{
			s[i] = tolower(s[i]);
		}
		string temp(1, s[i]);
		if (regex_match(temp, pattern))
		{
			ref[vec_i] = (int)s[i];
			vec_i++;
		}
	}

	ref.resize(vec_i);
	for (int i = 0, j = (int)ref.size() - 1; i < ((int)ref.size() / 2); i++, j--)
	{
		if (ref[i] != ref[j])
		{
			Palindrome = false;
		}
	}

	return Palindrome;
}
};
