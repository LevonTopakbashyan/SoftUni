package ArraysExercises;

import java.lang.reflect.Array;
import java.util.ArrayList;
import java.util.Arrays;
import java.util.Scanner;

public class p05_MaxSumOfKElements {

    public static void main(String[] args) {
        Scanner console = new Scanner(System.in);
        int n = console.nextInt();
        int k = console.nextInt();

        int[] numbers = new int[n];

        for (int i = 0; i < numbers.length; i++) {
            numbers[i] = console.nextInt();
        }

        Arrays.sort(numbers);

        for (int i = numbers.length - k; i < numbers.length; i++) {
            System.out.println(numbers[i]);
        }
    }
}
