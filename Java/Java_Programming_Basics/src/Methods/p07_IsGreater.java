package Methods;

import java.util.Scanner;

public class p07_IsGreater {

    public static void main(String[] args) {
        Scanner console = new Scanner(System.in);
        int[] numbers = new int[6];

        for (int i = 0; i < numbers.length; i++) {
            numbers[i] = console.nextInt();
        }

        System.out.println("Enter index of number");
        int index = console.nextInt();
        if (index < 1 || index > numbers.length-1){
            System.out.println("Incorrect input!");
            return;
        }

        boolean isGreater = isGreater(index,numbers);
        System.out.println(isGreater);

    }

    public static boolean isGreater(int index, int[] numbers) {
        boolean isGreater = false;

        if ((numbers[index] > numbers[index-1]) && (numbers[index] > numbers[index+1])){
            isGreater = true;
        }

        return isGreater;
    }
}
