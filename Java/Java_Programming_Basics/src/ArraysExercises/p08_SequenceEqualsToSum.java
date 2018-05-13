package ArraysExercises;

import java.util.Scanner;

public class p08_SequenceEqualsToSum {

    public static void main(String[] args) {
        Scanner console = new Scanner(System.in);
        int sumForSearching = console.nextInt();

        int[] numbers = {4, 3, 1, 4, 2, 5,8};

        int currentPosition = 0;
        int bestPosition = 0;
        int currentLength = 1;
        int bestLength = 1;

        int sum = 0;

        for (int i = 0; i < numbers.length; i++) {
            for (int j = i; j < numbers.length; j++) {
                sum += numbers[j];
                currentLength++;
                if (sum == sumForSearching){
                    bestPosition = i;
                    if (currentLength > bestLength){
                        bestLength = currentLength;
                    }
                }
            }
            sum = 0;
            currentLength = 0;
        }


        for (int i = 0; i < bestLength; i++) {
            System.out.println(numbers[bestPosition+i]);
        }
    }
}
