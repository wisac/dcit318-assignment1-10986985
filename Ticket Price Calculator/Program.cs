using System.Globalization;
using Ticket_Price_Calculator;

// take input age
int? age = TicketPriceCalculator.InputAge();

// calculate price
string priceInfo = TicketPriceCalculator.CalculateTicketPrice(age);

   
Console.WriteLine($"Your ticket price is: {priceInfo}");

// display price in GHC


