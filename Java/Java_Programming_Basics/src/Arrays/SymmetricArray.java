package Arrays;

import java.util.Scanner;

public class SymmetricArray {
    public static void main(String[] args) {
        Scanner console = new Scanner(System.in);
        int n = Integer.parseInt(console.nextLine());
        int[] array = new int[n];
        int length = array.length;
        for (int i = 0; i < n; i++) {
            array[i] = Integer.parseInt(console.nextLine());
        }
        boolean symmetric = true;
        for (int i = 0; i < (length+1)/2; i++) {
            if (array[i] != array[length - i -1]){
                symmetric = false;
            }
        }
        System.out.println(symmetric);
    }
}
