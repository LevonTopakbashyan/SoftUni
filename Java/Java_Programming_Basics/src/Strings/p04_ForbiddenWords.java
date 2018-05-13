package Strings;

import java.util.Scanner;

public class p04_ForbiddenWords {

    public static void main(String[] args) {
        Scanner console = new Scanner(System.in);
        String[] forbiddenWords = {"Java", "JVM", "Microsoft"};
        String text = "Microsoft announced its next generation Java compiler today. It uses advanced parser and special optimizer for the Microsoft JVM";

        String[] splitText = text.split(" ");

        for (int i = 0; i < splitText.length; i++) {
            for (int j = 0; j < forbiddenWords.length; j++) {
                if (splitText[i].equals(forbiddenWords[j])){
                    int length = forbiddenWords[j].length();
                    splitText[i] = "*";
                    for (int k = 0; k < length-1; k++) {
                        splitText[i] += "*";
                    }
                }
            }
        }

        for (String s : splitText){
            System.out.print(s + " ");
        }
    }
}
