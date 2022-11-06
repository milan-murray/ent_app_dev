// Milan Murray - 17 Oct 22
// Indexers

using System;

namespace CAResults
{
	class ModuleCAResults
	{
		string module_name { get; set; }
		string student_name { get; set; }
		double num_of_credits { get; set; }

		double[] results;

		public ModuleCAResults()
		{
			this.module_name = "ENT";
			this.student_name = "Sara";
			this.num_of_credits = 4.5;

			this.results[0] = 80;
			this.results[1] = 60;
		}

		public override string ToString()
		{
			string return_value = "";
			return_value += $"Student name: {student_name}\n";
			return_value += $"Module name: {module_name}\n";
			return_value += $"Credits: {num_of_credits}\n\n";

			for (int i = 0; i < results.Length -1; i++)
			{
				return_value += $"CA{i+1}: {results[i]}\n";
			}
			return return_value;
		}

	}

	public class Test
	{
		public static void Main()
		{
			ModuleCAResults m = new ModuleCAResults();
			Console.WriteLine(m);
		}
	}
}
