package Arrays;
public class ArraySequenceIdentical {
    public static void main(String[] args) {
        int[] array = {2, 1, 1, 2, 3, 3, 2, 2, 2, 1};
        for (int i = 0; i < array.length-1; i++) {
            if (array[i] == array[i+1]){
                System.out.print(array[i] + " ");
            }
        }
    }
}
