package DefiningClasses;

import java.util.List;

public class Main {

    public static void main(String[] args) {

        Book book1 = new Book("Levo","Levov","Edmond",2018);
        Book book2 = new Book("Sarko","Georgi","LSFC",2018);
        Book book3 = new Book("Levo2","Peter","LevskiSofiq",2018);
        Book book4 = new Book("Sarko2","Ivan","Levski",2018);

        Library library = new Library();

        library.addBook(book1);
        library.addBook(book2);
        library.addBook(book3);
        library.addBook(book4);

        library.deletingBook(book1);
        library.searchingBook(book1,"Levov");

        System.out.println();
        library.getInfo();
    }
}
