using System;
using Calculator;

namespace UkrainianCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            var coreTest = new DomainService(new UkrainianLocalizedMessages());
            coreTest.CheckMath();
        }
    }

    public class UkrainianLocalizedMessages : ILocalizedMessages
    {
        public string Success
        {
            get { return "Це працює!"; }
        }

        public string Fail
        {
            get { return "Кляті помилки :("; }
        }
    }
}
