using System;

namespace Vreme
{
	class Program
	{
		static void Main(string[] args)
		{
		
			DateTime vreme = DateTime.Now;
			DateTime vreme2 = vreme.AddMinutes(60);
			Console.WriteLine(vreme);
			Console.WriteLine(vreme.Date);
			
			if (vreme.Date == vreme2.Date)
				Console.WriteLine("jednaki su");
			else
				Console.WriteLine("nisu");
			Console.WriteLine(vreme.TimeOfDay.TotalHours);

			TimeSpan ts = new TimeSpan(6, 0, 0, 0);

			DateTime novi = DateTime.Now + ts;
			Console.WriteLine(novi);
		}
	}
}
