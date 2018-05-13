package DefiningClasses;

import java.io.BufferedOutputStream;
import java.util.ArrayList;
import java.util.LinkedList;

public class Library {

    private LinkedList<Book> books = new LinkedList<>();


    public void addBook(Book book){
        this.books.add(book);
    }

    public void searchingBook (Book book, String authorsName){
        if (authorsName.equals(book.getAuthor())){
            System.out.println(book.getTitle());
            System.out.println(book.getAuthor());
            System.out.println(book.getPublisher());
            System.out.println(book.getYearOfPublishing());
        }
    }

    public void deletingBook (Book book){
        this.books.remove(book);
    }

    public void getInfo(){
        for (Book b : books){
            System.out.println(b.getAuthor());
            System.out.println(b.getYearOfPublishing());
            System.out.println(b.getPublisher());
            System.out.println(b.getTitle());
            System.out.println("-------------------------");
        }
    }
}
