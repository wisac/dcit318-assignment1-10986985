using System.Globalization;

namespace Ticket_Price_Calculator;

public class TicketPriceCalculator
{
   public static int? InputAge()
   {
      // flag for invalid age
      int? invalidAge = null;

      Console.WriteLine("Enter your age:");

      string? input = Console.ReadLine();

      // When user does not enter any value
      if (string.IsNullOrWhiteSpace(input))
      {
         Console.WriteLine("Please enter a valid age.");
         return invalidAge;
      }

      // Parse input string to int if valid
      bool validInput = int.TryParse(input, NumberStyles.Integer, CultureInfo.InvariantCulture, out int age);

      if (validInput)
      {
         if (age < 1)
         {
            Console.WriteLine("A valid age must not be less than 1 year");
            return invalidAge;
         }
      }
      else
      {
         Console.WriteLine("Please enter a valid number as age");
      }

      return age;

   }

   public static string CalculateTicketPrice(int? age)
   {
      if (age == null) {
         Console.WriteLine("Age is invalid");
         return "Invalid";
      }
      decimal discount = age >= 65 || age <= 12 ? 7m : 0;

      decimal price = 10m - discount;

      return price.ToString("C", CultureInfo.CreateSpecificCulture("en-GH")); 
   }

}
