using System;
using System.Linq.Expressions;

namespace ZeroORM.Extensibility.Common.Expressions.Exceptions
{
	public class ShouldBeSimplePropertyAccessException : ExpressionsException
	{
		public ShouldBeSimplePropertyAccessException( Expression targetExpression )
			: base( $@"Passed expression should be simple property access of the first order, like ""param => param.Property"", but ""{targetExpression}"" was passed in" )
		{

		}
	}
}
