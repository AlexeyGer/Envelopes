using Envelopes.Interfaces;
using Envelopes.Models;

namespace Envelopes.Services
{
	public class EnvelopeCreator : IEnvelopeCreator
	{
		public IEnvelope createdEnvelope;

		public EnvelopeCreator(IParser parser)
		{
			createdEnvelope = Create(parser);
		}

		public IEnvelope Create(IParser parser)
		{
			double MaxSideSize = parser.MaxSideSize;
			double MinSideSize = parser.MinSideSize;

			return new Envelope(MaxSideSize, MinSideSize);
		}
	}
}
