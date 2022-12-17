class AssignmentLinq
{
    string[] countries={"nepal", "china", "japan", "india", "bangladesh", "korea", "portugal", "ireland", "new zealand", "australia", "maldives", "pakistan", "bhutan",  "usa", "france", "spain", "germany", "dubai", "qatar", "sri lanka"};
     public void GetAllCountries()
    {
        DisplayValues(countries, "Countries List: \n");
    }

//Assignment
    public void GetCountriesWithN()
    {
        var getCountries = countries.Where(x => x.StartsWith("n")); 

        DisplayValues(getCountries, "List Of Countries with starting letter N:\n");
    }

    public void GetCountriesLessOrEqualThan4()
    {
        var c = countries.Where(x=>x.Length<5);

        DisplayValues(c, "List of countries with length less than or equal to 4:\n");
    }

    public void GetCountriesToUpperCase()
    {
        var upper = countries.Select(x => x.ToUpper());

        DisplayValues(upper, "List of countries in uppercase:\n");
    }

    void DisplayValues<T>(IEnumerable<T> elements, string label)
    {
        Console.Write($"\n{label}");
        foreach (var x in elements)
        {
            Console.Write(x + " ");
        }
        Console.WriteLine();

    }
}