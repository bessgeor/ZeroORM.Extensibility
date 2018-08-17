using System;
using ZeroORM.Extensibility.Common.Expressions;
using Xunit;
using System.Linq.Expressions;
using FluentAssertions;
using ZeroORM.Extensibility.Common.Expressions.Exceptions;

namespace ZeroORM.Extensibility.Common.Test.Expressions
{
	public class LambdaExpressionExtensionsTest
	{
		private class TestLv1
		{
			public int Property { get; set; }
		}

		private class TestLv2
		{
			public TestLv1 Nested { get; set; }
			public readonly int Field = 8;
			public int Method() => 8;
		}

		private static readonly Expression<Func<TestLv2, int>> _nestedPropertyAccess = v => v.Nested.Property;
		private static readonly Expression<Func<TestLv2, int>> _fieldAccess = v => v.Field;
		private static readonly Expression<Func<TestLv2, int>> _methodCall = v => v.Method();
		private static readonly Expression<Func<TestLv1, int>> _propertyAccess = v => v.Property;

		private static readonly System.Reflection.PropertyInfo _expectedPropertyInfo = typeof( TestLv1 )
			.GetProperty( nameof( TestLv1.Property ), System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.Instance );

		[Fact]
		public void LambdaVariantThrowsANE()
			=> ( (Action) ( () => ( null as LambdaExpression ).IsSimplePropertyAccess() ) )
			.Should()
			.Throw<ArgumentNullException>()
			.Which
			.ParamName
			.Should()
			.Be( "expression" );

		[Fact]
		public void CommonVariantThrowsANE()
			=> ( (Action) ( () => ( null as Expression ).IsSimplePropertyAccess() ) )
			.Should()
			.Throw<ArgumentNullException>()
			.Which
			.ParamName
			.Should()
			.Be( "expression" );

		[Fact]
		public void LambdaVariantThrowsAppropriateExceptionOnNonSimplePropertyAccess()
			=> ( (Action) ( () => _nestedPropertyAccess.IsSimplePropertyAccess() ) )
			.Should()
			.Throw<ShouldBeSimplePropertyAccessException>();

		[Fact]
		public void CommonVariantThrowsAppropriateExceptionOnNonSimplePropertyAccess()
			=> ( (Action) ( () => _nestedPropertyAccess.Body.IsSimplePropertyAccess() ) )
			.Should()
			.Throw<ShouldBeSimplePropertyAccessException>();

		[Fact]
		public void LambdaVariantThrowsAppropriateExceptionOnFieldAccess()
			=> ( (Action) ( () => _fieldAccess.IsSimplePropertyAccess() ) )
			.Should()
			.Throw<ShouldBeSimplePropertyAccessException>();

		[Fact]
		public void CommonVariantThrowsAppropriateExceptionOnFieldAccess()
			=> ( (Action) ( () => _fieldAccess.Body.IsSimplePropertyAccess() ) )
			.Should()
			.Throw<ShouldBeSimplePropertyAccessException>();

		[Fact]
		public void LambdaVariantThrowsAppropriateExceptionOnMethodCall()
			=> ( (Action) ( () => _methodCall.IsSimplePropertyAccess() ) )
			.Should()
			.Throw<ShouldBeSimplePropertyAccessException>();

		[Fact]
		public void CommonVariantThrowsAppropriateExceptionOnMethodCall()
			=> ( (Action) ( () => _methodCall.Body.IsSimplePropertyAccess() ) )
			.Should()
			.Throw<ShouldBeSimplePropertyAccessException>();

		[Fact]
		public void LambdaVariantReturnsExpectedPropertyInfo()
			=> _propertyAccess
			.IsSimplePropertyAccess()
			.Should()
			.BeSameAs( _expectedPropertyInfo );

		[Fact]
		public void CommonVariantReturnsExpectedPropertyInfo()
			=> _propertyAccess
			.Body
			.IsSimplePropertyAccess()
			.Should()
			.BeSameAs( _expectedPropertyInfo );
	}
}
