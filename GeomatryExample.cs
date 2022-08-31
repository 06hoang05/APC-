using System;

class GeometryExample
{
	static void ProcessCylinder()
	{
		double Radius, Height;
		double BaseArea, LateralArea, TotalArea;
		double Volume;

		Console.WriteLine("Enter the dimensions of the cylinder");
		Console.Write("Radius: ");
		Radius = double.Parse(Console.ReadLine());
		Console.Write("Height: ");
		Height = double.Parse(Console.ReadLine());

		BaseArea = Radius * Radius * Math.PI;
		LateralArea = 2 * Math.PI * Radius * Height;
		TotalArea = 2 * Math.PI * Radius * (Height + Radius);
		Volume = Math.PI * Radius * Radius * Height;

		Console.WriteLine("Cylinder Characteristics");
		Console.WriteLine("Radius:  {0}", Radius);
		Console.WriteLine("Height:  {0}", Height);
		Console.WriteLine("Base:    {0:F}", BaseArea);
		Console.WriteLine("Lateral: {0:F}", LateralArea);
		Console.WriteLine("Total:   {0:F}", TotalArea);
		Console.WriteLine("Volume:  {0:F}", Volume);
	}

	static void Main()
	{
		ProcessCylinder();

		Console.WriteLine();
	}
}
