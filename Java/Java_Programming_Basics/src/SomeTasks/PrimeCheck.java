package SomeTasks;

import java.util.Scanner;

public class PrimeCheck {
    public static void main(String[] args) {
        Scanner console = new Scanner(System.in);
        int num = Integer.parseInt(console.nextLine());
        prime(num);
    }
    static void prime (int num){
        boolean isPrime = true;
        for (int i = 2; i < Math.sqrt(num); i++) {
            if (isPrime){
                if (num % i == 0){
                    isPrime = false;
                }
            }
        }
        System.out.println(isPrime);
    }
}
