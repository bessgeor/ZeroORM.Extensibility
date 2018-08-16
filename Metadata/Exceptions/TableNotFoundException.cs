using System;

namespace ZeroORM.Extensibility.Metadata.Exceptions
{
	/// <summary>
	/// Means that <see cref="IMetadataProvider"/> can't find corresponding table type for the entity type <see cref="TEntity"/>
	/// </summary>
	public class TableNotFoundException : MetadataException
	{
		public TableNotFoundException( Type entityType )
			: base( $"Can't find entity type { entityType.FullName }" )
		{

		}
	}
}
