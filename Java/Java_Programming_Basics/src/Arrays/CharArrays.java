package Arrays;

import java.util.Scanner;

public class CharArrays {
    public static void main(String[] args) {
        Scanner console = new Scanner(System.in);
        int n = Integer.parseInt(console.nextLine());
        int m = Integer.parseInt(console.nextLine());
        String[] firstArray = new String[n];
        String[] secondArray = new String[m];
        for (int i = 0; i < firstArray.length-1; i++) {
            if (firstArray[i].charAt(i) != secondArray[i].charAt(i)){
                System.out.println("First is " + firstArray);
            }
        }
    }
}
