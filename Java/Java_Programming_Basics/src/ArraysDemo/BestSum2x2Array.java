package ArraysDemo;

import java.util.Scanner;

public class BestSum2x2Array {

    public static void main(String[] args) {

        int[][] myArray = {
                {0, 2, 4, 0, 9, 5},
                {7, 1, 3, 3, 2, 1},
                {1, 3, 9 ,8, 5, 6},
                {4, 6, 7, 9, 1, 0,}
        };

        int bestSum = Integer.MIN_VALUE;
        int bestRow = 0;
        int bestCol = 0;

        for (int rows = 0; rows < myArray.length-1; rows++) {
            for (int col = 0; col < myArray[rows].length-1; col++) {
                int sum = myArray[rows][col] + myArray[rows][col+1]+
                        myArray[rows+1][col] + myArray[rows+1][col+1];
                if (sum > bestSum){
                    bestSum = sum;
                    bestCol = col;
                    bestRow = rows;
                }
            }
        }

        System.out.printf(" %d\t%d\n",myArray[bestRow][bestCol],myArray[bestRow][bestCol+1]);
        System.out.printf(" %d\t%d\n",myArray[bestRow+1][bestCol],myArray[bestRow+1][bestCol+1]);

        System.out.println(bestSum);
    }
}
