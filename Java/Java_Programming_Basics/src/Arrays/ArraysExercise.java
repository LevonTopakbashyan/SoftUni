package Arrays;

import java.lang.reflect.Array;
import java.util.Arrays;

public class ArraysExercise {
    public static void main(String[] args) {
        int[] array = new int[20];
        for (int i = 0; i < array.length; i++) {
            array[i] = i*5;
        }
        System.out.println(Arrays.toString(array));
    }
}
