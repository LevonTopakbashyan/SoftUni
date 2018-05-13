package SomeTasks;

import java.util.Scanner;

public class Matrix {
    public static void main(String[] args) {
        Scanner console = new Scanner(System.in);
        int n = Integer.parseInt(console.nextLine());
        result(n);
    }
    static void result (int n){
        for (int i = 1; i <= n; i++) {
            for (int j = i; j < n+i; j++) {
                System.out.print(j + " ");
            }
            System.out.println();
        }
    }
}
