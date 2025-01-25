using System;
using System.Collections.Generic;
using System.Linq;

// The Person class acts as a blueprint for storing and managing individual data such as ID, name, favorite color, and other attributes.
public class Person
{
    public int PersonId { get; set; } // Unique identifier for the person
    public string FirstName { get; set; } // First name of the person
    public string LastName { get; set; } // Last name of the person
    public string FavoriteColour { get; set; } // Favorite color of the person
    public int Age { get; set; } // Age of the person
    public bool IsWorking { get; set; } // Employment status of the person

    // Displays the person's ID, name, and favorite color in a formatted string
    public void DisplayPersonInfo()
    {
        Console.WriteLine($"{PersonId}: {FirstName} {LastName}'s favorite colour is {FavoriteColour}");
    }

    // Changes the person's favorite color to white
    public void ChangeFavoriteColour()
    {
        FavoriteColour = "White";
    }

    // Calculates and returns the person's age in ten years
    public int GetAgeInTenYears()
    {
        return Age + 10;
    }

    // Overrides the default ToString method to display all the person's information as a formatted string
    public override string ToString()
    {
        return $"PersonId: {PersonId}\nFirstName: {FirstName}\nLastName: {LastName}\nFavoriteColour: {FavoriteColour}\nAge: {Age}\nIsWorking: {IsWorking}";
    }
}

// The Relation class represents a relationship between two people, such as siblings or parents.
public class Relation
{
    public string RelationshipType { get; set; } // Type of relationship (e.g., Sisterhood, Brotherhood)

    // Displays the relationship type between two given Person objects
    public void ShowRelationShip(Person person1, Person person2)
    {
        Console.WriteLine($"Relationship between {person1.FirstName} and {person2.FirstName} is: {RelationshipType}");
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        // Creating Person objects
        Person ian = new Person { PersonId = 1, FirstName = "Ian", LastName = "Brooks", FavoriteColour = "Red", Age = 30, IsWorking = true };
        Person gina = new Person { PersonId = 2, FirstName = "Gina", LastName = "James", FavoriteColour = "Green", Age = 18, IsWorking = false };
        Person mike = new Person { PersonId = 3, FirstName = "Mike", LastName = "Briscoe", FavoriteColour = "Blue", Age = 45, IsWorking = true };
        Person mary = new Person { PersonId = 4, FirstName = "Mary", LastName = "Beals", FavoriteColour = "Yellow", Age = 28, IsWorking = true };

        // Displaying Gina's information
        gina.DisplayPersonInfo();

        // Displaying all of Mike's information
        Console.WriteLine(mike);

        // Changing Ian's favorite colour and displaying his information
        ian.ChangeFavoriteColour();
        ian.DisplayPersonInfo();

        // Displaying Mary's age in 10 years
        Console.WriteLine($"{mary.FirstName} {mary.LastName}'s Age in 10 years is: {mary.GetAgeInTenYears()}");

        // Creating Relation objects and showing relationships
        Relation sisterhood = new Relation { RelationshipType = "Sisterhood" };
        Relation brotherhood = new Relation { RelationshipType = "Brotherhood" };
        sisterhood.ShowRelationShip(gina, mary);
        brotherhood.ShowRelationShip(ian, mike);

        // Adding persons to a list
        List<Person> persons = new List<Person> { ian, gina, mike, mary };

        // Calculating average age
        double averageAge = persons.Average(p => p.Age);
        Console.WriteLine($"Average age is: {averageAge:F2}");

        // Finding youngest and oldest persons
        Person youngest = persons.OrderBy(p => p.Age).First();
        Person oldest = persons.OrderByDescending(p => p.Age).First();
        Console.WriteLine($"The youngest person is: {youngest.FirstName}");
        Console.WriteLine($"The oldest person is: {oldest.FirstName}");

        // Displaying names starting with 'M'
        var namesStartingWithM = persons.Where(p => p.FirstName.StartsWith("M"));
        foreach (var person in namesStartingWithM)
        {
            Console.WriteLine(person);
        }

        // Displaying information of the person who likes blue
        var personWhoLikesBlue = persons.FirstOrDefault(p => p.FavoriteColour == "Blue");
        if (personWhoLikesBlue != null)
        {
            Console.WriteLine(personWhoLikesBlue);
        }
    }
}
