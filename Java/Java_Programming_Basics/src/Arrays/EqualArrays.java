package Arrays;

import java.util.Scanner;

public class EqualArrays {
    public static void main(String[] args) {
        Scanner console = new Scanner(System.in);
        System.out.printf("Enter length of the first array: ");
        int n = Integer.parseInt(console.nextLine());
        int[] firstArray = new int[n];
        for (int i = 0; i < n; i++) {
            firstArray[i] = Integer.parseInt(console.nextLine());
        }
        System.out.printf("Enter length of the second array: ");
        int m = Integer.parseInt(console.nextLine());
        int[] secondArray = new int[m];
        for (int i = 0; i < m; i++) {
            secondArray[i] = Integer.parseInt(console.nextLine());
        }

        System.out.println(isEqual(firstArray,secondArray));
    }

    public static boolean isEqual(int[] firstArray, int[] secondArray){

        boolean isEqual = true;

        if (firstArray.length != secondArray.length){
            return isEqual = false;
        }

        for (int i = 0; i < firstArray.length; i++) {
            if (firstArray[i] != secondArray[i]){
                isEqual = false;
            }
        }


        return isEqual;
    }

}
