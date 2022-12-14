
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

// 1. Think of a real world scnario for following:
//     ``` 
//         TypeB inherits TypeA
//         TypeB implements InterfaceA
//     ```
//     1. Note that **TypeA** should have at least two methods, two fields and two properties.
//     1. Create instance of **TypeB**, show output of those methods in console.
// string animal; //variable
// public void animal_height()
//{
//    return "height";
//} 