using System;
using System.Linq.Expressions;

namespace ZeroORM.Extensibility.Common.Expressions
{
	using Exceptions;

	public static partial class LambaExtensions
	{
		/// <summary>
		/// Checks if <paramref name="expression"/> is simple property access (like x => x.Prop, but not x => x.PropOuter.PropInner or something more complicated)
		/// <para/>
		/// Returns corresponding PropInfo if successful and throws otherwise.
		/// <para/>
		/// Throws if <paramref name="expression"/> is null.
		/// </summary>
		/// <param name="expression">Expression to check</param>
		/// <returns>PropertyInfo corresponding to the property accessed by expression</returns>
		/// <exception cref="ShouldBeSimplePropertyAccessException" />
		/// <exception cref="ArgumentNullException" />
		public static System.Reflection.PropertyInfo IsSimplePropertyAccess( this LambdaExpression expression )
			=> expression == null
			? throw new ArgumentNullException( nameof( expression ) )
			: expression.Body.IsSimplePropertyAccess();

		/// <summary>
		/// Checks if <paramref name="expression"/> is simple property access (like x => x.Prop, but not x => x.PropOuter.PropInner or something more complicated)
		/// <para/>
		/// Returns corresponding PropInfo if successful and throws otherwise.
		/// <para/>
		/// Throws if <paramref name="expression"/> is null.
		/// </summary>
		/// <param name="expression">Expression to check</param>
		/// <returns>PropertyInfo corresponding to the property accessed by expression</returns>
		/// <exception cref="ShouldBeSimplePropertyAccessException" />
		/// <exception cref="ArgumentNullException" />
		public static System.Reflection.PropertyInfo IsSimplePropertyAccess( this Expression expression )
			=> expression == null
			? throw new ArgumentNullException( nameof( expression ) )
			: expression is MemberExpression memberAccess
				&& memberAccess.Member is System.Reflection.PropertyInfo property
				&& ( memberAccess.Expression is ParameterExpression || memberAccess.Expression is ConstantExpression )
				? property
				: throw new ShouldBeSimplePropertyAccessException( expression );
	}
}
