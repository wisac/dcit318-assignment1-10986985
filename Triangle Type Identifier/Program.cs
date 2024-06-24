using Triangle_Type_Identifier;

try
{
   // Instantiate new triangle
   Triangle triangle = new Triangle();

   // Get triangle type
   TriangleType triangleType = TriangleTypeIdentifier.Identify(triangle);

   // Display triangle type
   Console.WriteLine($"Triangle type is: {triangleType}");
}
catch (Exception e)
{
   Console.WriteLine(e);
}

