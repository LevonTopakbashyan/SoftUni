package ArraysExercises;

import java.util.Scanner;

public class p04_BestIncreasingSequence {

    public static void main(String[] args) {
        Scanner console = new Scanner(System.in);

        int arrayLength = console.nextInt();
        int[] numbers = new int[arrayLength];

        for (int i = 0; i < numbers.length; i++) {
            numbers[i] = console.nextInt();
        }

        int currentLength = 1;
        int bestLength = 1;
        int currentPosition = 0;
        int bestPosition = 0;

        for (int i = 1; i < numbers.length; i++) {
            if (numbers[i] == (numbers[i-1])+1){
                currentLength++;
                if (bestLength < currentLength){
                    bestLength = currentLength;
                    bestPosition = currentPosition;
                }
            }else {
                currentLength = 1;
                currentPosition = i;
            }
        }

        for (int i = 0; i < bestLength; i++) {
            System.out.println(numbers[bestPosition + i]);
        }

    }
}
