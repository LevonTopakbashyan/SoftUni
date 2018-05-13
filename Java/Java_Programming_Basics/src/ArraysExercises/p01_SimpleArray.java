package ArraysExercises;

public class p01_SimpleArray {

    public static void main(String[] args) {

        int[] myArray = new int[20];

        for (int i = 0; i < myArray.length; i++) {
            myArray[i] = i*5;
        }

        for (int number: myArray) {
            System.out.println(number);
        }
    }
}
