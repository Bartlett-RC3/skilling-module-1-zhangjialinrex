
//Write a dog class and initialize an instance of the class

public class Dog
{
    //variable

     int age;
    float height;
     bool gender;
     string name;
    bool hungry;
    float energy;


    //constructor

    public Dog ( int _age, float _height, bool _gender, string _name)
    {

        age = _age;
        height = _height;
        gender = _gender;
        name = _name;
        hungry = true;
        energy = 100;
    }
    
    //function
    public void Dayinlife()
    {
        Ageing();
        Eating();
        Sleeping();

    }

    public string Getname()
    {
        return name;
    }

    public void Setname (string newname)
    {
        name = newname;
    }
   private void Ageing()
    {
        age = age + 1;
        energy = energy - 1;
    }

    public void Eating()
    {
        hungry = false;
        energy = energy - 1;
    }

    private void Sleeping()
    {
        hungry = true;
        energy = energy + 1;
    }





}