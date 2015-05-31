package ia5_2.persons;

import java.util.List;
import javax.xml.bind.annotation.XmlElement;
import javax.xml.bind.annotation.XmlElementWrapper;
import javax.xml.bind.annotation.XmlType;

@XmlType(name = "person")
public class Person {
    private String name; 
    private String lastname; 
    private String birthday;
    private String sex; 
    private Integer age; 
    private String pesel;
    private List<String> education;

    public Person() {
    }

    public Person(String name, String lastname, String birthday, String sex, Integer age, String pesel, List<String> education) {
        this.name = name;
        this.lastname = lastname;
        this.birthday = birthday;
        this.sex = sex;
        this.age = age;
        this.pesel = pesel;
        this.education = education;
    }

    public String getName() {
        return name;
    }

    public void setName(String name) {
        this.name = name;
    }

    public String getLastname() {
        return lastname;
    }

    public void setLastname(String lastname) {
        this.lastname = lastname;
    }

    public String getBirthday() {
        return birthday;
    }

    public void setBirthday(String birthday) {
        this.birthday = birthday;
    }

    public String getSex() {
        return sex;
    }

    public void setSex(String sex) {
        this.sex = sex;
    }

    public Integer getAge() {
        return age;
    }

    public void setAge(Integer age) {
        this.age = age;
    }

    public String getPesel() {
        return pesel;
    }

    public void setPesel(String pesel) {
        this.pesel = pesel;
    }
    @XmlElement( name="school" )
    @XmlElementWrapper( name="education" )  
    public List<String> getEducation() {
        return education;
    }

    public void setEducation(List<String> education) {
        this.education = education;
    }

    @Override
    public String toString() {
        return String.format("Name %s, lastname: %s, birthday %s, sex %s, age: %d, pesel: %s, education: %s", name, lastname, birthday, sex, age, pesel, education);
    }
}