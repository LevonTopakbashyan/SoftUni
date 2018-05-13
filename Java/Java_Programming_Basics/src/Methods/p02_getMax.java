package Methods;

import java.util.Scanner;

public class p02_getMax {

    public static void main(String[] args) {
        Scanner console = new Scanner(System.in);
        int firstNumber = console.nextInt();
        int secondNumber = console.nextInt();
        int thirdNumber = console.nextInt();

        int maxFromFirstAndSecond = getMax(firstNumber, secondNumber);
        int maxNumber = getMax(maxFromFirstAndSecond,thirdNumber);

        System.out.println(maxNumber);
    }

    public static int getMax(int firstNumber, int secondNumber) {
        return Math.max(firstNumber,secondNumber);
    }
}
