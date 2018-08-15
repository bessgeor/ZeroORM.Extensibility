namespace ZeroORM.Extensibility.Metadata
{
	public interface IMetadataProvider
	{
		ITableMetadata<TEntity> GetTable<TEntity>();
	}
}
