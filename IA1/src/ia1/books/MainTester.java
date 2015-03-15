package ia1.books;

import java.util.ArrayList;
import java.util.List;

public class MainTester {

    public static void main(String[] args) {
        Book b1 = new Book("b1", "Koparka dla opornych", "Zdzisław Maliniak", "123456789", 2000, "Some random", 762);
        Book b2 = new Book("b2", "Java rulez!", "James Gosling", "2244668800", 1998, "Some random", 762);
        Book b3 = new Book("b3", "Sadownictwo dla początkujących", "Steve Jobs", "13579135", 1990, "Some random", 762);
        Book b4 = new Book("b3", "Cudowne Jabłko", "Steve Jobs", "111112222333", 2000, "Some random", 762);
        
        List<Book> books = new ArrayList<>();
        books.add(b1);
        books.add(b2);
        books.add(b3);
        books.add(b4);
        
        BookManager manager = new BookManager(books);
        List<Book> finded = manager.searchByAuthor("Jobs");
        
        for(Book item : finded){
            System.out.println(item.toString());
        }

    }
}
