class Solution:
    def isAnagram(self, s: str, t: str) -> bool:
        chars: List[int] = [0 for i in range(26)]

        if len(s) != len(t):
            return False

        for index in range(len(s)):
            chars[ord(s[index]) - 97] += 1

        for index in range(len(t)):
            chars[ord(t[index]) - 97] -= 1

        for i in range(26):
            if chars[i] != 0:
                return False

        return True
