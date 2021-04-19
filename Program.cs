using System;
using Envelopes.Controllers;
using Envelopes.Sources;

namespace Envelopes
{
	class Program
	{
		static void Main(string[] args)
		{
			try
			{
				new EnvelopesController();
			}
			catch (Exception e)
			{
				Message.Instruction();
				//Console.WriteLine("\n" + e);
			}
			Console.ReadKey();
		}
	}
}
