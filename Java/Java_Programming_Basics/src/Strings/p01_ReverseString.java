package Strings;

import java.util.Scanner;

public class p01_ReverseString {

    public static void main(String[] args) {
        Scanner console = new Scanner(System.in);
        String text = console.nextLine();

        String reverseText = reverseText(text);
        System.out.println(reverseText);
    }

    public static String reverseText(String text) {
        StringBuilder sb = new StringBuilder();

        for (int i = text.length()-1; i >= 0; i--) {
            sb.append(text.charAt(i));
        }

        return sb.toString();
    }
}
