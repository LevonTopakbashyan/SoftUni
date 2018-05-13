package Objects;

import Objects.chapter10.Cat;
import Objects.chapter10.Sequence;

import java.util.ArrayList;
import java.util.Arrays;
import java.util.List;

public class p04_MakingCats {

    public static void main(String[] args) {

        Cat[] cats = new Cat[10];

        for (int i = 0; i <cats.length; i++) {
            cats[i] = new Cat("Cat"+Sequence.nextValue(),"black");
        }

        for (int i = 0; i < cats.length; i++) {
            cats[i].sayMeow();
        }
    }
}
