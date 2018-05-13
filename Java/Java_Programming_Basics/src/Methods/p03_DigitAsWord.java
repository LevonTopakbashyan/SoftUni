package Methods;

import java.util.Scanner;

public class p03_DigitAsWord {

    public static void main(String[] args) {
        Scanner console = new Scanner(System.in);
        int number = console.nextInt();

        String digit = digitAsWord(number);
        System.out.println(digit);
    }

    public static String digitAsWord(int number) {
        switch (number % 10){
            case 1:{
                return "one";
            }
            case 2:{
                return "two";
            }
            case 3:{
                return "three";
            }
            case 4:{
                return "four";
            }
            case 5:{
                return "five";
            }
            case 6:{
                return "six";
            }
            case 7:{
                return "seven";
            }
            case 8:{
                return "eight";
            }
            case 9:{
                return "nine";
            }
            case 0:{
                return "zero";
            }
            default:{
                return "wrong input";
            }
        }
    }
}
