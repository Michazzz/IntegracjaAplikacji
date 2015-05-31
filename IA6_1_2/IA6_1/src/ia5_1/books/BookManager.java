package ia5_1.books;

import java.util.ArrayList;
import java.util.List;
import javax.jws.WebMethod;
import javax.jws.WebParam;
import javax.jws.WebResult;
import javax.jws.WebService;

@WebService
public class BookManager {
    private List<Book> books;
    
    public BookManager(List<Book> books) {
        this.books = books;
    }
    
    @WebMethod
    public @WebResult(name = "book") List<Book> searchByTitle(@WebParam(name = "title") String title) {
        List<Book> findedBooks = new ArrayList<>();
        for(Book book : books){
            if(book.getTitle().contains(title)){
                findedBooks.add(book);
            }
        }
        return findedBooks;
    }
    
    @WebMethod
    public @WebResult(name = "book") List<Book> searchByPublisher(@WebParam(name = "publisher")String publisher){
        List<Book> findedBooks = new ArrayList<>();
        for(Book book : books){
            if(book.getPublisher().contains(publisher)){
                findedBooks.add(book);
            }
        }
        return findedBooks;
    }
    
    @WebMethod
    public @WebResult(name = "book") Book searchByISBN(@WebParam(name = "isbn") String isbn){
        Book findedBook = null;
        for(Book book : books){
            if(book.getIsbn().equalsIgnoreCase(isbn)){
                findedBook = book;
            }
        }
        return findedBook;
    }
    
    @WebMethod
    public @WebResult(name = "book") Book addBook(@WebParam(name = "book")Book book){
        if(book.getTitle() != null && !book.getTitle().isEmpty() && book.getAuthors() != null && book.getAuthors().size() > 0 && !book.getAuthors().isEmpty()){
            if(book.getId() == null || book.getId().isEmpty()) book.setId(String.valueOf(books.size()+1));
            books.add(book);
           return book;
        } else {
            throw new NullPointerException("Title or Authos is empty");
        }
    }
}