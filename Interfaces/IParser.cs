namespace Envelopes.Interfaces
{
	public interface IParser
	{
		double MaxSideSize { get; set; }
		double MinSideSize { get; set; }
		void Parse(string[] parsingArgs, IValidator validator);
	}
}
