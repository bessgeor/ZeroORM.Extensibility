using System;

namespace ZeroORM.Extensibility.Common.Expressions.Exceptions
{
	public class ExpressionsException : ZeroORMException
	{
		public ExpressionsException() { }
		public ExpressionsException(string message) : base(message) { }
		public ExpressionsException(string message, Exception inner) : base(message, inner) { }
	}
}
