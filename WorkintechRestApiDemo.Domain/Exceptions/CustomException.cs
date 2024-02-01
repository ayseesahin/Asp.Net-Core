using System;
namespace WorkintechRestApiDemo.Domain.Exceptions
{
	public class CustomException : Exception
	{
		public CustomException(string message):base(message)
		{
		}
	}
}

