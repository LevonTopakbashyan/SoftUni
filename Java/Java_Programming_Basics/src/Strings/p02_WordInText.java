package Strings;

import java.util.Scanner;

public class p02_WordInText {

    public static void main(String[] args) {
        Scanner console = new Scanner(System.in);
        String word = console.nextLine();

        String text = "We are living in the yellow submarine. We don't have anything else. Inside the submarine is very tight. " +
                "So we are drinking all the day. We will move out of it in 5 days.";

        int counter = 0;
        int index = text.indexOf(word);

        while (index != -1){
            counter++;
            index = text.indexOf(word,index + 1);
        }

        if (counter != 0){
            counter++;
        }

        System.out.println(counter);
    }
}
