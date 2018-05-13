package Methods;

import java.util.Scanner;

public class p05_ReverseNumber {

    public static void main(String[] args) {
        Scanner console = new Scanner(System.in);
        int number = console.nextInt();

        reverseNumber(number);
    }

    public static void reverseNumber(int number) {
        String numberAsString = String.valueOf(number);
        String newNumber = "";

        for (int i = numberAsString.length() - 1; i >= 0; i--) {
            char ch = numberAsString.charAt(i);
            newNumber += String.valueOf(ch);
        }

        System.out.println(newNumber);
    }
}
