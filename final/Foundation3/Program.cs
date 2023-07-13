using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("4200 Fifth Ave", "Pittsburgh", "Pennsylvania", "USA");
        Address address2 = new Address("3134 Eastern Ave", "Baltimore", "Maryland", "USA");
        Address address3 = new Address("9201 Balloon Museum Dr NE", "Albuquerque", "New Mexico", "USA");

        Event lecture = new Lecture("Following the Equator", "Following the Equator (sometimes titled More Tramps Abroad) is a non-fiction social commentary in the form of a travelogue published in 1897.", DateTime.Now.Date, new TimeSpan(14, 30, 0), address1, "Samuel Langhorne Clemens", 998);
        Event reception = new Reception("The Big Show", "Creative Alliance supports area artists, promotes Baltimore as a center for creative production, acts as a positive force in our community, and advocates for cultural expression rooted in a sense of place.", DateTime.Now.Date.AddDays(7), new TimeSpan(18, 0, 0), address2, "info@creativealliance.org");
        Event outdoorGathering = new OutdoorGathering("International Balloon Fiesta", "For nine days in October, the Albuquerque skies are colorfully painted as more than 500 balloons lift off from Balloon Fiesta Park. Plan now to attend the Albuquerque International Balloon Fiesta® Powered by ExxonMobil and be part of the world's largest hot-air balloon festival.", DateTime.Now.Date.AddDays(86), new TimeSpan(10, 0, 0), address3, "Sunny");

        Event[] events = { lecture, reception, outdoorGathering };

        Console.Clear();

        foreach (var evnt in events)
        {
            Console.WriteLine("=== Standard Details ===");
            Console.WriteLine(evnt.GetStandardDetails());
            Console.WriteLine();

            Console.WriteLine("=== Full Details ===");
            Console.WriteLine(evnt.GetFullDetails());
            Console.WriteLine();

            Console.WriteLine("=== Short Description ===");
            Console.WriteLine(evnt.GetShortDescription());
            Console.WriteLine();

            Console.WriteLine("==========================================================================");
        }
    }
}
