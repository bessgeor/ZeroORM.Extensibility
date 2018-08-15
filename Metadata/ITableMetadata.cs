using System;
using System.Linq.Expressions;
using HellBrick;

namespace ZeroORM.Extensibility.Metadata
{
	public interface ITableMetadata<TEntity>
	{
		string SchemaName { get; }
		string TableName { get; }
		string GetColumnName<TProperty>( [NoCapture]Expression<Func<TEntity, TProperty>> accessor );
	}
}
