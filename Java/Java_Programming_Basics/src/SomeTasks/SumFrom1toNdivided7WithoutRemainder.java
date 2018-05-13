package SomeTasks;

import java.util.Scanner;

public class SumFrom1toNdivided7WithoutRemainder {
    public static void main(String[] args) {
        Scanner console = new Scanner(System.in);
        int n = Integer.parseInt(console.nextLine());
        result(n);
    }
    static void result (int n){
        int sum = 0;
        for (int i = 1; i <= n; i++) {
            if (i % 7 != 0){
                sum += i;
            }
        }
        System.out.println(sum);
    }
}
