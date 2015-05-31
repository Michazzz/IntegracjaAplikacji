package ia5_2.persons;

import java.io.FileReader;
import java.util.List;
import javax.xml.bind.JAXBContext;
import javax.xml.bind.Unmarshaller;
import javax.xml.ws.Endpoint;

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
            String url = "http://localhost:666/persons";
            Endpoint.publish(url, bm);
        } catch ( Exception e){
            e.printStackTrace();
        }
    //</editor-fold>
    }
}
