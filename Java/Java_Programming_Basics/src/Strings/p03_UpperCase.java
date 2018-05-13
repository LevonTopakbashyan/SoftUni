package Strings;

public class p03_UpperCase {

    public static void main(String[] args) {

        String text = "We are living in the <upcase>Yellow submarine</upcase>. We don't have <upcase>anything</upcase> else.";
        String[] splitText = text.split("[\\s]");

        int index = text.indexOf("<upcase>");
        int index2 = text.indexOf("</upcase>");

        for (int i = index; i < index2; i++) {
            splitText[i] = text.toUpperCase();
        }

        for (String s : splitText){
            System.out.println(s);
        }
    }
}
