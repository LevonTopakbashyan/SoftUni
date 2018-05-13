package ArraysExercises;

import java.util.Scanner;

public class p07_MostMetElement {

    public static void main(String[] args) {
        Scanner console = new Scanner(System.in);
        int n = console.nextInt();
        int[] numbers = new int[n];

        for (int i = 0; i < numbers.length; i++) {
            numbers[i] = console.nextInt();
        }

        for (int i = 0; i < numbers.length -1; i++) {

            int index = i;
            for (int j = i+1; j < numbers.length; j++) {
                if (numbers[j] < numbers[index]){
                    index = j;
                }
            }

            int smallerNumber = numbers[index];
            numbers[index] = numbers[i];
            numbers[i] = smallerNumber;
        }

        int currentLength = 1;
        int bestLength = 1;
        int position = 0;
        int bestPosition = 0;

        for (int i = 1; i < numbers.length; i++) {
            if (numbers[i] == numbers[i-1]){
                currentLength++;
                if (currentLength > bestLength){
                    bestLength = currentLength;
                    bestPosition = position;
                }
            }else {
                currentLength = 1;
                position = i;
            }
        }

        System.out.println("Element is: " + numbers[bestPosition]);
        System.out.println(bestLength + " times");
    }
}
