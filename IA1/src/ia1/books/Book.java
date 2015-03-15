package ia1.books;

public class Book {
    private String id;
    private String title;
    private String author;
    private String isbn;
    private Integer year;
    private String publisher;
    private Integer pages;
    
    public Book() {};

    public Book(String id, String title, String author, String isbn, Integer year, String publisher, Integer pages) {
        this.id = id;
        this.title = title;
        this.author = author;
        this.isbn = isbn;
        this.year = year;
        this.publisher = publisher;
        this.pages = pages;
    }
    
   public String getId() {
        return id;
    }

    public void setId(String id) {
        this.id = id;
    }

    public String getTitle() {
        return title;
    }

    public void setTitle(String title) {
        this.title = title;
    }

    public String getAuthor() {
        return author;
    }

    public void setAuthor(String author) {
        this.author = author;
    }

    public String getIsbn() {
        return isbn;
    }

    public void setIsbn(String isbn) {
        this.isbn = isbn;
    }

    public Integer getYear() {
        return year;
    }

    public void setYear(Integer year) {
        this.year = year;
    }

    public String getPublisher() {
        return publisher;
    }

    public void setPublisher(String publisher) {
        this.publisher = publisher;
    }

    public Integer getPages() {
        return pages;
    }

    public void setPages(Integer pages) {
        this.pages = pages;
    }

    @Override
    public String toString() {
        return String.format("Title: %s, author %s, ISBN: %s, publisher %s, pages %d", title, author, isbn, publisher, pages);
    }
}
