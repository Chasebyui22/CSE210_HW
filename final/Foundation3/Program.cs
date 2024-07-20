using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("1600 Pennsylvania Ave NW", "Washington", "DC", "20500", "USA");
        Address address2 = new Address("50 N Temple", "Salt Lake City", "UT", "84150", "USA");
        Address address3 = new Address("Sahara Desert", "Sahara", "SA", "N/A", "Africa");

        Lecture lecture = new Lecture("How to Be President", "Learn the essentials of becoming a president", "2024-08-15", "14:00", address1, "John Doe", 50);
        Reception reception = new Reception("Wedding", "Join us for the Wedding", "2024-09-20", "19:00", address2, "rsvp@example.com");
        OutdoorGathering gathering = new OutdoorGathering("Desert Picnic", "Community picnic in the Sahara Desert", "2024-07-04", "12:00", address3, "Sunny with a high of 75°F");

        Event[] events = { lecture, reception, gathering };

        foreach (Event evt in events)
        {
            Console.WriteLine("Standard Details:");
            Console.WriteLine(evt.GetStandardDetails());
            Console.WriteLine("\nFull Details:");
            Console.WriteLine(evt.GetFullDetails());
            Console.WriteLine("\nShort Description:");
            Console.WriteLine(evt.GetShortDescription());
            Console.WriteLine("\n-------------------\n");
        }
    }
}