using System.Globalization;
using Ticket_Price_Calculator;

int age = TicketPriceCalculator.InputAge();
decimal price = TicketPriceCalculator.CalculateTicketPrice(age);

Console.WriteLine($"Your ticket price is: {price.ToString("C", CultureInfo.CreateSpecificCulture("en-GH"))}");


