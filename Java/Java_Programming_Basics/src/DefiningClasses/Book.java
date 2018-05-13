package DefiningClasses;

public class Book {

    private String title;
    private String author;
    private String publisher;
    private int yearOfPublishing;

    public Book(String title, String author, String publisher, int yearOfPublishing) {
        this.title = title;
        this.author = author;
        this.publisher = publisher;
        this.yearOfPublishing = yearOfPublishing;
    }

    public String getTitle() {
        return title;
    }

    public String getAuthor() {
        return author;
    }

    public String getPublisher() {
        return publisher;
    }

    public int getYearOfPublishing() {
        return yearOfPublishing;
    }
}
