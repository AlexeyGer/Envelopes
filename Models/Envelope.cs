using Envelopes.Interfaces;

namespace Envelopes.Models
{
	class Envelope : IEnvelope
	{
		public double MaxSideSize { get; set; }
		public double MinSideSize { get; set; }

		public Envelope(double maxSideSize, double minSideSize)
		{
			MaxSideSize = maxSideSize;
			MinSideSize = minSideSize;
		}
	}
}
