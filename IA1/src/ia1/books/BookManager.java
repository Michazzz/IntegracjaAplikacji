package ia1.books;

import java.util.ArrayList;
import java.util.List;

public class BookManager {
    private List<Book> books;

    public BookManager(List<Book> books) {
        this.books = books;
    }
    
    public List<Book> searchByTitle(String title) {
        List<Book> findedBooks = new ArrayList<>();
        for(Book book : books){
            if(book.getTitle().contains(title)){
                findedBooks.add(book);
            }
        }
        return findedBooks;
    }
    
    public List<Book> searchByAuthor(String author){
        List<Book> findedBooks = new ArrayList<>();
        for(Book book : books){
            if(book.getAuthor().contains(author)){
                findedBooks.add(book);
            }
        }
        return findedBooks;
    }
    
    public Book searchByISBN(String isbn){
        Book findedBook = new Book();
        for(Book book : books){
            if(book.getAuthor().equalsIgnoreCase(isbn)){
                findedBook = book;
            }
        }
        return findedBook;
    }
}
