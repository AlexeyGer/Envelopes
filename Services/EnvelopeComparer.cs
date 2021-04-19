using Envelopes.Interfaces;

namespace Envelopes.Services
{
    public class EnvelopeComparer : IEnvelopeComparer
    {
        public int CompareResult { get; set; }

        public EnvelopeComparer (IEnvelope envelope1, IEnvelope envelope2)
        {
            CompareResult = Compare(envelope1, envelope2);
        }

        public int Compare(IEnvelope envelope1, IEnvelope envelope2)
        {
            if (envelope1.MaxSideSize > envelope2.MaxSideSize && envelope1.MinSideSize > envelope2.MinSideSize)
                return 2;
            else if (envelope1.MaxSideSize < envelope2.MaxSideSize && envelope1.MinSideSize < envelope2.MinSideSize)
                return 1;
            else
                return 0;
        }
    }
}
