public class Solution {
    public bool SearchMatrix(int[][] matrix, int target) {
               int[] linearMatrix = new int[matrix.Length * matrix[0].Length];

        var counter = 0;
        for (int i = 0; i < matrix.Length; i++)
        {
            for (int j = 0; j < matrix[0].Length; j++)
            {
                linearMatrix[counter] = matrix[i][j];
                counter++;
            }
        }

        int left = 0, right = linearMatrix.Length - 1;
        while (left <= right)
        {
            int middle = (left + right) / 2;
            if (target == linearMatrix[middle])
            {
                return true;
            }
            else if (target < linearMatrix[middle])
            {
                right = middle - 1;
            }
            else
            {
                left = middle + 1;
            }
        }
        return false;
    }
}
