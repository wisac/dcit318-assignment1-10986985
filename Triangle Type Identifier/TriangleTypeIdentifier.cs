namespace Triangle_Type_Identifier;

public class TriangleTypeIdentifier
{
   public static TriangleType Identify(Triangle triangle)
   {
      // set default triangle type
      TriangleType triangleType = TriangleType.Scalene;

      // find triangle type
      if (triangle.SideA == triangle.SideB || triangle.SideA == triangle.SideC || triangle.SideB == triangle.SideC)
      {
         triangleType = TriangleType.Isosceles;
      }

      if (triangle.SideA == triangle.SideB && triangle.SideA == triangle.SideC)
      {
         triangleType = TriangleType.Equilateral;
      }


      return triangleType;
   }

}


public enum TriangleType
{
   Equilateral,
   Isosceles,
   Scalene
}