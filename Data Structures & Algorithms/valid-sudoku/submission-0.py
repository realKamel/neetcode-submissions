class Solution:
    def isValidSudoku(self, board: List[List[str]]) -> bool:
        digit_occurrences = set[int]()
        occurrences = defaultdict(set)
        for i in range(9):
            digit_occurrences.clear()
            # print()
            for j in range(9):
                # print(board[i][j], end="")
                if ord(board[i][j]) != 46:
                    current_digit = int(board[i][j])
                    if (current_digit in digit_occurrences):
                        return False
                    else:
                        digit_occurrences.add(current_digit)

        for i in range(9):
            digit_occurrences.clear()
            # print()
            for j in range(9):
                # print(board[i][j], end="")
                current_value = board[j][i]
                if current_value != ".":
                    current_digit = int(current_value)
                    if (current_digit in digit_occurrences):
                        return False
                    else:
                        digit_occurrences.add(current_digit)

        for r in range(9):
            for c in range(9):
                if board[r][c] == ".":
                    continue
                if (board[r][c] in occurrences[(r//3, c//3)]):
                    return False
                occurrences[(r//3, c//3)].add(board[r][c])
        return True