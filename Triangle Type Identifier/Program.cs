using Triangle_Type_Identifier;

try
{
   Triangle triangle = new Triangle();
   TriangleType triangleType = TriangleTypeIdentifier.Identify(triangle);

   Console.WriteLine($"Triangle type is: {triangleType}");
}
catch (Exception e)
{
   Console.WriteLine(e);
}

