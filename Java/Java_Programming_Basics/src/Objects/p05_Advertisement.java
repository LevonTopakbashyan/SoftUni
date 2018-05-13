package Objects;

import java.util.Random;

public class p05_Advertisement {

    public static final String[] PHRASES = {"Продуктът е отличен.", "Това е страхотен продукт.",
            "Постоянно ползвам този продукт.", "Това е най-добрият продукт от тази категория."};

    public static final String[] EVENTS = {"Вече се чувствам добре.", "Успях да се променя.", "Той направи чудо.",
        "Не мога да повярвам, но вече се чувствам страхотно.", "Опитайте и вие. Аз съм много доволна."};

    public static final String[] AUTHOR_FIRST_NAME = {"Петя", "Стела", "Елена", "Катя"};

    public static final String[] AUTHOR_LAST_NAME = {"Иванова", "Петрова", "Кирова"};

    public static final String[] TOWNS = {"София", "Пловдив", "Варна", "Русе", "Бургас"};

    public static void main(String[] args) {

        Random random = new Random();

        String phrase = PHRASES[random.nextInt(PHRASES.length)];
        String event = EVENTS[random.nextInt(EVENTS.length)];
        String firstName = AUTHOR_FIRST_NAME[random.nextInt(AUTHOR_FIRST_NAME.length)];
        String lastName = AUTHOR_LAST_NAME[random.nextInt(AUTHOR_LAST_NAME.length)];
        String town = TOWNS[random.nextInt(TOWNS.length)];

        System.out.printf("%s %s - \n- %s %s, %s",phrase,event,firstName,lastName,town);
    }
}
