package Methods;

import java.util.Scanner;

public class p06_Factorial {

    public static void main(String[] args) {
        Scanner console = new Scanner(System.in);
        int number = console.nextInt();
        int sum = 1;

        System.out.println(factorial(sum, number));
    }

    public static int factorial(int sum, int number) {
        if (number < 1){
            return sum;
        }
        sum *= number;

        return factorial(sum , number - 1);
    }
}
