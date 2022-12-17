
class Animal
{
    string name="lion";

    public string Name  //full property defination
    {
        get{
            return name;
        }
        
        set
        {
            if(value.Length > 3)
            {
                name = value;
            }

        }
    }
    public int age {get; private set;}=10000; //auto implemented 
    


    public void AnimalDetails()
    {
        Console.Write("Name: "+name+"\nAge: "+age);
    }

    public void AnimalLocation()
    {
        Console.Write("\n\nLions are found in the following countries: \n Africa\nIndia\nChina");
    }
}

