using System;
using System.Reflection;

class Program
{
    static void Main(string[] args)
    {
        Person person1 = new Person( "ohene",  20);
        Person person2 = new Person("Pedro", 22);


        Hello hi = new Hello(person1);
        Hello hello = new Hello(person2);

        hello.DisplayName();
        
        
       


        hi.DisplayName();

    }

}