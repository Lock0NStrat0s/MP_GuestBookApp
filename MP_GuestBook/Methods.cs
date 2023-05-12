using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MP_GuestBook;

public static class Methods
{
    /// <summary>
    /// Greets user
    /// </summary>
    public static void Welcome()
    {
        Console.WriteLine("Welcome to the Guest Book Application!");
        Console.WriteLine("You will be asked to provide your name " +
            "and the size of your party.");
        Console.WriteLine("The guest list and total count will be displayed.");
    }

    /// <summary>
    /// Get information on party name and size
    /// </summary>
    /// <returns></returns>
    public static string GetPartyName()
    {
        Console.Write("\nWhat is your party/group name: ");
        return Console.ReadLine();
    }

    public static int GetPartySize()
    {
        int partySize;
        bool isValidNum;
        do
        {
            Console.Write("How many people are in your party: ");
            isValidNum = int.TryParse(Console.ReadLine(), out partySize);
        } while (!isValidNum);

        return partySize;
    }

    /// <summary>
    /// Store the names of each party and add the total number of guests
    /// </summary>
    public static (List<string> guests, int total) AllGuestInfo()
    {
        int totalGuests = 0;
        List<string> guests = new List<string>();

        do
        {
            guests.Add(GetPartyName());

            totalGuests += GetPartySize();
        } while (AskToContinue());

        return (guests, totalGuests);
    }

    /// <summary>
    /// Ask user to continue or end program
    /// </summary>
    /// <returns></returns>
    public static bool AskToContinue()
    {
        //ask user if there are more guests
        Console.Write("More guests (y/n): ");
        string runAgain = Console.ReadLine();

        return runAgain.ToLower() == "y";
    }

    /// <summary>
    /// Display guest list
    /// </summary>
    /// <param name="guests">List that holds group name</param>
    public static void DisplayGuests(List<string> guests)
    {
        int total = 0;
        Console.WriteLine();
        foreach (string guest in guests)
        {
            Console.WriteLine(guest);
        }
    }

    /// <summary>
    /// Total number of guests
    /// </summary>
    /// <param name="totalGuests">Total number of guests</param>
    public static void DisplayGuestCount(int totalGuests)
    {
        Console.WriteLine($"The total number of guests is {totalGuests}.");
    }
}
