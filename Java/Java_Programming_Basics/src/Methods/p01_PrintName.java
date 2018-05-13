package Methods;

import java.util.Scanner;

public class p01_PrintName {

    public static void main(String[] args) {

        Scanner console = new Scanner(System.in);
        String name = console.nextLine();

        printName(name);
    }

    public static void printName(String name) {
        System.out.println("Hello, " + name);
    }
}
