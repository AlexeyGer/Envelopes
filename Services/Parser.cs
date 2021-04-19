using System;
using Envelopes.Interfaces;

namespace Envelopes.Services
{
	class Parser : IParser
	{
		public double MaxSideSize { get; set; }
		public double MinSideSize { get; set; }

		public Parser(IViewer viewer, IValidator validator)
		{
			string[] parsingArgs = viewer.GetEnvelopeSize();
			Parse(parsingArgs, validator);
		}

		public void Parse(string[] parsingArgs, IValidator validator)
		{
			double[] parsedArgs = new double[2];

			if (validator.FormatValidation(parsingArgs, out string[] validArgs))
			{
				for (int sideNumber = 0; sideNumber < 2; sideNumber++)
				{
					parsedArgs[sideNumber] = Double.Parse(validArgs[sideNumber]);
				}
			}

			if (validator.PositiveValidation(parsedArgs, out double[] validPositiveArgs))
			{
				if (validPositiveArgs[0] != validPositiveArgs[1])
				{
					MaxSideSize = Math.Max(validPositiveArgs[0], validPositiveArgs[1]);
					MinSideSize = Math.Min(validPositiveArgs[0], validPositiveArgs[1]);
				}
				else
				{
					MaxSideSize = MinSideSize = validPositiveArgs[0];
				}
			}
		}
	}
}
