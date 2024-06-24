using System.Globalization;
using Ticket_Price_Calculator;

// take input age
int age = TicketPriceCalculator.InputAge();

// calculate price
decimal price = TicketPriceCalculator.CalculateTicketPrice(age);

// display price in GHC
Console.WriteLine($"Your ticket price is: {price.ToString("C", CultureInfo.CreateSpecificCulture("en-GH"))}");


