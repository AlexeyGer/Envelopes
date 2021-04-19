using System;

namespace Envelopes.Sources
{
	public static class Message
	{
		public static void AskEnvelopeSize(int sidenumber)
		{
			string side = sidenumber == 0 ? "length" : "width";
			Console.WriteLine($"\nPlease enter {side} of envelope");
		}

		public static void ReportTheResult2()
		{
			Console.WriteLine($"\nThe second envelope can be placed into the first envelope");
		}

		public static void ReportTheResult1()
		{
			Console.WriteLine($"\nThe first envelope can be placed into the second envelope");
		}

		public static void ReportTheResult0()
		{
			Console.WriteLine($"\nAny envelope can't be placed into another");
		}

		public static void AskToContinue()
		{
			Console.WriteLine($"\nPlease enter \"y\" or \"yes\" to continue or any key to close window");
		}

		public static void Instruction()
		{
			Console.WriteLine($"\nTo compare two envelopes" +
			$"\nPlease enter lenght and width of the each envelope" +
			$"\nThe lenght and width must be integer or float positive values");
		}
	}
}
