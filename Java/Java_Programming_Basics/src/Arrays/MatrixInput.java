package Arrays;

import java.lang.reflect.Array;
import java.util.Arrays;
import java.util.Scanner;

public class MatrixInput {
    public static void main(String[] args) {
        Scanner console = new Scanner(System.in);
        int rows = Integer.parseInt(console.nextLine());
        int cols = Integer.parseInt(console.nextLine());
        
        int[][] matrix = new int[rows][cols];
        for (int row = 0; row < rows; row++) {
            for (int col = 0; col < cols; col++) {
                System.out.printf("Matrix[%d,%d] = ",row,col);
                matrix[row][col] = Integer.parseInt(console.nextLine());
            }
        }
        System.out.println(Arrays.deepToString(matrix));
    }
}
