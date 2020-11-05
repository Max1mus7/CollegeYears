using System;
using System.Data;

namespace Civilization_Simulator
{
	public class PoliSys
	{
		int PoliticalType { get; set; }
		string PoliticalName { get; set; }
		//Direct Democracy, Republic, Monarchy, Constitutional Monarchy
		public PoliSys(int pt)
		{
			PoliticalType = pt;
			if (PoliticalType == 0)
			{
				PoliticalName = "Direct Democracy";
			}
			else if (PoliticalType == 1)
			{
				PoliticalName = "Republic";
			}
			else if (PoliticalType == 2)
			{
				PoliticalName = "Monarchy";
			}
			else if (PoliticalType == 3)
			{
				PoliticalName = "Constitutional Monarchy";
			}
			else
			{
				Console.WriteLine(new InvalidConstraintException("Invalid Political System expected"));
			}
		}
	}
}
