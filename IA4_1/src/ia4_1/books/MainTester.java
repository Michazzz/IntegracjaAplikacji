package ia4_1.books;

import java.io.File;
import java.io.FileReader;
import java.util.List;
import javax.xml.bind.JAXBContext;
import javax.xml.bind.Marshaller;
import javax.xml.bind.Unmarshaller;

public class MainTester { 
    public static void main(String[] args) {
        
        // <editor-fold defaultstate="collapsed" desc="TRY-CATCH Z INSTRUKCJI ">
        try{
            JAXBContext context = JAXBContext.newInstance(BookList.class);
            Unmarshaller um = context.createUnmarshaller();
            
            FileReader file = new FileReader("books.xml");
            BookList books = (BookList) um.unmarshal(file);
            file.close();
            BookManager bm = new BookManager(books.getBooks());
            List<Book> bs = bm.searchByTitle("Java");
            
            for(Book item : bs){
                System.out.println(item.toString());
            }   
        } catch ( Exception e){
            e.printStackTrace();
        }
    //</editor-fold>
        
        // <editor-fold defaultstate="collapsed" desc="TRY-CATCH ZADANIE 1 ">    
        try{
            JAXBContext context = JAXBContext.newInstance(BookList.class);
            Unmarshaller um = context.createUnmarshaller();
            
            FileReader file = new FileReader("books.xml");
            BookList books = (BookList) um.unmarshal(file);
            file.close();
            
            Book myBook = new Book();
            myBook.setAuthor("Michał Wojtalewicz");
            myBook.setTitle("Laboratorium z Java i XML");
            books.getBooks().add(myBook);
            
            BookManager bm = new BookManager(books.getBooks());
            List<Book> bs = bm.searchByTitle("Java");
            
            for(Book item : bs){
                System.out.println(item.toString());
            }
            
            books.setBooks(bs);
            
            Marshaller mm = context.createMarshaller();
            mm.marshal(books, new File("myBooks.xml"));
            
        } catch ( Exception e){
            e.printStackTrace();
        }
    //</editor-fold>
    
    }
}
