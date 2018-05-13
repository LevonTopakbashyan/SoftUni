package Objects;

import java.util.Scanner;

public class p01_FindingHypotenuse {

    public static void main(String[] args) {
        Scanner console = new Scanner(System.in);
        int sideA = console.nextInt();
        int sideB = console.nextInt();

        double hypotenuse = Math.sqrt((sideA*sideA + sideB*sideB));

        System.out.println(hypotenuse);
    }
}
