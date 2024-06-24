using System.Globalization;

namespace Grade_Calculator;

public class GradeCalculator
{
   public static double TakeInput()
   {
      double invalidScore = -1;

      Console.WriteLine("Enter your score:");

      string? input = Console.ReadLine();

      if (string.IsNullOrWhiteSpace(input))
      {
         Console.WriteLine("Please enter a valid number");
         return invalidScore;
      }

      bool validInput = double.TryParse(input, NumberStyles.Number, CultureInfo.InvariantCulture, out double score);

      if (validInput)
      {
         if (score < 0 || score > 100)
         {
            Console.WriteLine("Score cannot be less than 0 or greater than 100");
            return invalidScore;
         }
      }
      else
      {
         Console.WriteLine("Enter a valid number");
         return invalidScore;
      }

      return score;
   }


   public static string CalculateGrade(double score)
   {

      if (score == -1)
      {
         return "Invalid Score";
      }

      string grade = "";
      switch (score)
      {
         case >= 90:
            grade = "A";
            break;
         case >= 80:
            grade = "B";
            break;
         case >= 70:
            grade = "C";
            break;
         case >= 60:
            grade = "D";
            break;

         default:
            grade = "F";
            break;
      }

      return $"Your grade is: {grade}";
   }
}
