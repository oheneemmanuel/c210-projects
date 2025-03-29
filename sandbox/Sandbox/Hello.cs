public class Hello
{

    private string _name;
    private int _age;

    public Hello(Person person)
    {

        _name = person._name;
        _age = person._age;
    }

    
    public void DisplayName()
    {
        Console.WriteLine($"hello {_name}, you are {_age}");
    }




}