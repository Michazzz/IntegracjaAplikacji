package ia4_3.persons;

import java.util.ArrayList;
import java.util.List;

public class PersonManager {
    private List<Person> persons;

    public PersonManager(List<Person> persons) {
        this.persons = persons;
    }
    
        public List<Person> searchByName(String name) {
        List<Person> findedBooks = new ArrayList<>();
        for(Person person : persons){
            if(person.getName().contains(name)){
                findedBooks.add(person);
            }
        }
        return findedBooks;
    }
    
    public List<Person> searchByLastname(String lastname){
        List<Person> findedPersons = new ArrayList<>();
        for(Person person : persons){
            if(person.getLastname().contains(lastname)){
                findedPersons.add(person);
            }
        }
        return findedPersons;
    }
    
    public Person searchByPesel(String pesel){
        Person findedPersons = null;
        for(Person person : persons){
            if(person.getPesel().equalsIgnoreCase(pesel)){
                findedPersons = person;
            }
        }
        return findedPersons;
    }
}
