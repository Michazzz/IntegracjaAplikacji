package ia5_2.persons;

import com.sun.org.apache.xml.internal.security.utils.Base64;
import java.io.UnsupportedEncodingException;
import java.security.MessageDigest;
import java.security.NoSuchAlgorithmException;
import java.util.ArrayList;
import java.util.HashMap;
import java.util.List;
import java.util.Map;
import java.util.Map.Entry;
import java.util.logging.Level;
import java.util.logging.Logger;
import javax.jws.WebMethod;
import javax.jws.WebParam;
import javax.jws.WebResult;
import javax.jws.WebService;
import javax.naming.AuthenticationException;
import javax.security.auth.login.FailedLoginException;

@WebService
public class PersonManager {

    private List<Person> persons;
    private Map<String, String> userTokens = new HashMap<String, String>();

    public PersonManager(List<Person> persons) {
        this.persons = persons;
    }

    @WebMethod
    public @WebResult(name = "person") List<Person> searchByName(@WebParam(name = "name") String name, @WebParam(name = "token") String token) throws FailedLoginException {
        if(!userTokens.containsValue(token)){
            throw new javax.security.auth.login.FailedLoginException("Wrong token or expired.");
        }
        
        List<Person> findedBooks = new ArrayList<>();
        for (Person person : persons) {
            if (person.getName().contains(name)) {
                findedBooks.add(person);
            }
        }
        return findedBooks;
    }

    @WebMethod
    public @WebResult(name = "person") List<Person> searchByLastname(@WebParam(name = "lastname") String lastname, @WebParam(name = "token") String token) throws FailedLoginException {
        if(!userTokens.containsValue(token)){
            throw new javax.security.auth.login.FailedLoginException("Wrong token or expired.");
        }
        
        List<Person> findedPersons = new ArrayList<>();
        for (Person person : persons) {
            if (person.getLastname().contains(lastname)) {
                findedPersons.add(person);
            }
        }
        return findedPersons;
    }

    @WebMethod
    public @WebResult(name = "person") Person searchByPesel(@WebParam(name = "pesel") String pesel, @WebParam(name = "token") String token) throws FailedLoginException {
        if(!userTokens.containsValue(token)){
            throw new javax.security.auth.login.FailedLoginException("Wrong token or expired.");
        }
        
        Person findedPersons = null;
        for (Person person : persons) {
            if (person.getPesel().equalsIgnoreCase(pesel)) {
                findedPersons = person;
            }
        }
        return findedPersons;
    }

    @WebMethod
    public @WebResult(name = "sessionid") String loginRequest(@WebParam(name = "username") String username, @WebParam(name = "password") String password) {
        if (username.length() <= 0 || password.length() <= 0) {
            throw new VerifyError();
        }
        
        if(username.equals("testuser") && password.equals("P@ssw0rd")){
            MessageDigest md;
            String token = username + Long.toHexString(System.currentTimeMillis());
            for(int i = 0; i < 4096; i++){
                try {
                    md = MessageDigest.getInstance("MD5");
                    md.update(token.getBytes("UTF-8"));
                    byte[] digest = md.digest();

                    token = Base64.encode(digest);
                } catch (NoSuchAlgorithmException ex) {
                    Logger.getLogger(PersonManager.class.getName()).log(Level.SEVERE, null, ex);
                } catch (UnsupportedEncodingException ex) {
                    Logger.getLogger(PersonManager.class.getName()).log(Level.SEVERE, null, ex);
                }
            }
            
            userTokens.put(username, token);
            return token;
        } else {
            throw new VerifyError();
        }
    }
    
    @WebMethod
    public @WebResult(name = "logoutRequest") Boolean logout(@WebParam(name = "token") String token) throws FailedLoginException {
        if(!userTokens.containsValue(token)){
            throw new javax.security.auth.login.FailedLoginException("Wrong token or expired.");
        }
        
        String isRemove = null;
        for (Entry<String, String> entry : userTokens.entrySet()) {
            if (entry.getValue().equals(token)) {
                isRemove = userTokens.remove(entry.getKey());
            }
        }
        return isRemove != null;
    }
}