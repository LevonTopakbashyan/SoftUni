package Methods;

import java.util.Scanner;

public class p04_DigitInArray {

    public static void main(String[] args) {
        Scanner console = new Scanner(System.in);
        int n = console.nextInt();
        int[] numbers = new int[n];

        for (int i = 0; i < numbers.length; i++) {
            numbers[i] = console.nextInt();
        }

        System.out.println("Enter searching number: ");
        int searchingNumber = console.nextInt();
        int counter = digitInArray(searchingNumber,numbers);

        System.out.println(counter);
    }

    public static int digitInArray(int searchingNumber,int... numbers) {
        int counter = 0;
        for (int i = 0; i < numbers.length; i++) {
            if (numbers[i] == searchingNumber){
                counter++;
            }
        }

        return counter;
    }
}
