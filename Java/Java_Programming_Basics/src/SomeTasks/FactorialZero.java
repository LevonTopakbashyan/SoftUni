package SomeTasks;

import java.util.Scanner;

public class FactorialZero {
    public static void main(String[] args) {
        Scanner console = new Scanner(System.in);
        int n = Integer.parseInt(console.nextLine());
        result (n);
    }
    static void result (int n){
        int divider = 10;
        int count = 0;
        long nFactorial = 1;
        for (int i = 1; i <= n; i++) {
            nFactorial *= i;
            if (nFactorial % divider == 0){
                count++;
                divider *= 10;
            }
        }
        System.out.println(count);
    }
}
