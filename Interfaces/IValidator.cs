namespace Envelopes.Interfaces
{
	public interface IValidator
	{
		bool FormatValidation(string[] inputArgs, out string[] validArgs);
		bool PositiveValidation(double[] parsedArgs, out double[] validPositiveArgs);
	}
}
