using Envelopes.Interfaces;
using Envelopes.View;
using Envelopes.Services;

namespace Envelopes.Controllers
{
	public class EnvelopesController
	{
		public EnvelopesController()
		{
			Initialize();
		}

		public void Initialize()
		{
			const int ENVELOPES_NUMBER = 2;
			IViewer viewer = new Viewer();
			IValidator validator = new Validator();
			IEnvelope[] envelopesCouple = new IEnvelope[ENVELOPES_NUMBER];

			do
			{
				for (int numberOfEnvelope = 0; numberOfEnvelope < ENVELOPES_NUMBER; numberOfEnvelope++)
				{
					IParser parser = new Parser(viewer, validator);
					envelopesCouple[numberOfEnvelope] = new EnvelopeCreator(parser).createdEnvelope;
				}

				IEnvelopeComparer comparer = new EnvelopeComparer(envelopesCouple[0], envelopesCouple[1]);
				viewer.CompareResult(comparer);
			}

			while (viewer.Continue());
		}
	}
}
