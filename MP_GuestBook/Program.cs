
// Build a Console Guest Book.
// Ask user for their name and how many people are in their party.
// Keep track of how many people are at the party.
// At the end, print out guest list and total number of guests.

using MP_GuestBook;

//greet user
Methods.Welcome();

//obtain guest party name and size
(List<string> guests, int totalGuests) = Methods.AllGuestInfo();

//print out guest list and total number of attendees
Methods.DisplayGuests(guests);
Methods.DisplayGuestCount(totalGuests);