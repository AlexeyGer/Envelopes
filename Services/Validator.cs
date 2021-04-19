using System;
using Envelopes.Interfaces;

namespace Envelopes.Services
{
	public class Validator : IValidator
	{
        public bool FormatValidation(string[] inputArgs, out string[] validArgs)
        {
            validArgs = new string[2];

            for (int sideNumber = 0; sideNumber < 2; sideNumber++)
            {
                if (Double.TryParse(inputArgs[sideNumber], out _))
                {
                    validArgs[sideNumber] = inputArgs[sideNumber];
                }
                else
                {
                    throw new Exception();
                }
            }

            return true;
        }

        public bool PositiveValidation(double[] parsedArgs, out double[] validPositiveArgs)
        {
            validPositiveArgs = new double[2];

            for (int sideNumber = 0; sideNumber < 2; sideNumber++)
            {
                if (parsedArgs[sideNumber] > 0)
                {
                    validPositiveArgs[sideNumber] = parsedArgs[sideNumber];
                }
                else
                {
                    throw new Exception();
                }
            }

            return true;
        }
    }
}
