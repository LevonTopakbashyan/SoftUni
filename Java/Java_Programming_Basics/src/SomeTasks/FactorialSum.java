package SomeTasks;

import java.util.Scanner;

public class FactorialSum {
    public static void main(String[] args) {
        Scanner console = new Scanner(System.in);
        int n = Integer.parseInt(console.nextLine());
        int k = Integer.parseInt(console.nextLine());
        result (n,k);
        product(n,k);
    }
    static void result (int n, int k){
        int nFactorial = 1;
        int kFactorial = 1;
        int sum = 0;
        for (int i = 1; i <= n; i++) {
            nFactorial *= i;
        }
        for (int i = 1; i <= k; i++) {
            kFactorial *= i;
        }
        sum = nFactorial/kFactorial;
        System.out.println(sum);
    }
    static void product (int n, int k){
        int nFactorial = 1;
        int kFactorial = 1;
        int product = 1;
        int newFactorial = (n-k);
        int newFact = 1;
        for (int i = 1; i <= n; i++) {
            nFactorial *= i;
        }
        for (int i = 1; i <= k; i++) {
            kFactorial *= i;
        }
        for (int i = 1; i <= newFactorial; i++) {
            newFact *= i;
        }
        product = (nFactorial*kFactorial)/newFact;
        System.out.println(product);
    }
}
