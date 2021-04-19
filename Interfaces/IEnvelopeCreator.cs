namespace Envelopes.Interfaces
{
	public interface IEnvelopeCreator
	{
		IEnvelope Create(IParser parser);
	}
}
