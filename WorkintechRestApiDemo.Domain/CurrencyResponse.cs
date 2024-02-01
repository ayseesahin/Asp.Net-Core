using System;
namespace WorkintechRestApiDemo.Domain
{
	public class CurrencyResponse
	{
        public double CAD { get; set; }
        public double EUR { get; set; }
        public double TRY { get; set; }
        public double USD { get; set; }
        public CurrencyResponse? data { get; set; }
    }

    public class CurrencyRoot
    {
        public CurrencyResponse? data { get; set; }
    }

}

