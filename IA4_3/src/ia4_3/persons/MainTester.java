package ia4_3.persons;

import java.io.FileReader;
import java.util.List;
import javax.xml.bind.JAXBContext;
import javax.xml.bind.Unmarshaller;

public class MainTester {

    public static void main(String[] args) {
    // <editor-fold defaultstate="collapsed" desc="TRY-CATCH Z ZADANIEM ">
        try{
            JAXBContext context = JAXBContext.newInstance(PersonList.class);
            Unmarshaller um = context.createUnmarshaller();
            
            FileReader file = new FileReader("persons.xml");
            PersonList persons = (PersonList) um.unmarshal(file);
            file.close();
            PersonManager bm = new PersonManager(persons.getPersons());
            List<Person> bs = bm.searchByName("Jan");
            
            for(Person item : bs){
                System.out.println(item.toString());
            }   
        } catch ( Exception e){
            e.printStackTrace();
        }
    //</editor-fold>
    }
}
