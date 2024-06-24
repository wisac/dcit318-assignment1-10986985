using System.Globalization;
namespace Triangle_Type_Identifier;

public readonly struct Triangle
{
   private readonly double sideA;
   private readonly double sideB;
   private readonly double sideC;

   public Triangle()
   {
      this.sideA = TakeInput("side A") ;
      this.sideB = TakeInput("side B") ;
      this.sideC = TakeInput("side C") ;
   }

   public readonly double SideA
   {
      get
      {
         return sideA;
      }
   }

   public readonly double SideB
   {
      get
      {
         return sideB;
      }
   }

   public readonly double SideC
   {
      get
      {
         return sideC;
      }
   }

   private static double TakeInput(string sideName)
   {

      Console.WriteLine($"Enter length of {sideName} of triangle:");

      string? input = Console.ReadLine();

      if (string.IsNullOrWhiteSpace(input))
      {
         throw new InvalidDataException("Input must be a number");
      }

      bool validInput = double.TryParse(input, NumberStyles.Number, CultureInfo.InvariantCulture, out double side);

      if (validInput)
      {
         if (side <= 0)
         {
            throw new InvalidDataException("Side must be greater than 0");
         }
      }
      else
      {
         throw new InvalidDataException("Side must be a valid number");
      }

      return side;
   }
}

