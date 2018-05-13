package SomeTasks;

import java.util.Scanner;

public class Fibonacci {
    public static void main(String[] args) {
        Scanner console = new Scanner(System.in);
        int n = Integer.parseInt(console.nextLine());
        result(n);
    }
    public static void result (int n){
        int f1 = 0;
        int f2 = 1;
        int sum = 0;
        for (int i = 1; i <= n; i++) {
            int nextF = f1+f2;
            f1 = f2;
            f2=nextF;
            sum+=f1;
        }
        System.out.println(sum);
    }
}
