using System.Globalization;

namespace Ticket_Price_Calculator;

public class TicketPriceCalculator
{
   public static int InputAge()
   {
      int invalidAge = -1;

      Console.WriteLine("Enter your age:");

      string? input = Console.ReadLine();

      if (string.IsNullOrWhiteSpace(input))
      {
         Console.WriteLine("Please enter a valid age.");
         return invalidAge;
      }

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

   public static decimal CalculateTicketPrice(int age)
   {
      if(age == -1) {
         Console.WriteLine("Age is invalid");
         return 0;
      }
      decimal discount = age >= 65 || age <= 12 ? 7m : 0;

      return 10m - discount;
   }

}
