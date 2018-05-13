package SomeTasks;

import java.util.Scanner;

public class ProductFromNtoM {
    public static void main(String[] args) {
        Scanner console = new Scanner(System.in);
        int n = Integer.parseInt(console.nextLine());
        int m = Integer.parseInt(console.nextLine());
        result (n,m);
    }
    static void result (int n, int m){
        int result = 1;
        for (int i = n; i <= m; i++) {
            result *= i;
        }
        System.out.println(result);
    }
}
