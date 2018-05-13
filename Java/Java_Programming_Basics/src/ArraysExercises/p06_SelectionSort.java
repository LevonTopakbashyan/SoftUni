package ArraysExercises;

import java.util.Scanner;

public class p06_SelectionSort {

    public static void main(String[] args) {
        Scanner console = new Scanner(System.in);

        int arrayLength = console.nextInt();
        int[] numbers = new int[arrayLength];

        for (int i = 0; i < numbers.length; i++) {
            numbers[i] = console.nextInt();
        }

        for (int i = 0; i < numbers.length - 1; i++)
        {
            int index = i;
            for (int j = i + 1; j < numbers.length; j++)
                if (numbers[j] < numbers[index])
                    index = j;

            int smallerNumber = numbers[index];
            numbers[index] = numbers[i];
            numbers[i] = smallerNumber;
        }

        for (int number: numbers) {
            System.out.println(number);
        }
    }
}
