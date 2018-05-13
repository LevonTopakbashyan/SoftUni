package SomeTasks;

import java.util.Scanner;

public class Cards {
    public static void main(String[] args) {
        Scanner console = new Scanner(System.in);
        for (int i = 0; i < 4; i++) {
            for (int j = 1; j < 15; j++) {
                System.out.print(j + " ");
            }
            System.out.println();
        }
    }
}
