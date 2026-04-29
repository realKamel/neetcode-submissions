class Solution:

    def encode(self, strs: List[str]) -> str:
        wordsCount = len(strs)
        encodedString = f"{wordsCount + 100}"
        for word in strs:
            encodedString += f"{len(word)+200}"
        for word in strs:
            encodedString += f"{word}"
        return encodedString

    def decode(self, s: str) -> List[str]:
        words: List[str] = []
        totalWordsCount = int(s[0:3]) - 100
        counts = s[3:totalWordsCount*3+3]
        # counts =
        wordCount: List[int] = []
        countsStart = 0
        for c in range(totalWordsCount):
            currentCount = int(counts[countsStart:countsStart + 3]) - 200
            wordCount.append(currentCount)
            countsStart += 3

        string = s[totalWordsCount * 3 + 3:]

        currentStart = 0
        for count in wordCount:
            words.append(string[currentStart: currentStart + count])
            currentStart += count
        return words
