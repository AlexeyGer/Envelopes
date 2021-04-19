using System;
using Envelopes.Sources;
using Envelopes.Interfaces;

namespace Envelopes.View
{
	public class Viewer : IViewer
    {
        public string[] GetEnvelopeSize()
        {
            string[] inputParams = new string[2];

            for (int sideNumber = 0; sideNumber < 2; sideNumber++)
            {
                Message.AskEnvelopeSize(sideNumber);
                inputParams[sideNumber] = Console.ReadLine();
            }

            return inputParams;
        }

        public void CompareResult(IEnvelopeComparer compareResult)
        {
            switch (compareResult.CompareResult)
            {
                case 2:
                    Message.ReportTheResult2();
                    break;

                case 1:
                    Message.ReportTheResult1();
                    break;

                case 0:
                    Message.ReportTheResult0();
                    break;
            }
        }

        public bool Continue()
        {
            Message.AskToContinue();
            string answer = Console.ReadLine().ToLower();

            if (answer == "y" || answer == "yes")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
