package ArraysExercises;

import java.util.Scanner;

public class p02_EqualArrays {

    public static void main(String[] args) {
        Scanner console = new Scanner(System.in);

        int firstArrayLength = console.nextInt();
        int secondArrayLength = console.nextInt();

        int[] firstArray = new int[firstArrayLength];
        int[] secondArray = new int[secondArrayLength];

        for (int i = 0; i < firstArray.length; i++) {
            firstArray[i] = console.nextInt();
        }

        for (int i = 0; i < secondArray.length; i++) {
            secondArray[i] = console.nextInt();
        }

        boolean isEqual = true;

        if (firstArray.length != secondArray.length){
            isEqual = false;
        }else {
            for (int i = 0; i < firstArray.length; i++) {
                if (firstArray[i] != secondArray[i]){
                    isEqual = false;
                }
            }
        }

        System.out.println(isEqual);


    }
}
