// Milan Murray X00162027 - 17 Oct 22
// CA1 - Long Jump

using System;

namespace LongJumps
{
	public enum EventType { Men, Ladies }
	public class Jump
	{
		public double jump_length; // Shouldn't use underscores. Should be private
		public double JumpLength
		{
			get
			{
				return jump_length;
			}
			init
			{
				if (value <= 10) // Also check if less than 0
				{
					jump_length = value;
				}
				else
				{
					throw new InvalidDataException("Cannot have jump lengths longer than 10 meters."); // Should be Argument exception
				}
			}
		}

		public DateOnly jump_date;
		public DateOnly JumpDate
		{
			get
			{
				return jump_date;
			}
			init
			{
				jump_date = value;
			}
		}

		public Jump(double jump_length_in, DateOnly jump_date_in)
		{
			JumpLength = jump_length_in;
			JumpDate = jump_date_in;
			// jump_length = jump_length_in;
			// jump_date = jump_date_in;
		}

		public override string ToString()
		{
			return $"Length of jump: {Math.Round(jump_length, 2)}\nDate of jump: {jump_date}";
		}
	}

	public class LongJumper
	{
		string jumper_name { get; init; }
		string event_type { get; init; }

		private double pb { get; set; }
		private double sb { get; set; }


		public LongJumper(string jumper_name_in, string event_type_in)
		{
			jumper_name = jumper_name_in;
			event_type = event_type_in;
			pb = 0;
			sb = 0;
		}

		List<Jump> c_jumps = new List<Jump>();

		public void RecordJump(Jump jump_in)
		{
			if (!c_jumps.Any())
			{
				c_jumps.Append(jump_in);
				pb = jump_in.jump_length;
				sb = jump_in.jump_length;
			}
			else
			{

				if (jump_in.jump_date > c_jumps.Last().jump_date)
				{
					c_jumps.Append(jump_in);

					if (jump_in.jump_length > pb)
					{
						pb = jump_in.jump_length;
					}

					if (jump_in.jump_date.Year > c_jumps.Last().jump_date.Year)
					{
						sb = jump_in.jump_length;
					}
					else if (jump_in.jump_date.Year == c_jumps.Last().jump_date.Year)
					{
						if (jump_in.jump_length > sb)
						{
							sb = jump_in.jump_length;
						}
					}
				}
				else
				{
					throw new Exception("New jump is not the most recent.");
				}
			}
		}

		// public double GetAverage()
		// {
		// 	double total_distance = 0;
		// 	foreach (Jump j in c_jumps)
		// 	{
		// 		total_distance += j.jump_length;
		// 	}

		// 	return total_distance / c_jumps.Count;
		// }


		public override string ToString()
		{
			return $"Name: {jumper_name}, Event: {event_type}, PB: {Math.Round(pb, 2)}, SB: {Math.Round(sb, 2)}";
		}
	}

	public class Test
	{
		public static void Main()
		{
			LongJumper p1 = new LongJumper("Alex", "Ladies");
			LongJumper p2 = new LongJumper("John", "Men");

			Jump j1 = new Jump(2.1234567, new DateOnly(2022, 05, 02));
			// Console.WriteLine(j1);
			p1.RecordJump(j1);
			// p1.RecordJump(new Jump(1.321332, new DateOnly(2021, 05, 02)));
			Console.WriteLine(p1);
			Console.WriteLine(p2);

			// Not working correctly, allows incorrect date
			p2.RecordJump(new Jump(1.321332, new DateOnly(2021, 05, 02))); 
			p2.RecordJump(new Jump(3.321332, new DateOnly(2020, 05, 02))); 
			p2.RecordJump(new Jump(1.321332, new DateOnly(2010, 05, 02))); 
			Console.WriteLine(p2);

		}
	}
}
