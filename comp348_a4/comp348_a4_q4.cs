namespace comp348_a4_q34
{
    class FormatQuery
	{
		static void Main()
		{
			double[] radii = { 1, 2, 3 };

			IEnumerable<string> output =
				radii.Select(r => $"Area for a circle with a radius of '{r}' = {r * r * Math.PI:F2}");


			foreach (string s in output)
			{
				Console.WriteLine(s);
			}
			  
			Console.WriteLine("Press any key to exit.");
			Console.ReadKey();
		}
	}
}
