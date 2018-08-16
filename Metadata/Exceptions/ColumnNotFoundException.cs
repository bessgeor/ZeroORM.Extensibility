using System.Reflection;

namespace ZeroORM.Extensibility.Metadata.Exceptions
{
	/// <summary>
	/// Means that <see cref="ITableMetadata{TEntity}"/> can't find any info for the property passed into <see cref="ITableMetadata{TEntity}.GetColumnName{TProperty}(System.Linq.Expressions.Expression{System.Func{TEntity, TProperty}})"/>
	/// </summary>
	public class ColumnNotFoundException : MetadataException
	{
		public ColumnNotFoundException(PropertyInfo property)
			: base( $@"Can't find column for the property ""{ property.Name }"" of type ""{ property.DeclaringType.FullName }""" )
		{

		}
	}
}
