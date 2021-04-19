namespace Envelopes.Interfaces
{
	public interface IEnvelopeComparer
	{
		int CompareResult { get; set; }
		int Compare(IEnvelope envelope1, IEnvelope envelope2);
	}
}
