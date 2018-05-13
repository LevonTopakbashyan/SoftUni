package SomeTasks;

import java.util.Scanner;

public class PrimeNumberFromNtoM {
    public static void main(String[] args) {
        Scanner console = new Scanner(System.in);
        int n = Integer.parseInt(console.nextLine());
        int m = Integer.parseInt(console.nextLine());
        result (n,m);
    }
    static void result (int n, int m){
        boolean isPrime = true;
        for (int i = n; i <= m; i++) {
            int divider = 2;
            if(isPrime){
                if (i % divider ==0){
                    isPrime = false;
                }
                if (isPrime){
                    System.out.print(i + " ");
                }
            }
            isPrime=true;
        }
    }
}
