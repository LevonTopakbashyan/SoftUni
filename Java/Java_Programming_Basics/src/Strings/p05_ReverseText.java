package Strings;

public class p05_ReverseText {

    public static void main(String[] args) {

        String text = "C# is not C++ and PHP is not Delphi";

        String[] splitText = text.split(" ");

        String reversedText = reverseText(splitText);
        System.out.println(reversedText);
    }

    public static String reverseText(String[] text) {
        StringBuilder sb = new StringBuilder();

        for (int i = text.length - 1; i >= 0; i--) {
            sb.append(text[i]);
            sb.append(" ");
        }
        return sb.toString().trim();
    }

}
