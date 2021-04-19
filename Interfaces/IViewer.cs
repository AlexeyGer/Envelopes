namespace Envelopes.Interfaces
{
	public interface IViewer
	{
		string[] GetEnvelopeSize();
		void CompareResult(IEnvelopeComparer compareResult);
		bool Continue();
	}
}
