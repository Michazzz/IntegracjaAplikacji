package ia4_2.books;

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
    
    public List<Book> searchByPublisher(String publisher){
        List<Book> findedBooks = new ArrayList<>();
        for(Book book : books){
            if(book.getPublisher().contains(publisher)){
                findedBooks.add(book);
            }
        }
        return findedBooks;
    }
    
    public Book searchByISBN(String isbn){
        Book findedBook = null;
        for(Book book : books){
            if(book.getIsbn().equalsIgnoreCase(isbn)){
                findedBook = book;
            }
        }
        return findedBook;
    }
}
